using System.ComponentModel.DataAnnotations.Schema;

namespace CIOFContractSample.Models
{
	[Table("TradeDataRecord")]
	public class TradeDataRecord : BaseColumn
	{
		public int Id { get; set; }
		public string TradeContractId { get; set; }

		public string DataId { get; set; }
	}
}
