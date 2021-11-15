using CIOF_SDK.Model;
using System.Windows.Forms;

namespace CIOFContractSample_Factory
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

            foreach (var contractModel in contractRoot.contracts)
            {
                for (int i = 0; i < contractModel.event_implementations_id.Length; i++)
				{
                    dgvContract.Rows.Add(contractModel.id
                                       , contractModel.contract_type
                                       , contractModel.data_implementation_local_id
                                       , contractModel.service_implementation_local_id
                                       , contractModel.process_implementation_local_id
                                       , contractModel.event_implementations_id[i]
                                       , contractModel.event_implementations_local_id[i]
                                       , contractModel.start_datetime?.ToString()
                                       , contractModel.end_datetime?.ToString());
                }
               
            }
        }
    }
}
