
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
			this.dgvEnvironmentData = new System.Windows.Forms.DataGridView();
			this.tbxContractId = new System.Windows.Forms.TextBox();
			this.lblContractId = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cbxDataId = new System.Windows.Forms.ComboBox();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.Temperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Humidity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCO2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TimeStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvEnvironmentData)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvEnvironmentData
			// 
			this.dgvEnvironmentData.AllowUserToAddRows = false;
			this.dgvEnvironmentData.AllowUserToDeleteRows = false;
			this.dgvEnvironmentData.AllowUserToResizeColumns = false;
			this.dgvEnvironmentData.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvEnvironmentData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvEnvironmentData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvEnvironmentData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Temperature,
            this.Humidity,
            this.colCO2,
            this.TimeStamp});
			this.dgvEnvironmentData.Location = new System.Drawing.Point(29, 74);
			this.dgvEnvironmentData.Name = "dgvEnvironmentData";
			this.dgvEnvironmentData.RowHeadersVisible = false;
			this.dgvEnvironmentData.RowTemplate.Height = 21;
			this.dgvEnvironmentData.Size = new System.Drawing.Size(857, 348);
			this.dgvEnvironmentData.TabIndex = 0;
			// 
			// tbxContractId
			// 
			this.tbxContractId.Location = new System.Drawing.Point(112, 36);
			this.tbxContractId.Name = "tbxContractId";
			this.tbxContractId.ReadOnly = true;
			this.tbxContractId.Size = new System.Drawing.Size(95, 19);
			this.tbxContractId.TabIndex = 1;
			// 
			// lblContractId
			// 
			this.lblContractId.AutoSize = true;
			this.lblContractId.Location = new System.Drawing.Point(36, 39);
			this.lblContractId.Name = "lblContractId";
			this.lblContractId.Size = new System.Drawing.Size(56, 12);
			this.lblContractId.TabIndex = 2;
			this.lblContractId.Text = "contractId";
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
			// cbxDataId
			// 
			this.cbxDataId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxDataId.FormattingEnabled = true;
			this.cbxDataId.Location = new System.Drawing.Point(290, 33);
			this.cbxDataId.Name = "cbxDataId";
			this.cbxDataId.Size = new System.Drawing.Size(377, 20);
			this.cbxDataId.TabIndex = 4;
			this.cbxDataId.SelectedIndexChanged += new System.EventHandler(this.cbxDataId_SelectedIndexChanged);
			// 
			// btnRefresh
			// 
			this.btnRefresh.Location = new System.Drawing.Point(793, 28);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(93, 35);
			this.btnRefresh.TabIndex = 5;
			this.btnRefresh.Text = "refresh";
			this.btnRefresh.UseVisualStyleBackColor = true;
			// 
			// Temperature
			// 
			this.Temperature.HeaderText = "Temperature";
			this.Temperature.Name = "Temperature";
			this.Temperature.ReadOnly = true;
			// 
			// Humidity
			// 
			this.Humidity.HeaderText = "Humidity";
			this.Humidity.Name = "Humidity";
			this.Humidity.ReadOnly = true;
			// 
			// colCO2
			// 
			this.colCO2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colCO2.HeaderText = "CO2";
			this.colCO2.Name = "colCO2";
			this.colCO2.ReadOnly = true;
			this.colCO2.Width = 52;
			// 
			// TimeStamp
			// 
			this.TimeStamp.HeaderText = "TimeStamp";
			this.TimeStamp.Name = "TimeStamp";
			this.TimeStamp.ReadOnly = true;
			this.TimeStamp.Width = 150;
			// 
			// EnvironmentDataForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(913, 450);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.cbxDataId);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblContractId);
			this.Controls.Add(this.tbxContractId);
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
		private System.Windows.Forms.TextBox tbxContractId;
		private System.Windows.Forms.Label lblContractId;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbxDataId;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.DataGridViewTextBoxColumn Temperature;
		private System.Windows.Forms.DataGridViewTextBoxColumn Humidity;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCO2;
		private System.Windows.Forms.DataGridViewTextBoxColumn TimeStamp;
	}
}