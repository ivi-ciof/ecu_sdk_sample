
namespace CIOFContractSample
{
	partial class DeleteDataForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvDeleteData = new System.Windows.Forms.DataGridView();
			this.btnDelete = new System.Windows.Forms.Button();
			this.colCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.colDataId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colRecordId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colTemperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colHumidity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCO2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colTimestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvDeleteData)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvDeleteData
			// 
			this.dgvDeleteData.AllowUserToAddRows = false;
			this.dgvDeleteData.AllowUserToDeleteRows = false;
			this.dgvDeleteData.AllowUserToResizeColumns = false;
			this.dgvDeleteData.AllowUserToResizeRows = false;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvDeleteData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvDeleteData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDeleteData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCheck,
            this.colDataId,
            this.colRecordId,
            this.colTemperature,
            this.colHumidity,
            this.colCO2,
            this.colTimestamp});
			this.dgvDeleteData.Location = new System.Drawing.Point(21, 27);
			this.dgvDeleteData.Name = "dgvDeleteData";
			this.dgvDeleteData.RowHeadersVisible = false;
			this.dgvDeleteData.RowTemplate.Height = 21;
			this.dgvDeleteData.Size = new System.Drawing.Size(538, 360);
			this.dgvDeleteData.TabIndex = 0;
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(250, 425);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(88, 35);
			this.btnDelete.TabIndex = 1;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// colCheck
			// 
			this.colCheck.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colCheck.HeaderText = "Check";
			this.colCheck.Name = "colCheck";
			this.colCheck.Width = 43;
			// 
			// colDataId
			// 
			this.colDataId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colDataId.HeaderText = "DataId";
			this.colDataId.Name = "colDataId";
			this.colDataId.ReadOnly = true;
			this.colDataId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.colDataId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.colDataId.Width = 44;
			// 
			// colRecordId
			// 
			this.colRecordId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colRecordId.HeaderText = "RecordId";
			this.colRecordId.Name = "colRecordId";
			this.colRecordId.ReadOnly = true;
			this.colRecordId.Width = 75;
			// 
			// colTemperature
			// 
			this.colTemperature.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colTemperature.HeaderText = "Temperature";
			this.colTemperature.Name = "colTemperature";
			this.colTemperature.ReadOnly = true;
			this.colTemperature.Width = 94;
			// 
			// colHumidity
			// 
			this.colHumidity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colHumidity.HeaderText = "Humidity";
			this.colHumidity.Name = "colHumidity";
			this.colHumidity.ReadOnly = true;
			this.colHumidity.Width = 75;
			// 
			// colCO2
			// 
			this.colCO2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colCO2.HeaderText = "CO2";
			this.colCO2.Name = "colCO2";
			this.colCO2.ReadOnly = true;
			this.colCO2.Width = 52;
			// 
			// colTimestamp
			// 
			this.colTimestamp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colTimestamp.HeaderText = "Timestamp";
			this.colTimestamp.Name = "colTimestamp";
			this.colTimestamp.ReadOnly = true;
			this.colTimestamp.Width = 86;
			// 
			// DeleteDataForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(588, 493);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.dgvDeleteData);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DeleteDataForm";
			this.ShowIcon = false;
			this.Text = "DeleteDataForm";
			((System.ComponentModel.ISupportInitialize)(this.dgvDeleteData)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvDeleteData;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.DataGridViewCheckBoxColumn colCheck;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDataId;
		private System.Windows.Forms.DataGridViewTextBoxColumn colRecordId;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTemperature;
		private System.Windows.Forms.DataGridViewTextBoxColumn colHumidity;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCO2;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTimestamp;
	}
}