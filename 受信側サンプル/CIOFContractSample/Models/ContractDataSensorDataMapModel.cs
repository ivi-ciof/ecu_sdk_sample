using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIOFContractSample.Models
{
    /// <summary>
    /// 取引データIDとセンサーデータの詳細
    /// </summary>
    /// <remarks>センサーのデータ</remarks>
    [Table("ContractDataSensorDataMap")]
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
        public string ContractDataID { get; set; }

        /// <summary>
        /// センサーデータID
        /// </summary>
        public int SensoreDataId { get; set; }
    }
}
