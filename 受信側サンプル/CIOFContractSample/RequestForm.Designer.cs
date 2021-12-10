
namespace CIOFContractSample
{
	partial class RequestForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.cbxType = new System.Windows.Forms.ComboBox();
			this.lblType = new System.Windows.Forms.Label();
			this.lblCondition = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.btnSendRequest = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cbxType
			// 
			this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxType.FormattingEnabled = true;
			this.cbxType.Location = new System.Drawing.Point(114, 42);
			this.cbxType.Name = "cbxType";
			this.cbxType.Size = new System.Drawing.Size(230, 20);
			this.cbxType.TabIndex = 0;
			// 
			// lblType
			// 
			this.lblType.AutoSize = true;
			this.lblType.Font = new System.Drawing.Font("MS UI Gothic", 9F);
			this.lblType.Location = new System.Drawing.Point(44, 45);
			this.lblType.Name = "lblType";
			this.lblType.Size = new System.Drawing.Size(27, 12);
			this.lblType.TabIndex = 2;
			this.lblType.Text = "type";
			// 
			// lblCondition
			// 
			this.lblCondition.AutoSize = true;
			this.lblCondition.Location = new System.Drawing.Point(44, 96);
			this.lblCondition.Name = "lblCondition";
			this.lblCondition.Size = new System.Drawing.Size(51, 12);
			this.lblCondition.TabIndex = 3;
			this.lblCondition.Text = "condition";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(114, 93);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(230, 19);
			this.textBox1.TabIndex = 4;
			this.textBox1.Text = "Count=3,From = 2021/1/1,To=2021/12/31";
			// 
			// btnSendRequest
			// 
			this.btnSendRequest.Location = new System.Drawing.Point(114, 165);
			this.btnSendRequest.Name = "btnSendRequest";
			this.btnSendRequest.Size = new System.Drawing.Size(145, 51);
			this.btnSendRequest.TabIndex = 5;
			this.btnSendRequest.Text = "Send Request";
			this.btnSendRequest.UseVisualStyleBackColor = true;
			this.btnSendRequest.Click += new System.EventHandler(this.btnSendRequest_Click);
			// 
			// RequestForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(366, 270);
			this.Controls.Add(this.btnSendRequest);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.lblCondition);
			this.Controls.Add(this.lblType);
			this.Controls.Add(this.cbxType);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "RequestForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RequestForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbxType;
		private System.Windows.Forms.Label lblType;
		private System.Windows.Forms.Label lblCondition;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button btnSendRequest;
	}
}