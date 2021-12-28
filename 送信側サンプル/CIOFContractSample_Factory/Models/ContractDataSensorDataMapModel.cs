using System.ComponentModel.DataAnnotations.Schema;

namespace CIOFContractSample_Factory.Models
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
        public string TradeDataID { get; set; }

        /// <summary>
        /// センサーデータID
        /// </summary>
        public int RecordId { get; set; }
    }
}
