using CIOF_SDK;
using CIOFContractSample.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIOFContractSample
{
	public partial class DeleteDataForm : Form
	{
		/// <summary>
		/// コントローラモデル
		/// </summary>
		ControllerModel controllerModel = null;

		/// <summary>
		/// コンストラクタ
		/// </summary>
		public DeleteDataForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="controller">コントローラモデル</param>
		/// <param name="deleteRecordList">データレコードリスト</param>
		public DeleteDataForm(ControllerModel controller, List<DataRecord> deleteRecordList)
		{
			InitializeComponent();

			this.controllerModel = controller;

			foreach (var deleteRecord in deleteRecordList)
			{
				this.dgvDeleteData.Rows.Add(true, deleteRecord.DataId, deleteRecord.Id, deleteRecord.Temperature, deleteRecord.Humidity, deleteRecord.CO2, deleteRecord.TimeStamp);
			}
		}
		/// <summary>
		/// deleteボタンクリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnDelete_Click(object sender, EventArgs e)
		{
			using (var context = new SampleDBContext())
			{
				var dataIdList = new List<string>();
				for (int i = 0; i < this.dgvDeleteData.Rows.Count; i++)
				{
					bool isChecked = (bool)this.dgvDeleteData.Rows[i].Cells[0].Value;

					if (isChecked)
					{
						var targetRecordId = (int)this.dgvDeleteData.Rows[i].Cells[2].Value;

						var targetRecord = context.DataRecords.Where(item => item.Id == targetRecordId).FirstOrDefault();
						targetRecord.IsDeleted = true;

						var targetDataId = (string)this.dgvDeleteData.Rows[i].Cells[1].Value;

						if (!dataIdList.Any(item => item == targetDataId))
						{
							dataIdList.Add(targetDataId);
						}
					}
				}

				context.SaveChanges();

				foreach (var dataId in dataIdList)
				{
					this.controllerModel.PostServiceRecordByDataId(dataId, "delete", "データを削除しました。");
				}
			}

			MessageBox.Show("データを削除しました。");
		}
	}
}
