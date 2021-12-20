using CIOF_SDK;
using CIOF_SDK.Model;
using System.Linq;
using System.Windows.Forms;

namespace CIOFContractSample
{
	public partial class ContractForm : Form
	{
		/// <summary>
		/// 契約情報
		/// </summary>
		private ContractRoot contract = null;

		/// <summary>
		/// コントローラモデル
		/// </summary>
		ControllerModel controllerModel = null;

		public ContractForm()
		{
			InitializeComponent();
		}

		public ContractForm(ContractRoot contractRoot, ControllerModel controller)
		{
			InitializeComponent();

			this.contract = contractRoot;
			this.controllerModel = controller;
			RefreshDGV();			
		}

		private void btnRefresh_Click(object sender, System.EventArgs e)
		{
			this.dgvContract.Rows.Clear();
			this.contract = controllerModel.GetContract();
			RefreshDGV();
		}

		private void RefreshDGV()
		{
			if (contract != null
				&& contract.contracts != null
				&& contract.contracts.Any())
			{
				foreach (var contractModel in contract.contracts)
				{
					for (int i = 0; i < contractModel.event_implementations_id.Length; i++)
					{
						dgvContract.Rows.Add(contractModel.id
										   , contractModel.contract_type
										   , contractModel.send_type
										   , contractModel.service_implementation_id
										   , contractModel.service_implementation_local_id
										   , contractModel.process_implementation_id
										   , contractModel.process_implementation_local_id
										   , contractModel.event_implementations_id[i]
										   , contractModel.event_implementations_local_id[i]
										   , contractModel.data_implementation_id
										   , contractModel.data_implementation_local_id
										   , contractModel.start_datetime?.ToString()
										   , contractModel.end_datetime?.ToString());
					}

				}
			}
		}
	}
}
