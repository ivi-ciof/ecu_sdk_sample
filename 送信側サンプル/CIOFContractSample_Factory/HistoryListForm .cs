using CIOF_SDK;
using System.Windows.Forms;

namespace CIOFContractSample_Factory
{
    /// <summary>
    /// 履歴画面
    /// </summary>
    public partial class HistoryListForm : Form
    {
        /// <summary>
        /// コントローラモデル
        /// </summary>
        public ControllerModel controllerModel;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public HistoryListForm()
        {
            InitializeComponent();
            // 画面更新
            UpdateShowDatas();
        }
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="controller">コントローラモデル</param>
        public HistoryListForm(ControllerModel controller)
		{
            InitializeComponent();
            // 画面更新
            UpdateShowDatas();
            this.controllerModel = controller;
		}

        /// <summary>
        /// 画面表示データ更新
        /// </summary>
        private void UpdateShowDatas()
        {
            // 表示停止
            this.SuspendLayout();

            //  DBからデータを取得
            using (var db = new Models.SqliteDbContext())
            {
                // 契約ID - 取引データID
                dgvContractMap.Rows.Clear();
                foreach (var dataMap in db.ContractDataMaps)
                {
                    dgvContractMap.Rows.Add(dataMap.ContractID, dataMap.TradeDataID, dataMap.CreateRecodeTime);
                }

                // 取引データID-センサーデータID
                dgvContractDataSensorDataMap.Rows.Clear();
                foreach (var dataMap in db.ContractDataSensorDataMaps)
                {
                    dgvContractDataSensorDataMap.Rows.Add(dataMap.TradeDataID, dataMap.RecordId,dataMap.CreateRecodeTime);
                }

                // センサーデータ詳細
                dgvSensorData.Rows.Clear();
                foreach(var sensorData in db.SensorDatas)
                {
                    dgvSensorData.Rows.Add(sensorData.id, sensorData.Tempareture, sensorData.Humidity, sensorData.CO2, sensorData.MeasureDate);

                }
            }

            // 表示再開
            this.ResumeLayout();
        }


        /// <summary>
        /// 更新ボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            UpdateShowDatas();
        }
        /// <summary>
        /// Delete Requestボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void btnSendDeleteRequest_Click(object sender, System.EventArgs e)
		{
            var selectedContractDataId = dgvContractMap.SelectedRows[0].Cells[0].Value as string;
            var selectedTradeDataId = dgvContractMap.SelectedRows[0].Cells[1].Value as string;

            controllerModel.PostRequestParameter(selectedContractDataId, "delete", null, selectedTradeDataId);

			MessageBox.Show("削除リクエストを送信しました。");
		}
	}
}
