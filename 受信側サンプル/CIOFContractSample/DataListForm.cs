using CIOF_SDK;
using CIOF_SDK.Model;
using CIOF_SDK.Util;
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
	public partial class DataListForm : Form
	{
		/// <summary>
		/// コントローラモデル
		/// </summary>
		ControllerModel controllerModel = null;
		/// <summary>
		/// データ実装状態リスト
		/// </summary>
		public DataImplementationsRoot DataList { get; set; }
		/// <summary>
		/// データステータスリスト
		/// </summary>
		public List<DataStatus> DataStatusList { get; set; }
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public DataListForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="controller">コントローラモデル</param>
		public DataListForm(ControllerModel controller)
		{
			InitializeComponent();

			this.controllerModel = controller;

			if (!this.controllerModel.IsControllerStart())
			{
				MessageBox.Show("コントローラが起動していません。");
			}
			else
			{
				DataList = controller.GetDataImplementations();
				DataStatusList = createDataStatusList(DataList);

				foreach (var dataInfo in DataList.data_implementations)
				{
					this.dgvDataList.Rows.Add(dataInfo.id, dataInfo.local_id, dataInfo.service_implementation_id, dataInfo.name, dataInfo.description);
				}
			}


		}
		/// <summary>
		/// データグリッドビュークリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void dgvDataList_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 5)
			{
				int rowIndex = e.RowIndex;
				DataGridViewRow selectedRow = this.dgvDataList.Rows[rowIndex];

				var dataId = selectedRow.Cells[0].Value?.ToString();

				var selectedDataStatus = this.DataStatusList.Where(item => item.id == dataId).FirstOrDefault();

				using (var frm = new DataSettingForm(this.controllerModel, selectedDataStatus))
				{
					if (frm.ShowDialog() == DialogResult.OK)
					{
						foreach (var currrenDataInfo in this.DataList.data_implementations.Where(item => item.id == dataId).ToList())
						{
							currrenDataInfo.local_id = frm.DataStatusInfo.local_id;
						}
						modifyDataStatus(frm.DataStatusInfo);


						RefreshDGV();
					}
				}
			}
		}

		/// <summary>
		/// データグリッドビュー更新
		/// </summary>
		private void RefreshDGV()
		{
			this.dgvDataList.Rows.Clear();

			foreach (var dataInfo in this.DataList.data_implementations)
			{
				this.dgvDataList.Rows.Add(dataInfo.id, dataInfo.local_id, dataInfo.service_implementation_id, dataInfo.name, dataInfo.description);
			}
		}
		/// <summary>
		/// データステータスリスト作成
		/// </summary>
		/// <param name="dataImplementationsRoot">データ実装状態</param>
		/// <returns>データステータスリスト</returns>

		private List<DataStatus> createDataStatusList(DataImplementationsRoot dataImplementationsRoot)
		{
			this.DataStatusList = new List<DataStatus>();


			foreach (var currentData in this.DataList.data_implementations)
			{
				var dataStatus = new DataStatus() { id = currentData.id, local_id = currentData.local_id, status = DataStatusConst.NORMAL, remarks = string.Empty };

				var dataPropertyStatusList = new List<DataPropertyStatus>();

				foreach (var dataPropertyInfo in currentData.data_property_implementations)
				{
					var tempDataPropertyInfo = new DataPropertyStatus() { id = dataPropertyInfo.id, index = dataPropertyInfo.index, local_id = dataPropertyInfo.local_id, name = dataPropertyInfo.name, status = DataStatusConst.NORMAL, remarks = string.Empty };
					dataPropertyStatusList.Add(tempDataPropertyInfo);
				}
				dataStatus.data_property_implementations = dataPropertyStatusList.ToArray();

				this.DataStatusList.Add(dataStatus);
			}

			return this.DataStatusList;
		}

		/// <summary>
		/// データ状態更新
		/// </summary>
		/// <param name="dataStatusInfo">データ状態</param>
		private void modifyDataStatus(DataStatus dataStatusInfo)
		{
			foreach (var currentData in this.DataStatusList.Where(item => item.id == dataStatusInfo.id).ToList())
			{
				currentData.local_id = dataStatusInfo.local_id;
				currentData.status = dataStatusInfo.status;
				currentData.remarks = dataStatusInfo.remarks;

				foreach (var dataPropertyInfo in currentData.data_property_implementations)
				{
					var latestDataPropertyInfo = dataStatusInfo.data_property_implementations.Where(item => item.id == dataPropertyInfo.id).FirstOrDefault();
					dataPropertyInfo.local_id = latestDataPropertyInfo.local_id;
					dataPropertyInfo.status = latestDataPropertyInfo.status;
					dataPropertyInfo.remarks = latestDataPropertyInfo.remarks;
				}
			}
		}

		/// <summary>
		/// updateボタンクリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnUpdate_Click(object sender, EventArgs e)
		{
			controllerModel.PutDataImplementationStatusList(DataStatusList);
			MessageBox.Show("データを更新しました。");
		}

		/// <summary>
		/// ExportJsonボタンクリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnExportJson_Click(object sender, EventArgs e)
		{
			var filePath = FileUtil.ShowSaveFileDialog(string.Empty, "JSONファイル(*.json) | *.json");
			FileUtil.SaveJsonFileBySpecifiedFileName<DataImplementationsRoot>(this.DataList, @filePath);
			MessageBox.Show("jsonファイルを出力しました。");
		}

		/// <summary>
		/// refreshボタンクリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnRefresh_Click(object sender, EventArgs e)
		{
			this.DataList = controllerModel.GetDataImplementations();
			RefreshDGV();
		}
	}
}