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
		/// <summary>
		/// コントローラモデル
		/// </summary>
		ControllerModel controllerModel;
		/// <summary>
		/// サービス実装ローカルID
		/// </summary>
		string localServiceId = string.Empty;

		public RequestForm()
		{
			InitializeComponent();
		}


		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="controller">コントローラのオブジェクト</param>
		public RequestForm(string localServiceId, ControllerModel controller)
		{
			InitializeComponent();
			this.controllerModel = controller;
			this.localServiceId = localServiceId;
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
		/// <summary>
		/// Send Requestボタンクリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnSendRequest_Click(object sender, EventArgs e)
		{
			if (!controllerModel.IsControllerStart())
			{
				MessageBox.Show("コントローラが起動していません。");
				return;
			}
			controllerModel.PostRequestParameterByServiceId(this.localServiceId, this.cbxType.Text, this.textBox1.Text);

			MessageBox.Show("リクエストを送信しました。");
		}
	}
}
