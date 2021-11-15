using CIOF_SDK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIOFContractSample_Factory
{
	public partial class RequestForm : Form
	{
		ControllerModel controllerModel;

		string localId = string.Empty;

		public RequestForm()
		{
			InitializeComponent();
		}


		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="controller">コントローラのオブジェクト</param>
		public RequestForm(string localId, ControllerModel controller)
		{
			InitializeComponent();
			this.controllerModel = controller;
			this.localId = localId;
			SetComboBox();
		}

		/// <summary>
		/// コンボボックス設定
		/// </summary>
		private void SetComboBox()
		{
			this.cbxType.Items.Add("create");
			this.cbxType.Items.Add("delete");
			this.cbxType.SelectedIndex = 0;
		}

		private void btnSendRequest_Click(object sender, EventArgs e)
		{
			if (!controllerModel.IsControllerStart())
			{
				MessageBox.Show("コントローラが起動していません。");
				return;
			}
			controllerModel.PostRequestParameterByServiceId(this.localId, this.cbxType.Text, this.textBox1.Text);

			MessageBox.Show("リクエストを送信しました。");
		}
	}
}
