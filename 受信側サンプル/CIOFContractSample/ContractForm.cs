using CIOF_SDK.Model;
using System.Linq;
using System.Windows.Forms;

namespace CIOFContractSample
{
	public partial class ContractForm : Form
	{

		public ContractForm()
		{
			InitializeComponent();
		}

		public ContractForm(ContractRoot contractRoot)
		{
			InitializeComponent();

			if (contractRoot != null
				&& contractRoot.contracts != null
				&& contractRoot.contracts.Any())
			{
				foreach (var contract in contractRoot.contracts)
				{
					var eventCount = contract.event_implementations_id.Count();

					for (int i = 0; i < eventCount; i++)
					{
						dataGridView1.Rows.Add(contract.id,
							 contract.contract_type,
							 contract.send_type,
							 contract.service_implementation_id,
							 contract.service_implementation_local_id,
							 contract.process_implementation_id,
							 contract.process_implementation_local_id,
							 contract.event_implementations_id[i],
							 contract.event_implementations_local_id[i]);
					}
					
				}				
			}			
		}
	}
}
