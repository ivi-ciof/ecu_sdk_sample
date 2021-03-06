using CIOF_SDK;
using CIOF_SDK.Model;
using CIOF_SDK.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CIOFContractSample
{
	public partial class ServiceListForm : Form
	{
		/// <summary>
		/// サービス実装状態リスト表示順
		/// </summary>
		private enum ServiceStatusList
		{
			ServiceId,
			ServiceLocalId,
			ServiceName,
			ServiceDescription,
			ProcessId,
			ProcessLocalId,
			ProcessName,
			ProcessDescription,
			EventId,
			EventLocalId,
			EventName,
			EventDescription,
			Setting
		}

		/// <summary>
		/// コントローラモデル
		/// </summary>
		ControllerModel controllerModel = null;
		/// <summary>
		/// サービス実装
		/// </summary>
		public ServiceImplementationsRoot serviceList { get; set; } 
		/// <summary>
		/// サービスステータスリスト
		/// </summary>
		public List<ServiceStatus> currentServiceStatusList { get; set; }

		/// <summary>
		/// コンストラクタ
		/// </summary>
		public ServiceListForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="controller">コントローラモデル</param>
		public ServiceListForm(ControllerModel controller)
		{
			InitializeComponent();

			this.controllerModel = controller;

			if (!this.controllerModel.IsControllerStart())
			{
				MessageBox.Show("コントローラが起動していません。");
			}
			else
			{
				this.serviceList = this.controllerModel.GetServiceImplementations();
				this.currentServiceStatusList = createServiceStatusList(this.serviceList);
				this.RefreshDGV();
			}
		}

		/// <summary>
		/// データグリッドビュークリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void dgvServiceList_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == (int)ServiceStatusList.Setting)
			{
				int rowIndex = e.RowIndex;
				DataGridViewRow selectedRow = this.dgvServiceList.Rows[rowIndex];

				var serviceId = selectedRow.Cells[(int)ServiceStatusList.ServiceId].Value.ToString();
				var serviceStatusInfo = this.currentServiceStatusList.Where(item => item.id == serviceId).FirstOrDefault();
				var currentServiceStatus = new ServiceStatus()
				{
					id = serviceId,
					local_id = serviceStatusInfo.local_id,
					status = serviceStatusInfo.status,
					remarks = serviceStatusInfo.remarks
				};

				var processId = selectedRow.Cells[(int)ServiceStatusList.ProcessId].Value.ToString();
				var processStatusInfo = serviceStatusInfo.process_implementations.Where(item => item.id == processId).FirstOrDefault();
				var currentProcessStatus = new ProcessStatus()
				{
					id = processId,
					local_id = processStatusInfo.local_id,
					status = processStatusInfo.status,
					remarks = processStatusInfo.remarks
				};

				var eventId = selectedRow.Cells[(int)ServiceStatusList.EventId].Value.ToString();
				var eventStatusInfo = processStatusInfo.event_implementations.Where(item => item.id == eventId).FirstOrDefault();
				var currentEventStatus = new EventStatus()
				{
					id = eventId,
					local_id = eventStatusInfo.local_id,
					status = eventStatusInfo.status,
					remarks = eventStatusInfo.remarks
				};

				using (var frm = new ServiceSettingForm(this.controllerModel, 
					                                    currentServiceStatus,
														currentProcessStatus,
														currentEventStatus))
				{
					if (frm.ShowDialog() == DialogResult.OK)
					{
						foreach (var currentServiceInfo in this.serviceList.service_Implementations.Where(item => item.id == serviceId).ToList())
						{
							currentServiceInfo.local_id = frm.ServiceStatusInfo.local_id;

							foreach (var processInfo in currentServiceInfo.process_implementations.Where(item => item.id == processId).ToList())
							{
								processInfo.local_id = frm.ProcessStatusInfo.local_id;

								foreach (var eventInfo in processInfo.event_implementations.Where(item => item.id == eventId).ToList())
								{
									eventInfo.local_id = frm.EventStatusInfo.local_id;

								}
							}
						}
						modifyServiceStatus(frm.ServiceStatusInfo, frm.ProcessStatusInfo, frm.EventStatusInfo);

						this.dgvServiceList.Rows.Clear();
						this.RefreshDGV();
					}
				}
			}	
		}

		/// <summary>
		/// refreshボタンクリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnRefresh_Click(object sender, EventArgs e)
		{
			this.dgvServiceList.Rows.Clear();
			this.serviceList = this.controllerModel.GetServiceImplementations();
			this.currentServiceStatusList = createServiceStatusList(serviceList);
			this.RefreshDGV();
		}

		/// <summary>
		/// データグリッドビュー更新
		/// </summary>
		private void RefreshDGV()
		{		
			foreach (var serviceInfo in serviceList.service_Implementations)
			{
				foreach (var processInfo in serviceInfo.process_implementations)
				{
					foreach (var eventInfo in processInfo.event_implementations)
					{
						this.dgvServiceList.Rows.Add(serviceInfo.id, 
							                         serviceInfo.local_id, 
													 serviceInfo.name, 
													 serviceInfo.description, 
													 processInfo.id, 
													 processInfo.local_id, 
													 processInfo.name, 
													 processInfo.description, 
													 eventInfo.id, 
													 eventInfo.local_id, 
													 eventInfo.name,
													 eventInfo.description);
					}
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
			controllerModel.PutServiceImplementationStatusList(this.currentServiceStatusList);
			MessageBox.Show("サービスIDを更新しました。");
		}

		/// <summary>
		/// サービス実装ステータスリスト作成
		/// </summary>
		/// <param name="serviceImplementationsRoot">サービス実装定義</param>
		/// <returns>サービス実装ステータスリスト</returns>
		private List<ServiceStatus> createServiceStatusList(ServiceImplementationsRoot serviceImplementationsRoot)
		{
			var serviceStatusList = new List<ServiceStatus>();
			var selectedServiceList = this.serviceList.service_Implementations.GroupBy(item => item.id);
			foreach (var selectedService in selectedServiceList)
			{
				var serviceStatus = new ServiceStatus() { id = selectedService.First().id, 
					                                      local_id = selectedService.First().local_id, 
					                                      status = ServiceStatusConst.NORMAL, 
					                                      remarks = string.Empty};
				var processList = new List<ProcessStatus>();
				foreach (var serviceInfo in selectedService)
				{
					var distinctProcessList = serviceInfo.process_implementations.GroupBy(item => item.id);
					foreach (var distinctProcess in distinctProcessList)
					{
						var processStatus = new ProcessStatus() { id = distinctProcess.First().id, 
							                                      local_id = distinctProcess.First().local_id, 
							                                      status = ServiceStatusConst.NORMAL, 
							                                      remarks = string.Empty };
						var eventStatusList = new List<EventStatus>();
						foreach (var processInfo in distinctProcess)
						{
							var distinctEventList = processInfo.event_implementations.GroupBy(item => item.id);
							foreach (var distinctEvent in distinctEventList)
							{
								var eventStatus = new EventStatus() { id = distinctEvent.First().id, 
									                                  local_id = distinctEvent.First().local_id, 
									                                  status = ServiceStatusConst.NORMAL, 
									                                  remarks = string.Empty };
								eventStatusList.Add(eventStatus);
							}

						}
						processStatus.event_implementations = eventStatusList.ToArray();
						processList.Add(processStatus);
					}
				}
				serviceStatus.process_implementations = processList.ToArray();
				serviceStatusList.Add(serviceStatus);
			}
			return serviceStatusList;
		}

		/// <summary>
		/// ステータスの値更新
		/// </summary>
		/// <param name="serviceStatusInfo">サービスステータス</param>
		/// <param name="processStatusInfo">プロセスステータス</param>
		/// <param name="eventStatusInfo">イベントステータス</param>
		private void modifyServiceStatus(ServiceStatus serviceStatusInfo, ProcessStatus processStatusInfo, EventStatus eventStatusInfo)
		{
			foreach(var currentService in this.currentServiceStatusList.Where(item => item.id == serviceStatusInfo.id).ToList())
			{
				currentService.local_id = serviceStatusInfo.local_id;
				currentService.status = serviceStatusInfo.status;
				currentService.remarks = serviceStatusInfo.remarks;

				foreach (var currentProcess in currentService.process_implementations.Where(item => item.id == processStatusInfo.id).ToList())
				{
					currentProcess.local_id = processStatusInfo.local_id;
					currentProcess.status = processStatusInfo.status;
					currentProcess.remarks = processStatusInfo.remarks;

					foreach (var currentEvent in currentProcess.event_implementations.Where(item => item.id == eventStatusInfo.id).ToList())
					{
						currentEvent.local_id = eventStatusInfo.local_id;
						currentEvent.status = eventStatusInfo.status;
						currentEvent.remarks = eventStatusInfo.remarks;
					}
				}
			}			
		}

		/// <summary>
		/// Export Jsonボタンクリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnExportJson_Click(object sender, EventArgs e)
		{
			var filePath = FileUtil.ShowSaveFileDialog(string.Empty, "JSONファイル(*.json) | *.json");
			FileUtil.SaveJsonFileBySpecifiedFileName<ServiceImplementationsRoot>(this.serviceList, @filePath);
			MessageBox.Show("jsonファイルを出力しました。");
		}
	}
}
