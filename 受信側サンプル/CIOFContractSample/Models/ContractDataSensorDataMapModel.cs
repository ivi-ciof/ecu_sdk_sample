using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIOFContractSample.Models
{
	public class ContractDataSensorDataMapModel : BaseColumn
	{
        /// <summary>
        /// 内部 ID   →Insert時の自動採番
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        /// <summary>
        /// 取引データID
        /// </summary>
        public string TradeDataID { get; set; }

        /// <summary>
        /// センサーデータID
        /// </summary>
        public int RecordId { get; set; }
    }
}
