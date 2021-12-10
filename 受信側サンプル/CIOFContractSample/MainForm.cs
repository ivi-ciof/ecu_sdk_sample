using CIOF_SDK;
using CIOF_SDK.Util;
using CIOFContractSample.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CIOFContractSample
{
	/// <summary>
	/// メインフォーム画面
	/// </summary>
	public partial class MainForm : Form
	{
		/// <summary>
		/// コントローラモデル
		/// </summary>
		ControllerModel controllerModel = null;

		/// <summary>
		/// データリスト
		/// </summary>
		List<DataRecord> dataRecordList = null;

		/// <summary>
		/// 取引データリスト
		/// </summary>
		List<TradeDataRecord> tradeDataRecordList = null;

		private string LOCAL_SERVICE_ID = Properties.Settings.Default.LOCAL_SERVICE_ID;

		/// <summary>
		/// コンストラクタ
		/// </summary>
		public MainForm()
		{
			InitializeComponent();
			var currentDirectory = Directory.GetCurrentDirectory();
			controllerModel = new ControllerModel(currentDirectory);

			if (Properties.Settings.Default.SAVE_TYPE == "data")
			{
				rbtnDB.Checked = true;
				rbtnSaveFile.Checked = false;
			}
			else if (Properties.Settings.Default.SAVE_TYPE == "file")
			{
				rbtnDB.Checked = false;
				rbtnSaveFile.Checked = true;
			}

			if (Properties.Settings.Default.POLLING_TYPE == "get")
			{
				rbtnGetData.Checked = true;
			}
		}

		/// <summary>
		/// Initial Settingボタンクリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnInitialSetting_Click(object sender, EventArgs e)
		{
			var currentDirectory = Directory.GetCurrentDirectory();
			var servicePath = Path.Combine(currentDirectory, "serviceimplement.json");
			var dataPath = Path.Combine(currentDirectory, "dataimplement.json");

			if (string.IsNullOrEmpty(this.txtAddress.Text))
			{
				MessageBox.Show("アドレスが空です。");
				return;
			}

			Uri outUri;
			if (!Uri.TryCreate(this.txtAddress.Text, UriKind.Absolute, out outUri))
			{
				MessageBox.Show("アドレスが不正です。");
				return;
			}
			

			var serviceImplementsMethodListDict = new Dictionary<string, Action<string, List<Dictionary<string, object>>>>();
			serviceImplementsMethodListDict.Add(LOCAL_SERVICE_ID, StoreEnvironmentData);

			Dictionary<string, Action<string, string, string, string>> requestMethodDict = new Dictionary<string, Action<string, string, string, string>>();
			requestMethodDict.Add(LOCAL_SERVICE_ID, GetRequest);

			controllerModel.SetServiceMethod(serviceImplementsMethodListDict, null, requestMethodDict);

			Dictionary<string, Action> calendarProcessDict = new Dictionary<string, Action>();
			calendarProcessDict.Add("R5VWMHXL79", CalendarEvent);
			controllerModel.SetProcessMethod(calendarProcessDict);

			if (rbtnDB.Checked)
			{
				controllerModel.SetDataMethod(SaveDataToDB, GetDataId, null);
				this.dataRecordList = GetDataRecordList();
				this.tradeDataRecordList = new List<TradeDataRecord>();
			}
			else
			{
				this.dataRecordList = GetDataRecordListFromFile();
				controllerModel.SetDataMethod(SaveDataToFile, GetDataId, null);
				this.tradeDataRecordList = new List<TradeDataRecord>();
			}

			controllerModel.InitialSetting(this.txtAddress.Text, (int)this.nudPollingRate.Value, servicePath, dataPath);

			MessageBox.Show("初期設定を行いました。");
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
			if (rbtnDB.Checked)
			{
				Properties.Settings.Default.SAVE_TYPE = "data";
			}
			else
			{
				Properties.Settings.Default.SAVE_TYPE = "file";
			}

			if (rbtnGetData.Checked)
			{
				Properties.Settings.Default.POLLING_TYPE = "get";
			}
			else
			{
				Properties.Settings.Default.POLLING_TYPE = "send";
			}
			Properties.Settings.Default.Save();
			controllerModel.Close();
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
		/// リクエスト受信
		/// </summary>
		/// <param name="condition">条件</param>
		/// <param name="responseLimit">応答期限</param>
		/// <param name="tradeContractId">取引契約ID</param>
		/// <param name="dataId">データID</param>
		public void GetRequest(string condition, string responseLimit, string dataId, string tradeContactId)
		{
			// 削除処理実装予定
			if (!string.IsNullOrEmpty(dataId))
			{
				using (var context = new SampleDBContext())
				{
					var deleteTargetDataList = context.DataRecords.Where(item => item.DataId == dataId).ToList();

					foreach (var deleteTarget in deleteTargetDataList)
					{
						deleteTarget.DeleteFlg = true;
					}			

					context.SaveChanges();
				}

				controllerModel.PostServiceRecordByDataId(dataId, EventTypeConst.DELETE, "データを削除しました。");
			}
		}

		/// <summary>
		/// 受け取った環境データを格納する。
		/// </summary>
		/// <param name="tradeId">取引ID</param>
		/// <param name="contentList">データリスト</param>
		public void StoreEnvironmentData(string tradeId, List<Dictionary<string, object>> contentList)
		{
			OutputLogger.WriteDebugLog("calendar");
			if (tradeId == null) return;
			var tradeInfo = controllerModel.TradeDataRoot.trade_datas.Where(item => item.trade_contract_id == tradeId).FirstOrDefault();

			var dataId = string.Empty;
			if (tradeInfo != null)
			{
				dataId = tradeInfo.id;
			}

			foreach (var dict in contentList)
			{
				var tradeDataInfo = new TradeDataRecord();

				tradeDataInfo.TradeContractId = tradeInfo.id;
				tradeDataInfo.DataId = dataId;
				this.tradeDataRecordList.Add(tradeDataInfo);
				var dataRecordInfo = new DataRecord();
				dataRecordInfo.DataId = dataId;
				if (dict.ContainsKey("温度"))
				{
					dataRecordInfo.Temperature = (double)dict["温度"];
				}
				if (dict.ContainsKey("湿度"))
				{
					dataRecordInfo.Humidity = (double)dict["湿度"];
				}
				if (dict.ContainsKey("計測日時"))
				{
					dataRecordInfo.TimeStamp = ((DateTime)dict["計測日時"]).ToShortDateString();
				}				
				

				this.dataRecordList.Add(dataRecordInfo);
			}
		}

		/// <summary>
		/// リクエストパラメータ送信
		/// </summary>
		/// <param name="contractid">取引ID</param>
		/// <param name="contentList">取得データリスト</param>
		public void PostRequestParameter (string contractid, List<Dictionary<string, object>> contentList)
		{
			controllerModel.PostRequestParameter(contractid, "create", "Count=3,From = 2021/1/1,To=2021/12/31");
		}

		/// <summary>
		/// データID取得
		/// </summary>
		/// <param name="recordId">レコードID</param>
		/// <returns>データID</returns>
		public string GetDataId(string recordId)
		{
			using (new OutputLogger())
			{
				using (var context = new SampleDBContext())
				{
					var dataInfo = context.DataRecords.Where(item => item.Id.ToString() == recordId).FirstOrDefault();

					return dataInfo?.DataId;
				}
			}
		}

		/// <summary>
		/// データレコードリスト取得
		/// </summary>
		/// <returns>データレコードリスト</returns>
		public List<DataRecord> GetDataRecordList()
		{			
			using (new OutputLogger())
			{
				using (var context = new SampleDBContext())
				{
					var dataRecordList = context.DataRecords.ToList();
					
					return dataRecordList;
				}				
			}
		}

		/// <summary>
		/// ファイルからのデータリスト取得
		/// </summary>
		/// <returns>データレコードリスト</returns>
		public List<DataRecord> GetDataRecordListFromFile()
		{
			var dataRecordList = FileUtil.ReadJsonFile<List<DataRecord>>(@"C:\test\json\data.json");

			if (dataRecordList == null)
			{
				dataRecordList = new List<DataRecord>();
			}

			return dataRecordList;
		}

		/// <summary>
		/// 受け取ったデータを保存する。
		/// </summary>
		public void SaveDataToDB()
		{
			using (new OutputLogger())
			{
				foreach (var record in dataRecordList ?? new List<DataRecord>())
				{
					if (record.Id != 0)
					{
						continue;
					}
					var dataIdModel = new Models.DataRecord();
					dataIdModel.DataId = record.DataId;
					dataIdModel.Temperature = record.Temperature;
					dataIdModel.Humidity = record.Humidity;
					dataIdModel.TimeStamp = record.TimeStamp;

					SaveData(dataIdModel);
				}
			}
		}

		/// <summary>
		/// データ保存処理
		/// </summary>
		/// <param name="dataRecord">データレコード</param>
		public void SaveData(DataRecord dataRecord)
		{
			using (var context = new SampleDBContext())
			{
				context.DataRecords.Add(dataRecord);
				context.SaveChanges();
			}
		}

		/// <summary>
		/// データをファイルに保存する
		/// </summary>
		public void SaveDataToFile()
		{
			using (new OutputLogger())
			{
				FileUtil.SaveJsonFileToSpecifiedFolder<List<DataRecord>>(dataRecordList, @"C:\test\json", "data.json");

			}			
		}

		/// <summary>
		/// 環境データ表示
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnShowEnvironmentData_Click(object sender, EventArgs e)
		{
			using (var frm = new EnvironmentDataForm(this.LOCAL_SERVICE_ID, controllerModel, dataRecordList))
			{
				frm.ShowDialog();
			}
		}

		/// <summary>
		/// リクエスト送信
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnSendRequest_Click(object sender, EventArgs e)
		{
			using (var frm = new RequestForm(this.LOCAL_SERVICE_ID, controllerModel))
			{
				frm.ShowDialog();
			}			
		}

		private void btnShowServiceList_Click(object sender, EventArgs e)
		{
			using (var frm = new ServiceListForm(this.controllerModel))
			{
				frm.ShowDialog();
			}
		}

		private void btnShowDataList_Click(object sender, EventArgs e)
		{
			using (var frm = new DataListForm(this.controllerModel))
			{
				frm.ShowDialog();
			}
		}

		private void btnShowCalendar_Click(object sender, EventArgs e)
		{
			using (var frm = new CalendarForm(this.controllerModel))
			{
				frm.ShowDialog();
			}
		}

		private void CalendarEvent()
		{
			OutputLogger.WriteDebugLog("calendar event");
		}
	}	
}
