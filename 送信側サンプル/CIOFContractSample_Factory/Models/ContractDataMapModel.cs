using System.ComponentModel.DataAnnotations.Schema;

namespace CIOFContractSample_Factory.Models
{
    /// <summary>
    /// 契約IDと取引データIDのMapモデル
    /// </summary>
    /// <remarks>センサーのデータ</remarks>
    [Table("ContractDataMap")]
    public class ContractDataMapModel : BaseColumn
    {
        /// <summary>
        /// 契約ID
        /// </summary>
        public string ContractID { get; set; }

        /// <summary>
        /// 取引データID
        /// </summary>
        public string ContractDataID { get; set; }

        /// <summary>
        /// データのユニークにするためだけのやつ
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
    }
}
