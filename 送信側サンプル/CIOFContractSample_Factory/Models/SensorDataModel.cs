using System.ComponentModel.DataAnnotations.Schema;

namespace CIOFContractSample_Factory.Models
{
    /// <summary>
    /// 取引データIDとセンサーデータの詳細
    /// </summary>
    /// <remarks>センサーのデータ</remarks>
    [Table("SensorData")]
    public class SensorDataModel : BaseColumn
    {
        /// <summary>
        /// データのユニークにするためだけのやつ
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        /// <summary>
        /// 温度
        /// </summary>
        public double Tempareture { get; set; }

        /// <summary>
        /// 湿度
        /// </summary>
        public double Humidity { get; set; }

        /// <summary>
        /// データ時刻
        /// </summary>
        public string MeasureDate { get; set; }
    }
}
