using CIOF_SDK;
using CIOF_SDK.Model;
using CIOFContractSample.Models;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CIOFContractSample
{
	public partial class EnvironmentDataForm : Form
	{
		/// <summary>
		/// サービス実装ローカルID
		/// </summary>
		string localServiceId { get; set; }
		/// <summary>
		/// イベント実装ローカルID
		/// </summary>
		string localEventId { get; set; }
		/// <summary>
		/// コントローラモデル
		/// </summary>
		ControllerModel controllerModel = null;
		/// <summary>
		/// データレコードリスト
		/// </summary>
		List<DataRecord> dataRecordList = null;

		public EnvironmentDataForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="currentLocalServiceId">サービス実装ローカルID</param>
		/// <param name="currentLocalEventId">サービス実装イベントID</param>
		/// <param name="controller">ECUモデル</param>
		/// <param name="currentDataRecordList"></param>
		public EnvironmentDataForm(string currentLocalServiceId, string currentLocalEventId, ControllerModel controller, List<DataRecord> currentDataRecordList)
		{
			InitializeComponent();

			this.controllerModel = controller;
			this.dataRecordList = currentDataRecordList;

			if (!controller.IsControllerStart())
			{
				MessageBox.Show("コントローラが起動していません。");
			}
			else
			{
				this.tbxContractId.Text = currentLocalServiceId;

				var dataIdList = new List<string>();
				if (currentDataRecordList != null && currentDataRecordList.Any())
				{
					foreach (var dataRecord in currentDataRecordList)
					{
						if (!dataIdList.Any(item => item == dataRecord.DataId))
						{
							dataIdList.Add(dataRecord.DataId);
							cbxDataId.Items.Add(dataRecord.DataId);
						}
						
					}
					this.cbxDataId.SelectedIndex = 0;
				}
			}
		}
		/// <summary>
		/// データIDリスト選択変更イベント
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cbxDataId_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			this.dgvEnvironmentData.Rows.Clear();

			string selectedDataId = this.cbxDataId.SelectedItem.ToString();

			var showDataRecordList = dataRecordList.Where(item => item.DataId == selectedDataId).ToList();

			foreach (var showData in showDataRecordList)
			{
				dgvEnvironmentData.Rows.Add(showData.Temperature, showData.Humidity, showData.CO2, showData.TimeStamp);
			}

			// 値を表示したことを通知
			controllerModel.PostServiceRecordByDataId(selectedDataId, EventTypeConst.USE, "データを受け取って画面に表示しました。", "1", localServiceId, localEventId);
		}
	}
}
