using System.ComponentModel.DataAnnotations.Schema;

namespace CIOFContractSample.Models
{
	[Table("DataRecord")]
	public class DataRecord : BaseColumn
	{
		/// <summary>
		/// ID
		/// </summary>
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		/// <summary>
		/// データID
		/// </summary>
		public string DataId { get; set; }
		/// <summary>
		/// 温度
		/// </summary>
		public double Temperature { get; set; }
		/// <summary>
		/// 湿度
		/// </summary>
		public double Humidity { get; set; }
		/// <summary>
		/// 時間
		/// </summary>
		public string TimeStamp { get; set; }
	}
}
