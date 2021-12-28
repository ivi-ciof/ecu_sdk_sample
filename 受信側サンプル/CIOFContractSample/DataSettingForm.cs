using CIOF_SDK;
using CIOF_SDK.Model;
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
	public partial class DataSettingForm : Form
	{
		/// <summary>
		/// コントローラモデル
		/// </summary>
		ControllerModel controllerModel = null;
		/// <summary>
		/// データステータス
		/// </summary>
		public DataStatus DataStatusInfo { get; set; }
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public DataSettingForm()
		{
			InitializeComponent();
		}
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="controller">コントローラモデル</param>
		/// <param name="dataStatus">データステータス</param>
		public DataSettingForm (ControllerModel controller, DataStatus dataStatus)
		{
			InitializeComponent();

			this.controllerModel = controller;

			SetComboBoxItem(this.cbxDataStatus);
			this.cbxDataStatus.SelectedItem = dataStatus.status;
			SetComboBoxColumnItem(this.cbxDataPropertyStatus);			

			this.tbxDataImplementationId.Text = dataStatus.id;
			this.tbxDataImplementationLocalId.Text = dataStatus.local_id;
			this.tbxRemarks.Text = dataStatus.remarks;

			foreach (var dataProperty in dataStatus.data_property_implementations)
			{
				this.dgvDataProperty.Rows.Add(dataProperty.index, dataProperty.id, dataProperty.local_id, dataProperty.name, dataProperty.status, dataProperty.remarks);
			}
		}
		/// <summary>
		/// updateボタンクリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnUpdate_Click(object sender, EventArgs e)
		{
			var dataStatusPropertyList = new List<DataPropertyStatus>();
			DataStatusInfo = new DataStatus();
			DataStatusInfo.id = this.tbxDataImplementationId.Text;
			DataStatusInfo.local_id = this.tbxDataImplementationLocalId.Text;
			DataStatusInfo.status = this.cbxDataStatus.Text;
			DataStatusInfo.remarks = this.tbxRemarks.Text;

			foreach (DataGridViewRow row in this.dgvDataProperty.Rows)
			{
				var dataPropertyInfo = new DataPropertyStatus();
				dataPropertyInfo.index = (int)row.Cells[0].Value;
				dataPropertyInfo.id = row.Cells[1].Value?.ToString();
				dataPropertyInfo.local_id = row.Cells[2].Value?.ToString();
				dataPropertyInfo.status = row.Cells[4].Value?.ToString();
				dataPropertyInfo.remarks = row.Cells[5].Value?.ToString();

				dataStatusPropertyList.Add(dataPropertyInfo);
			}
			DataStatusInfo.data_property_implementations = dataStatusPropertyList.ToArray();

			this.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.Close();
		}

		/// <summary>
		/// コンボボックス設定
		/// </summary>
		/// <param name="comboBox">コンボボックスオブジェクト</param>
		private void SetComboBoxItem(ComboBox comboBox)
		{
			comboBox.Items.Add(DataStatusConst.NORMAL);
			comboBox.Items.Add(DataStatusConst.ABNORMAL);
			comboBox.Items.Add(DataStatusConst.EXCEPTION);
		}

		/// <summary>
		/// カラムのコンボボックス設定
		/// </summary>
		/// <param name="comboBoxColumn">コンボボックスカラムオブジェクト</param>
		private void SetComboBoxColumnItem(DataGridViewComboBoxColumn comboBoxColumn)
		{
			comboBoxColumn.Items.Add(DataStatusConst.NORMAL);
			comboBoxColumn.Items.Add(DataStatusConst.ABNORMAL);
			comboBoxColumn.Items.Add(DataStatusConst.EXCEPTION);
		}
	}
}
