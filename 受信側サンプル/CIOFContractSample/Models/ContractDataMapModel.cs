using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIOFContractSample.Models
{
    /// <summary>
    /// 契約IDと取引データIDのMapモデル
    /// </summary>
    /// <remarks>センサーのデータ</remarks>
    [Table("ContractDataMap")]
    public class ContractDataMapModel : BaseColumn
    {
        /// <summary>
        /// データのユニークにするためだけのやつ
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        /// <summary>
        /// 契約ID
        /// </summary>
        public string ContractID { get; set; }

        /// <summary>
        /// 取引データID
        /// </summary>
        public string TradeDataID { get; set; }


    }
}
