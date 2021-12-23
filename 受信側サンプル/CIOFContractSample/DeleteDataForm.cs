using CIOFContractSample.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIOFContractSample
{
	public partial class DeleteDataForm : Form
	{

		/// <summary>
		/// コンストラクタ
		/// </summary>
		public DeleteDataForm()
		{
			InitializeComponent();
		}

		public DeleteDataForm(List<DataRecord> deleteRecordList)
		{
			InitializeComponent();

			foreach (var deleteRecord in deleteRecordList)
			{
				this.dgvDeleteData.Rows.Add(true, deleteRecord.DataId, deleteRecord.Id, deleteRecord.Temperature, deleteRecord.Humidity, deleteRecord.TimeStamp);
			}
		}


	}
}
