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

namespace CIOFContractSample_Factory
{
	public partial class ServiceSettingForm : Form
	{
		/// <summary>
		/// コントローラモデル
		/// </summary>
		ControllerModel controllerModel = null;
		public ServiceStatus ServiceStatusInfo { get; set; }
		public ProcessStatus ProcessStatusInfo { get; set; }
		public EventStatus EventStatusInfo { get; set; }

		public ServiceSettingForm()
		{
			InitializeComponent();
		}

		public ServiceSettingForm(ControllerModel controller,
								  ServiceStatus serviceStatus,
								  ProcessStatus processStatus,
								  EventStatus eventStatus)
		{
			InitializeComponent();

			this.controllerModel = controller;

			this.tbxServiceImplementationId.Text = serviceStatus.id;
			this.tbxServiceImplementationLocalId.Text = serviceStatus.local_id;
			SetComboBoxItem(this.cbxServiceStatus);
			this.cbxServiceStatus.SelectedItem = serviceStatus.status;
			this.tbxServiceRemarks.Text = serviceStatus.remarks;

			this.tbxProcessImplementationId.Text = processStatus.id;
			this.tbxProcessImplementationLocalId.Text = processStatus.local_id;
			SetComboBoxItem(this.cbxProcessStatus);
			this.cbxProcessStatus.SelectedItem = processStatus.status;
			this.tbxProcessRemarks.Text = processStatus.remarks;

			this.tbxEventImplementationId.Text = eventStatus.id;
			this.tbxEventImplementationLocalId.Text = eventStatus.local_id;
			SetComboBoxItem(this.cbxEventStatus);
			this.cbxEventStatus.SelectedItem = eventStatus.status;
			this.tbxEventRemarks.Text = eventStatus.remarks;

		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			ServiceStatusInfo = new ServiceStatus();
			ServiceStatusInfo.id = this.tbxServiceImplementationId.Text;
			ServiceStatusInfo.local_id = this.tbxServiceImplementationLocalId.Text;
			ServiceStatusInfo.status = this.cbxServiceStatus.Text;
			ServiceStatusInfo.remarks = this.tbxServiceRemarks.Text;

			ProcessStatusInfo = new ProcessStatus();
			ProcessStatusInfo.id = this.tbxProcessImplementationId.Text;
			ProcessStatusInfo.local_id = this.tbxProcessImplementationLocalId.Text;
			ProcessStatusInfo.status = this.cbxProcessStatus.Text;
			ProcessStatusInfo.remarks = this.tbxProcessRemarks.Text;

			EventStatusInfo = new EventStatus();
			EventStatusInfo.id = this.tbxEventImplementationId.Text;
			EventStatusInfo.local_id = this.tbxEventImplementationLocalId.Text;
			EventStatusInfo.status = this.cbxEventStatus.Text;
			EventStatusInfo.remarks = this.tbxEventRemarks.Text;

			this.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.Close();
		}

		/// <summary>
		/// コンボボックス設定
		/// </summary>
		/// <param name="comboBox"></param>
		private void SetComboBoxItem(ComboBox comboBox)
		{
			comboBox.Items.Add(ServiceStatusConst.NORMAL);
			comboBox.Items.Add(ServiceStatusConst.EXCEPTION);
			comboBox.Items.Add(ServiceStatusConst.FAILURE);
			comboBox.Items.Add(ServiceStatusConst.STOP);
		}
	}
}
