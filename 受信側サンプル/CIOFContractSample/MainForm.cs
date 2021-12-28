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
		List<DataRecord> currentDataRecordList = null;

		/// <summary>
		/// 削除データリスト
		/// </summary>
		List<DataRecord> deleteDataList = null;

		/// <summary>
		/// 取引データリスト
		/// </summary>
		List<TradeDataRecord> tradeDataRecordList = null;

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
			// サービス実装の登録
			var serviceImplementsMethodListDict = new Dictionary<string, Action<string, Dictionary<string, List<Dictionary<string, object>>>>>();
			serviceImplementsMethodListDict.Add(Properties.Settings.Default.LOCAL_SERVICE_ID, StoreEnvironmentData);

			// リクエストによって実行するサービス実装の登録
			Dictionary<string, Action<string, string, string, string>> requestMethodDict = new Dictionary<string, Action<string, string, string, string>>();
			requestMethodDict.Add(Properties.Settings.Default.LOCAL_SERVICE_ID, GetRequest);
			controllerModel.SetServiceMethod(serviceImplementsMethodListDict, null, requestMethodDict);

			// カレンダーイベントによって実行するプロセス実装の登録
			Dictionary<string, Action> calendarProcessDict = new Dictionary<string, Action>();
			calendarProcessDict.Add(Properties.Settings.Default.CALENDAR_EVENT_ID, CalendarProcess);
			controllerModel.SetProcessMethod(calendarProcessDict);

			if (rbtnDB.Checked)
			{
				controllerModel.SetDataMethod(SaveDataToDB, GetDataId);
				this.currentDataRecordList = GetDataRecordList();
				this.tradeDataRecordList = new List<TradeDataRecord>();
			}
			else
			{
				this.currentDataRecordList = GetDataRecordListFromFile();
				controllerModel.SetDataMethod(SaveDataToFile, GetDataId);
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
			using (var frm = new ContractForm(controllerModel.ContractRoot, controllerModel))
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
			// 削除対象リストに詰める
			if (!string.IsNullOrEmpty(dataId))
			{
				using (var context = new SampleDBContext())
				{
					if (deleteDataList == null)
					{
						deleteDataList = new List<DataRecord>();
					}
					var deleteTargetDataList = context.DataRecords.Where(item => item.DataId == dataId).ToList();

					foreach (var deleteTarget in deleteTargetDataList)
					{
						deleteTarget.IsRequested = true;
					}

					context.SaveChanges();
				}
			}
		}

		/// <summary>
		/// 受け取った環境データを格納する。
		/// </summary>
		/// <param name="contractId">取引ID</param>
		/// <param name="contentDict">データリスト</param>
		public void StoreEnvironmentData(string contractId, Dictionary<string, List<Dictionary<string, object>>> contentDict)
		{
			if (contractId == null || contentDict == null || !contentDict.Any()) return;
			var tradeInfo = controllerModel.TradeDataRoot.trade_datas.Where(item => item.trade_contract_id == contractId).FirstOrDefault();
			this.currentDataRecordList = new List<DataRecord>();

			var contractDataList = new List<ContractDataMapModel>();

			foreach (var dict in contentDict)
			{
				var dataRecordList = new List<DataRecord>();
				var dataId = dict.Key;

				foreach (var contentInfo in dict.Value)
				{
					var tradeDataInfo = new TradeDataRecord();

					tradeDataInfo.TradeContractId = tradeInfo.id;
					tradeDataInfo.DataId = dataId;
					this.tradeDataRecordList.Add(tradeDataInfo);
					var dataRecordInfo = new DataRecord();
					dataRecordInfo.DataId = dataId;

					if (contentInfo.ContainsKey(("温度")))
					{
						dataRecordInfo.Temperature = (double)contentInfo["温度"];
					}
					else if (contentInfo.ContainsKey(("Temperature")))
					{
						dataRecordInfo.Temperature = (double)contentInfo["Temperature"];
					}

					if (contentInfo.ContainsKey("湿度"))
					{
						dataRecordInfo.Humidity = (double)contentInfo["湿度"];
					}
					else if (contentInfo.ContainsKey(("Temperature")))
					{
						dataRecordInfo.Temperature = (double)contentInfo["Temperature"];
					}

					if (contentInfo.ContainsKey("二酸化炭素"))
					{
						dataRecordInfo.CO2 = (double)contentInfo["二酸化炭素"];
					}
					else if (contentInfo.ContainsKey(("CO2")))
					{
						dataRecordInfo.CO2 = (double)contentInfo["CO2"];
					}


					if (contentInfo.ContainsKey("計測日時"))
					{
						dataRecordInfo.TimeStamp = contentInfo["計測日時"].ToString();
					}
					else if (contentInfo.ContainsKey(("Time stamp")))
					{
						dataRecordInfo.TimeStamp = contentInfo["Time stamp"].ToString();
					}

					dataRecordList.Add(dataRecordInfo);
					this.currentDataRecordList.Add(dataRecordInfo);
				}

				using (var context = new SampleDBContext())
				{
					foreach (var dataRecord in dataRecordList)
					{
						context.DataRecords.Add(dataRecord);
						context.SaveChanges();

						var contractMap = new ContractDataSensorDataMapModel()
						{
							RecordId = dataRecord.Id,
							TradeDataID = dataId,
							IsDeleted = false,
							CreateRecodeTime = DateTime.Now,
							CreateRecodeUser = "test",
							UpdateRecordTime = DateTime.Now,
							UpdateRecodeUser = "test"
						};
						context.ContractDataSensorDataMaps.Add(contractMap);
					}

					var contractData = new ContractDataMapModel()
					{
						ContractID = contractId,
						TradeDataID = dataId,
						IsDeleted = false,
						CreateRecodeTime = DateTime.Now,
						CreateRecodeUser = "test",
						UpdateRecordTime = DateTime.Now,
						UpdateRecodeUser = "test"
					};
					context.ContractDataMaps.Add(contractData);

					context.SaveChanges();

				}

			}
		}

		/// <summary>
		/// リクエストパラメータ送信
		/// </summary>
		/// <param name="contractid">取引ID</param>
		/// <param name="contentList">取得データリスト</param>
		public void PostRequestParameter(string contractid, List<Dictionary<string, object>> contentList)
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
			var dataRecordList = new List<DataRecord>();
			var ofd = new OpenFileDialog();
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				dataRecordList = FileUtil.ReadJsonFile<List<DataRecord>>($@"{ofd.FileName}");
			}

			return dataRecordList;
		}

		/// <summary>
		/// 受け取ったデータを保存する。
		/// </summary>
		public void SaveDataToDB()
		{
			//using (new OutputLogger())
			//{
			//	foreach (var record in currentDataRecordList ?? new List<DataRecord>())
			//	{
			//		if (record.Id != 0)
			//		{
			//			continue;
			//		}
			//		var dataIdModel = new Models.DataRecord();
			//		dataIdModel.DataId = record.DataId;
			//		dataIdModel.Temperature = record.Temperature;
			//		dataIdModel.Humidity = record.Humidity;
			//		dataIdModel.TimeStamp = record.TimeStamp;

			//		SaveData(dataIdModel);
			//	}
			//}
		}

		/// <summary>
		/// 環境データ保存処理
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
				FileUtil.SaveJsonFileBySpecifiedFileName<List<DataRecord>>(currentDataRecordList, $@"{this.tbxSelect.Text}");

			}
		}

		/// <summary>
		/// 環境データ表示
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnShowEnvironmentData_Click(object sender, EventArgs e)
		{
			using (var frm = new EnvironmentDataForm(Properties.Settings.Default.LOCAL_SERVICE_ID, Properties.Settings.Default.LOCAL_EVENT_ID, controllerModel, currentDataRecordList))
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
			using (var frm = new RequestForm(Properties.Settings.Default.LOCAL_SERVICE_ID, controllerModel))
			{
				frm.ShowDialog();
			}
		}

		/// <summary>
		/// Show Service Listボタンクリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnShowServiceList_Click(object sender, EventArgs e)
		{
			using (var frm = new ServiceListForm(this.controllerModel))
			{
				frm.ShowDialog();
			}
		}

		/// <summary>
		/// Show Data Listボタンクリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnShowDataList_Click(object sender, EventArgs e)
		{
			using (var frm = new DataListForm(this.controllerModel))
			{
				frm.ShowDialog();
			}
		}

		/// <summary>
		/// Show Calendarボタンクリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnShowCalendar_Click(object sender, EventArgs e)
		{
			using (var frm = new CalendarForm(this.controllerModel))
			{
				frm.ShowDialog();
			}
		}

		/// <summary>
		/// カレンダー軌道によって実行されるプロセス
		/// </summary>
		private void CalendarProcess()
		{
			OutputLogger.WriteDebugLog("calendar event");
		}

		/// <summary>
		/// Show Historyボタンクリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnShowHistory_Click(object sender, EventArgs e)
		{
			using (var frm = new HistoryListForm(this.controllerModel))
			{
				frm.ShowDialog();
			}
		}

		/// <summary>
		/// Delete Dataボタンクリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnDeleteData_Click(object sender, EventArgs e)
		{
			var deleteTargetRecordList = new List<DataRecord>();
			using (var context = new SampleDBContext())
			{
				deleteTargetRecordList = context.DataRecords.Where(item => item.IsRequested).ToList();
			}
			using (var frm = new DeleteDataForm(this.controllerModel, deleteTargetRecordList))
			{
				frm.ShowDialog();
			}
		}

		/// <summary>
		/// Selectボタンクリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnSelect_Click(object sender, EventArgs e)
		{
			this.tbxSelect.Text = FileUtil.ShowSaveFileDialog(string.Empty, "jsonファイル(*.json)|*.json");
		}
	}
}
