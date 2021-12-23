
namespace CIOFContractSample
{
	partial class HistoryListForm
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
			this.lblContractMap = new System.Windows.Forms.Label();
			this.dgvContractMap = new System.Windows.Forms.DataGridView();
			this.colContractId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colContractDataID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCreateRecordTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblContractDataDetail = new System.Windows.Forms.Label();
			this.dgvContractDataSensorDataMap = new System.Windows.Forms.DataGridView();
			this.lblSensorData = new System.Windows.Forms.Label();
			this.colContractDataID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSensorDataID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCreateRecordTime2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvSensorData = new System.Windows.Forms.DataGridView();
			this.colSensorDataId3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colTemperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colHumidity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colMeasureDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvContractMap)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvContractDataSensorDataMap)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvSensorData)).BeginInit();
			this.SuspendLayout();
			// 
			// lblContractMap
			// 
			this.lblContractMap.AutoSize = true;
			this.lblContractMap.Location = new System.Drawing.Point(22, 17);
			this.lblContractMap.Name = "lblContractMap";
			this.lblContractMap.Size = new System.Drawing.Size(153, 12);
			this.lblContractMap.TabIndex = 0;
			this.lblContractMap.Text = "ContractID - ContractDataID";
			// 
			// dgvContractMap
			// 
			this.dgvContractMap.AllowUserToAddRows = false;
			this.dgvContractMap.AllowUserToDeleteRows = false;
			this.dgvContractMap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvContractMap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colContractId,
            this.colContractDataID,
            this.colCreateRecordTime});
			this.dgvContractMap.Location = new System.Drawing.Point(22, 40);
			this.dgvContractMap.Name = "dgvContractMap";
			this.dgvContractMap.RowHeadersVisible = false;
			this.dgvContractMap.RowTemplate.Height = 21;
			this.dgvContractMap.Size = new System.Drawing.Size(548, 188);
			this.dgvContractMap.TabIndex = 1;
			// 
			// colContractId
			// 
			this.colContractId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
			this.colContractId.DefaultCellStyle = dataGridViewCellStyle1;
			this.colContractId.HeaderText = "ContactID";
			this.colContractId.Name = "colContractId";
			this.colContractId.ReadOnly = true;
			this.colContractId.Width = 81;
			// 
			// colContractDataID
			// 
			this.colContractDataID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
			this.colContractDataID.DefaultCellStyle = dataGridViewCellStyle2;
			this.colContractDataID.HeaderText = "ContractDataID";
			this.colContractDataID.Name = "colContractDataID";
			this.colContractDataID.ReadOnly = true;
			this.colContractDataID.Width = 109;
			// 
			// colCreateRecordTime
			// 
			this.colCreateRecordTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
			this.colCreateRecordTime.DefaultCellStyle = dataGridViewCellStyle3;
			this.colCreateRecordTime.HeaderText = "CreateRecordTime";
			this.colCreateRecordTime.Name = "colCreateRecordTime";
			this.colCreateRecordTime.ReadOnly = true;
			this.colCreateRecordTime.Width = 125;
			// 
			// lblContractDataDetail
			// 
			this.lblContractDataDetail.AutoSize = true;
			this.lblContractDataDetail.Location = new System.Drawing.Point(22, 242);
			this.lblContractDataDetail.Name = "lblContractDataDetail";
			this.lblContractDataDetail.Size = new System.Drawing.Size(160, 12);
			this.lblContractDataDetail.TabIndex = 2;
			this.lblContractDataDetail.Text = "ContractDataID-SensorDataID";
			// 
			// dgvContractDataSensorDataMap
			// 
			this.dgvContractDataSensorDataMap.AllowUserToAddRows = false;
			this.dgvContractDataSensorDataMap.AllowUserToDeleteRows = false;
			this.dgvContractDataSensorDataMap.AllowUserToResizeColumns = false;
			this.dgvContractDataSensorDataMap.AllowUserToResizeRows = false;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvContractDataSensorDataMap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvContractDataSensorDataMap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvContractDataSensorDataMap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colContractDataID2,
            this.colSensorDataID2,
            this.colCreateRecordTime2});
			this.dgvContractDataSensorDataMap.Location = new System.Drawing.Point(22, 265);
			this.dgvContractDataSensorDataMap.Name = "dgvContractDataSensorDataMap";
			this.dgvContractDataSensorDataMap.RowHeadersVisible = false;
			this.dgvContractDataSensorDataMap.RowTemplate.Height = 21;
			this.dgvContractDataSensorDataMap.Size = new System.Drawing.Size(548, 188);
			this.dgvContractDataSensorDataMap.TabIndex = 3;
			// 
			// lblSensorData
			// 
			this.lblSensorData.AutoSize = true;
			this.lblSensorData.Location = new System.Drawing.Point(22, 462);
			this.lblSensorData.Name = "lblSensorData";
			this.lblSensorData.Size = new System.Drawing.Size(75, 12);
			this.lblSensorData.TabIndex = 4;
			this.lblSensorData.Text = "SensorDataID";
			// 
			// colContractDataID2
			// 
			this.colContractDataID2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colContractDataID2.HeaderText = "ContractDataID";
			this.colContractDataID2.Name = "colContractDataID2";
			this.colContractDataID2.ReadOnly = true;
			this.colContractDataID2.Width = 109;
			// 
			// colSensorDataID2
			// 
			this.colSensorDataID2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colSensorDataID2.HeaderText = "SensorDataID";
			this.colSensorDataID2.Name = "colSensorDataID2";
			this.colSensorDataID2.ReadOnly = true;
			// 
			// colCreateRecordTime2
			// 
			this.colCreateRecordTime2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colCreateRecordTime2.HeaderText = "CreateRecordTime";
			this.colCreateRecordTime2.Name = "colCreateRecordTime2";
			this.colCreateRecordTime2.ReadOnly = true;
			this.colCreateRecordTime2.Width = 125;
			// 
			// dgvSensorData
			// 
			this.dgvSensorData.AllowUserToAddRows = false;
			this.dgvSensorData.AllowUserToDeleteRows = false;
			this.dgvSensorData.AllowUserToResizeColumns = false;
			this.dgvSensorData.AllowUserToResizeRows = false;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvSensorData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvSensorData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSensorData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSensorDataId3,
            this.colTemperature,
            this.colHumidity,
            this.colMeasureDate});
			this.dgvSensorData.Location = new System.Drawing.Point(22, 485);
			this.dgvSensorData.Name = "dgvSensorData";
			this.dgvSensorData.RowHeadersVisible = false;
			this.dgvSensorData.RowTemplate.Height = 21;
			this.dgvSensorData.Size = new System.Drawing.Size(548, 188);
			this.dgvSensorData.TabIndex = 5;
			// 
			// colSensorDataId3
			// 
			this.colSensorDataId3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colSensorDataId3.HeaderText = "SensorDataID";
			this.colSensorDataId3.Name = "colSensorDataId3";
			this.colSensorDataId3.ReadOnly = true;
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
			// colMeasureDate
			// 
			this.colMeasureDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colMeasureDate.HeaderText = "MeasureDate";
			this.colMeasureDate.Name = "colMeasureDate";
			this.colMeasureDate.ReadOnly = true;
			this.colMeasureDate.Width = 97;
			// 
			// HistoryListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(583, 682);
			this.Controls.Add(this.dgvSensorData);
			this.Controls.Add(this.lblSensorData);
			this.Controls.Add(this.dgvContractDataSensorDataMap);
			this.Controls.Add(this.lblContractDataDetail);
			this.Controls.Add(this.dgvContractMap);
			this.Controls.Add(this.lblContractMap);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "HistoryListForm";
			this.ShowIcon = false;
			this.Text = "History";
			((System.ComponentModel.ISupportInitialize)(this.dgvContractMap)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvContractDataSensorDataMap)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvSensorData)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblContractMap;
		private System.Windows.Forms.DataGridView dgvContractMap;
		private System.Windows.Forms.DataGridViewTextBoxColumn colContractId;
		private System.Windows.Forms.DataGridViewTextBoxColumn colContractDataID;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCreateRecordTime;
		private System.Windows.Forms.Label lblContractDataDetail;
		private System.Windows.Forms.DataGridView dgvContractDataSensorDataMap;
		private System.Windows.Forms.DataGridViewTextBoxColumn colContractDataID2;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSensorDataID2;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCreateRecordTime2;
		private System.Windows.Forms.Label lblSensorData;
		private System.Windows.Forms.DataGridView dgvSensorData;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSensorDataId3;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTemperature;
		private System.Windows.Forms.DataGridViewTextBoxColumn colHumidity;
		private System.Windows.Forms.DataGridViewTextBoxColumn colMeasureDate;
	}
}