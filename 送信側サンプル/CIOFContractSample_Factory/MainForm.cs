using CIOF_SDK;
using CIOF_SDK.Model;
using CIOFContractSample_Factory.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CIOFContractSample_Factory
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// コントローラの状態
        /// </summary>
        private enum ControllerStatus
        {
            /// <summary>Init</summary>
            INIT,
            /// <summary>Start</summary>
            START,
            /// <summary>ポーリング中</summary>
            POLLING,
            /// <summary>ストップ</summary>
            STOP
        }

        /// <summary>
        /// EdgeControllerAPIKey.ymlのIDを設定しておきます。
        /// </summary>
        private readonly string CONTROLLER_ID = "PG63LCKQGV";

        /// <summary>
        /// サービス実装のローカルID
        /// </summary>
        private readonly string LOCAL_SERVICE_ID = "testserviceid01";

        private readonly string LOCAL_PROCESS_ID = "6f56bafa-c922-4330-8b4f-cc999af7846d";

        /// <summary>
        /// コントローラモデル
        /// </summary>
        ControllerModel controllerModel = null;

        private object lockObj = new object();

        /// <summary>データ送信数 </summary>
        private int dataCount = 1;

        /// <summary>From日時</summary>
        private string fromDate = string.Empty;

        /// <summary>To日時</summary>
        private string toDate = string.Empty;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            var currentDirectory = Directory.GetCurrentDirectory();
            controllerModel = new ControllerModel(currentDirectory);
            SetEnvironmentData();
        }

        #region private method

        private void SetEnvironmentData()
		{
            this.dgvEnvironmentData.Rows.Add(22.1, 55.0, "2021/7/13");
            this.dgvEnvironmentData.Rows.Add(15.1, 43.0, "2021/8/13");
            this.dgvEnvironmentData.Rows.Add(18.1, 44.0, "2021/9/13");
        }

        /// <summary>
        /// リクエスト時のデータ送信サービス実装
        /// </summary>
        /// <param name="condition">条件文字列</param>
        /// <param name="response_limit">返答期限</param>
        /// <param name="trade_contract_id">取引契約ID</param>
        private void DataSendReqAction(string condition, string response_limit, string trade_contract_id)
        {
            // リクエストパラメータ解析
            if (!string.IsNullOrEmpty(condition))
            {
                var tempArray = condition.Split(',');
                var tempDic = new Dictionary<string, string>();

                foreach (var conditionPartArray in tempArray)
                {
                    var temp = conditionPartArray.Split('=');
                    tempDic[temp[0].Trim()] = temp[1];
                }

                // 数値変換チェック等はしない
                dataCount = tempDic.ContainsKey("Count") ? int.Parse(tempDic["Count"]) : dataCount;
                fromDate = tempDic.ContainsKey("From") ? tempDic["From"].ToString() : string.Empty;
                toDate = tempDic.ContainsKey("To") ? tempDic["To"].ToString() : string.Empty;
            }

            DataSendAction(trade_contract_id, new List<Dictionary<string, object>>());
        }

        /// <summary>
        /// データ送信サービス実装
        /// </summary>
        /// <param name="contractID">取引契約ID</param>
        /// <param name="tradeDataList">取引データのリスト key:辞書の項目名,value:値</param>
        private void DataSendAction(string contractID,  List<Dictionary<string, object>> tradeDataList )
        {
            // 引数の取引契約IDからコントローラの契約情報一覧から検索するべき
            // →SDK側で上記は実施している為、検索は気にしなくて良い。
            Contract targetContract = controllerModel.ContractRoot.contracts.FirstOrDefault(data => data.id == contractID);

            if (targetContract != null)
            {
                // 送信用のデータを作成
                var sendContentsList = CIOF_SDK.Util.TypeUtil.CreateSendDataList();

                var testObject = CIOF_SDK.Util.TypeUtil.CreateSendData();

                var sensorDataModelList = new List<SensorDataModel>();

                dataCount = dgvEnvironmentData.Rows.Count;
                for (int i = 0; i < dgvEnvironmentData.Rows.Count; i++)
                {
                    double temp;
                    double.TryParse(dgvEnvironmentData.Rows[i].Cells[0].Value.ToString(), out temp);
                    double hum;
                    double.TryParse(dgvEnvironmentData.Rows[i].Cells[1].Value.ToString(), out hum);
                    DateTime dateTime;
                    DateTime.TryParse(dgvEnvironmentData.Rows[i].Cells[2].Value.ToString(), out dateTime);

                    var sensorData = new Models.SensorDataModel()
                    {
                        Tempareture = temp,
                        Humidity = hum,
                        MeasureDate = dateTime.ToString(),
                        CreateRecodeUser = CONTROLLER_ID,
                        UpdateRecodeUser = CONTROLLER_ID
                    };
                    sensorDataModelList.Add(sensorData);
                }

                // DB保存
                using (var db = new SqliteDbContext())
                {
                    foreach (var sensorData in sensorDataModelList)
                    {
                        // DB内に温度湿度が同じデータがなければ保存
                        if (!db.SensorDatas.Any(item => item.Tempareture == sensorData.Tempareture && item.Humidity == sensorData.Humidity && sensorData.MeasureDate == item.MeasureDate))
						{
                            db.SensorDatas.Add(sensorData);
                        }
                        
                        db.SaveChanges();

                        // センサーID 
                        var sensorID = sensorData.id;
                    }

                    // リクエストパラメータでCountとTo とFrom が決まっていれば、センサーデータを検索
                    List<SensorDataModel> targetSensorDataList = sensorDataModelList;

					DateTime fromDatetime;
					// Fromのフィルター
					if (DateTime.TryParse(fromDate, out fromDatetime))
                    {
                        targetSensorDataList = targetSensorDataList.Where(item => Convert.ToDateTime(item.MeasureDate) >= fromDatetime).ToList();
                    }

					DateTime toDatetime;
					// Toのフィルター
					if (DateTime.TryParse(toDate, out toDatetime))
                    {
                        targetSensorDataList = targetSensorDataList.Where(item => Convert.ToDateTime(item.MeasureDate) <= toDatetime).ToList();
                    }

                    // 対象件数のみ取得
                    targetSensorDataList = targetSensorDataList.OrderByDescending(item => item.MeasureDate).Take(dataCount).ToList();

                    // データ件数分、送信データを作成
                    foreach (var data in targetSensorDataList)
                    {
                        var retDic = CIOF_SDK.Util.TypeUtil.CreateSendData();
                        retDic.Add("温度", data.Tempareture);
                        retDic.Add("湿度", data.Humidity);
                        retDic.Add("計測日時", Convert.ToDateTime(data.MeasureDate));

                        sendContentsList.Add(retDic);
                    }

                    // 取引データを送信
                    string contractDataID = controllerModel.PostTradeData(targetContract.id, sendContentsList);

                    // 契約IDと取引データIDのマップ
                    db.ContractDataMaps.Add(new ContractDataMapModel()
                    {
                        ContractID = targetContract.id,
                        ContractDataID = contractDataID,
                        CreateRecodeUser = CONTROLLER_ID,
                        UpdateRecodeUser = CONTROLLER_ID
                    }
                    );

                    // 取引データIDとセンサーデータIDのMapを保存
                    foreach (var tempSensorData in targetSensorDataList)
                    {
                        db.ContractDataSensorDataMaps.Add(new ContractDataSensorDataMapModel()
                        {
                            ContractDataID = contractDataID,
                            SensoreDataId = tempSensorData.id,
                            CreateRecodeUser = CONTROLLER_ID,
                            UpdateRecodeUser = CONTROLLER_ID
                        });
                    }

                    // DB保存
                    db.SaveChanges();
                }

                MessageBox.Show("データを送信しました。");
            }
        }

        #endregion

        #region イベント

        /// <summary>
        /// Initial Settingボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInitialSetting_Click(object sender, EventArgs e)
        {           

            // サービス実装登録をCall
            // 契約時メソッドの場合

            var requestServiceMethodListDict = new Dictionary<string, Action<string, string, string>>();
            requestServiceMethodListDict.Add(LOCAL_SERVICE_ID, DataSendReqAction);

            var processDict = new Dictionary<string, Action>();
            processDict.Add(LOCAL_PROCESS_ID, CalendarEvent);

            // データ送信数：リクエストパラメータに含まれる件数を返す
            //dataCount = 1;
            controllerModel.SetServiceMethod(new Dictionary<string, Action<string, List<Dictionary<string, object>>>>(),
                                    requestServiceMethodListDict,
                                    new Dictionary<string, Action<string, string, string, string>>());

            controllerModel.SetProcessMethod(processDict);

            var currentDirectory = Directory.GetCurrentDirectory();
            var servicePath = Path.Combine(currentDirectory, "serviceimplement.json");
            var dataPath = Path.Combine(currentDirectory, "dataimplement.json");
            controllerModel.InitialSetting(this.txtIP.Text, (int)this.nudPollingRate.Value, servicePath, dataPath);

            MessageBox.Show("初期設定を行いました。");
        }


        /// <summary>
        /// Startボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            controllerModel.PollingStart();
            MessageBox.Show("コントローラを起動しました。");
        }

        /// <summary>
        /// Show Contractボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowContract_Click(object sender, EventArgs e)
        {
            using (var frm = new ContractForm(controllerModel.ContractRoot))
            {
                frm.ShowDialog();
            }

        }

        /// <summary>
        /// Show Serviceボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowService_Click(object sender, EventArgs e)
        {
            using (var frm = new ServiceListForm(controllerModel))
            {
                frm.ShowDialog();
            }
        }

        /// <summary>
        /// データ実装表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDataImp_Click(object sender, EventArgs e)
        {
            using (var frm = new DataListForm(controllerModel, controllerModel.DataImplementationsRoot))
            {
                frm.ShowDialog();
            }

        }

        /// <summary>
        /// 履歴表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowHistory_Click(object sender, EventArgs e)
        {
            using (var form = new HistoryListForm(this.controllerModel))
            {
                form.ShowDialog();
            }

        }

        /// <summary>
        /// 最新データ削除要求 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSendDeleteReq_Click(object sender, EventArgs e)
        {
            using (var db = new SqliteDbContext())
            {
                // 契約が1件以上ある前提
                var contractID = controllerModel.ContractRoot.contracts[0].id;

                // 契約IDに紐づく取引データIDのマップ(一番古いデータ)取得
                var targetMap = db.ContractDataMaps.Where(data => data.ContractID == contractID && !data.DeleteFlg).OrderBy(data => data.CreateRecodeTime).FirstOrDefault();

                if (targetMap != null)
                {
                    controllerModel.PostRequestParameterByServiceId(LOCAL_SERVICE_ID, "delete", "From= 2021/1/1,To = 2021/12/31", targetMap.ContractDataID);

                    // 削除要求したのでいずれ相手側のコントローラで削除を実行するはずな為、対象データの削除フラグを立てる
                    // →TODO データの取り扱いどうすべきか各コントローラで検討した方が良い
                    targetMap.DeleteFlg = true;
                    db.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Stopボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStop_Click(object sender, EventArgs e)
        {
            controllerModel.Stop();
            MessageBox.Show("コントローラを停止しました。");
        }

        /// <summary>
        /// フォームを閉じるときの処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            controllerModel.Close();
        }

		#endregion

        /// <summary>
        /// データ送信
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void btnSendData_Click(object sender, EventArgs e)
		{
            // サービスIDから契約IDを取得
            var contractIdList = controllerModel.ContractRoot.contracts.Where(item => item.service_implementation_local_id == LOCAL_SERVICE_ID).ToList();
            foreach (var contractId in contractIdList)
			{
                this.DataSendAction(contractId.id, null);
            }            
		}

        private void CalendarEvent()
		{
            OutputLogger.WriteDebugLog("calendarEvent");
		}

		private void btnShowCalendar_Click(object sender, EventArgs e)
		{
            using (var frm = new CalendarForm(this.controllerModel))
            {
                frm.ShowDialog();
            }
        }

		private void btnSendRequest_Click(object sender, EventArgs e)
		{

		}
	}
}
