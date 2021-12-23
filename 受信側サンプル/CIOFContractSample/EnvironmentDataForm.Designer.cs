
namespace CIOFContractSample
{
	partial class EnvironmentDataForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvEnvironmentData = new System.Windows.Forms.DataGridView();
			this.dataId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RecordId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Temperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Humidity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TimeStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvEnvironmentData)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvEnvironmentData
			// 
			this.dgvEnvironmentData.AllowUserToAddRows = false;
			this.dgvEnvironmentData.AllowUserToDeleteRows = false;
			this.dgvEnvironmentData.AllowUserToResizeColumns = false;
			this.dgvEnvironmentData.AllowUserToResizeRows = false;
			this.dgvEnvironmentData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvEnvironmentData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataId,
            this.RecordId,
            this.Temperature,
            this.Humidity,
            this.TimeStamp});
			this.dgvEnvironmentData.Location = new System.Drawing.Point(29, 74);
			this.dgvEnvironmentData.Name = "dgvEnvironmentData";
			this.dgvEnvironmentData.RowHeadersVisible = false;
			this.dgvEnvironmentData.RowTemplate.Height = 21;
			this.dgvEnvironmentData.Size = new System.Drawing.Size(786, 401);
			this.dgvEnvironmentData.TabIndex = 0;
			// 
			// dataId
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
			this.dataId.DefaultCellStyle = dataGridViewCellStyle1;
			this.dataId.HeaderText = "DataId";
			this.dataId.Name = "dataId";
			this.dataId.ReadOnly = true;
			this.dataId.Width = 240;
			// 
			// RecordId
			// 
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
			this.RecordId.DefaultCellStyle = dataGridViewCellStyle2;
			this.RecordId.HeaderText = "RecordId";
			this.RecordId.Name = "RecordId";
			this.RecordId.ReadOnly = true;
			// 
			// Temperature
			// 
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
			this.Temperature.DefaultCellStyle = dataGridViewCellStyle3;
			this.Temperature.HeaderText = "Temperature";
			this.Temperature.Name = "Temperature";
			this.Temperature.ReadOnly = true;
			// 
			// Humidity
			// 
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
			this.Humidity.DefaultCellStyle = dataGridViewCellStyle4;
			this.Humidity.HeaderText = "Humidity";
			this.Humidity.Name = "Humidity";
			this.Humidity.ReadOnly = true;
			// 
			// TimeStamp
			// 
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
			this.TimeStamp.DefaultCellStyle = dataGridViewCellStyle5;
			this.TimeStamp.HeaderText = "TimeStamp";
			this.TimeStamp.Name = "TimeStamp";
			this.TimeStamp.ReadOnly = true;
			this.TimeStamp.Width = 150;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(112, 36);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(95, 19);
			this.textBox1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(36, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 12);
			this.label1.TabIndex = 2;
			this.label1.Text = "lcontractId";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(248, 39);
			this.label2.Name = "label2";
			this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label2.Size = new System.Drawing.Size(36, 12);
			this.label2.TabIndex = 3;
			this.label2.Text = "dataId";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(290, 33);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(129, 20);
			this.comboBox1.TabIndex = 4;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(722, 22);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(93, 35);
			this.button1.TabIndex = 5;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// EnvironmentDataForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(839, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.dgvEnvironmentData);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "EnvironmentDataForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "EnvironmentDataForm";
			((System.ComponentModel.ISupportInitialize)(this.dgvEnvironmentData)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvEnvironmentData;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataId;
		private System.Windows.Forms.DataGridViewTextBoxColumn RecordId;
		private System.Windows.Forms.DataGridViewTextBoxColumn Temperature;
		private System.Windows.Forms.DataGridViewTextBoxColumn Humidity;
		private System.Windows.Forms.DataGridViewTextBoxColumn TimeStamp;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button button1;
	}
}