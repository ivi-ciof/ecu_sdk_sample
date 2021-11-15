using CIOF_SDK;
using System;
using System.Windows.Forms;

namespace CIOFContractSample
{
	/// <summary>
	/// リクエスト送信用フォーム
	/// </summary>
	public partial class RequestForm : Form
	{
		ControllerModel controllerModel;

		string localId = string.Empty;
		
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public RequestForm()
		{
			InitializeComponent();

			this.cbxType.Items.Add("create");
			this.cbxType.Items.Add("delete");
			this.cbxType.SelectedIndex = 0;
		}

		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="ecuModel">コントローラのオブジェクト</param>
		public RequestForm(string localId, ControllerModel ecuModel)
		{
			InitializeComponent();
			this.controllerModel = ecuModel;
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
