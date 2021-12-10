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
		TradeDataRoot contractDataRootModel { get; set; }

		public EnvironmentDataForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="ecumodel">ECUモデル</param>
		/// <param name="dataRecordList"></param>
		public EnvironmentDataForm(string localId, ControllerModel ecumodel, List<DataRecord> dataRecordList)
		{
			InitializeComponent();

			if (!ecumodel.IsControllerStart())
			{
				MessageBox.Show("コントローラが起動していません。");
			}
			else
			{
				var dataIdList = new List<string>();
				if (dataRecordList != null && dataRecordList.Any())
				{
					foreach (var dataRecord in dataRecordList)
					{
						if (!dataIdList.Any(item => item == dataRecord.DataId && !dataRecord.DeleteFlg))
						{
							dataIdList.Add(dataRecord.DataId);
						}
						dgvEnvironmentData.Rows.Add(dataRecord.DataId, dataRecord.Id, dataRecord.Temperature, dataRecord.Humidity, dataRecord.TimeStamp);
					}

					foreach (var dataId in dataIdList)
					{
						// 値を表示したことを通知
						ecumodel.PostServiceRecordByDataId(dataId, EventTypeConst.USE, "データを受け取って画面に表示しました。", "1", localId, "testeventid1");
					}
				}
			}
		}
	}
}
