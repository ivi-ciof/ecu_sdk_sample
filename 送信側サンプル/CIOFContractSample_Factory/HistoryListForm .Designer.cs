
namespace CIOFContractSample_Factory
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvContractMap = new System.Windows.Forms.DataGridView();
			this.ContractID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ContractDataID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CreateRecordTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvContractDataSensorDataMap = new System.Windows.Forms.DataGridView();
			this.ContractDataID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SensorDataID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CreateRecordTime2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblContractDataDetail = new System.Windows.Forms.Label();
			this.lblContractMap = new System.Windows.Forms.Label();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.dgvSensorData = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblSensorData = new System.Windows.Forms.Label();
			this.btnSendDeleteRequest = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvContractMap)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvContractDataSensorDataMap)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvSensorData)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvContractMap
			// 
			this.dgvContractMap.AllowUserToAddRows = false;
			this.dgvContractMap.AllowUserToDeleteRows = false;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvContractMap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
			this.dgvContractMap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvContractMap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvContractMap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ContractID,
            this.ContractDataID,
            this.CreateRecordTime});
			this.dgvContractMap.Location = new System.Drawing.Point(22, 40);
			this.dgvContractMap.Margin = new System.Windows.Forms.Padding(2);
			this.dgvContractMap.Name = "dgvContractMap";
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.Lime;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvContractMap.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
			this.dgvContractMap.RowHeadersVisible = false;
			this.dgvContractMap.RowTemplate.Height = 27;
			this.dgvContractMap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvContractMap.Size = new System.Drawing.Size(548, 188);
			this.dgvContractMap.TabIndex = 2;
			// 
			// ContractID
			// 
			this.ContractID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.ContractID.HeaderText = "ContractID";
			this.ContractID.Name = "ContractID";
			this.ContractID.Width = 85;
			// 
			// ContractDataID
			// 
			this.ContractDataID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.ContractDataID.HeaderText = "ContractDataID";
			this.ContractDataID.Name = "ContractDataID";
			this.ContractDataID.Width = 109;
			// 
			// CreateRecordTime
			// 
			this.CreateRecordTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.CreateRecordTime.HeaderText = "CreateRecordTime";
			this.CreateRecordTime.Name = "CreateRecordTime";
			this.CreateRecordTime.Width = 125;
			// 
			// dgvContractDataSensorDataMap
			// 
			this.dgvContractDataSensorDataMap.AllowUserToAddRows = false;
			this.dgvContractDataSensorDataMap.AllowUserToDeleteRows = false;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvContractDataSensorDataMap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
			this.dgvContractDataSensorDataMap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvContractDataSensorDataMap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvContractDataSensorDataMap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ContractDataID2,
            this.SensorDataID,
            this.CreateRecordTime2});
			this.dgvContractDataSensorDataMap.Location = new System.Drawing.Point(22, 265);
			this.dgvContractDataSensorDataMap.Margin = new System.Windows.Forms.Padding(2);
			this.dgvContractDataSensorDataMap.Name = "dgvContractDataSensorDataMap";
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle10.BackColor = System.Drawing.Color.Lime;
			dataGridViewCellStyle10.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvContractDataSensorDataMap.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
			this.dgvContractDataSensorDataMap.RowHeadersVisible = false;
			this.dgvContractDataSensorDataMap.RowTemplate.Height = 27;
			this.dgvContractDataSensorDataMap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvContractDataSensorDataMap.Size = new System.Drawing.Size(548, 188);
			this.dgvContractDataSensorDataMap.TabIndex = 4;
			// 
			// ContractDataID2
			// 
			this.ContractDataID2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.ContractDataID2.HeaderText = "ContractDataID";
			this.ContractDataID2.Name = "ContractDataID2";
			this.ContractDataID2.Width = 109;
			// 
			// SensorDataID
			// 
			this.SensorDataID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.SensorDataID.HeaderText = "SensorDataID";
			this.SensorDataID.Name = "SensorDataID";
			// 
			// CreateRecordTime2
			// 
			this.CreateRecordTime2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.CreateRecordTime2.HeaderText = "CreateRecordTime";
			this.CreateRecordTime2.Name = "CreateRecordTime2";
			this.CreateRecordTime2.Width = 125;
			// 
			// lblContractDataDetail
			// 
			this.lblContractDataDetail.AutoSize = true;
			this.lblContractDataDetail.Location = new System.Drawing.Point(22, 242);
			this.lblContractDataDetail.Name = "lblContractDataDetail";
			this.lblContractDataDetail.Size = new System.Drawing.Size(160, 12);
			this.lblContractDataDetail.TabIndex = 3;
			this.lblContractDataDetail.Text = "ContractDataID-SensorDataID";
			// 
			// lblContractMap
			// 
			this.lblContractMap.AutoSize = true;
			this.lblContractMap.Location = new System.Drawing.Point(22, 17);
			this.lblContractMap.Name = "lblContractMap";
			this.lblContractMap.Size = new System.Drawing.Size(153, 12);
			this.lblContractMap.TabIndex = 1;
			this.lblContractMap.Text = "ContractID - ContractDataID";
			// 
			// btnUpdate
			// 
			this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnUpdate.Location = new System.Drawing.Point(495, 12);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 23);
			this.btnUpdate.TabIndex = 0;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// dgvSensorData
			// 
			this.dgvSensorData.AllowUserToAddRows = false;
			this.dgvSensorData.AllowUserToDeleteRows = false;
			dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvSensorData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
			this.dgvSensorData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvSensorData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSensorData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
			this.dgvSensorData.Location = new System.Drawing.Point(22, 485);
			this.dgvSensorData.Margin = new System.Windows.Forms.Padding(2);
			this.dgvSensorData.Name = "dgvSensorData";
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle12.BackColor = System.Drawing.Color.Lime;
			dataGridViewCellStyle12.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSensorData.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
			this.dgvSensorData.RowHeadersVisible = false;
			this.dgvSensorData.RowTemplate.Height = 27;
			this.dgvSensorData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvSensorData.Size = new System.Drawing.Size(548, 188);
			this.dgvSensorData.TabIndex = 5;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn1.HeaderText = "SensorDataID";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn2.HeaderText = "Temparature";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.Width = 94;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn3.HeaderText = "Humidity";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.Width = 75;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn4.HeaderText = "MeasureDate";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.Width = 97;
			// 
			// lblSensorData
			// 
			this.lblSensorData.AutoSize = true;
			this.lblSensorData.Location = new System.Drawing.Point(22, 462);
			this.lblSensorData.Name = "lblSensorData";
			this.lblSensorData.Size = new System.Drawing.Size(75, 12);
			this.lblSensorData.TabIndex = 6;
			this.lblSensorData.Text = "SensorDataID";
			// 
			// btnSendDeleteRequest
			// 
			this.btnSendDeleteRequest.Location = new System.Drawing.Point(362, 12);
			this.btnSendDeleteRequest.Name = "btnSendDeleteRequest";
			this.btnSendDeleteRequest.Size = new System.Drawing.Size(127, 23);
			this.btnSendDeleteRequest.TabIndex = 7;
			this.btnSendDeleteRequest.Text = "Send Delete Request";
			this.btnSendDeleteRequest.UseVisualStyleBackColor = true;
			this.btnSendDeleteRequest.Click += new System.EventHandler(this.btnSendDeleteRequest_Click);
			// 
			// HistoryListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(583, 682);
			this.Controls.Add(this.btnSendDeleteRequest);
			this.Controls.Add(this.lblSensorData);
			this.Controls.Add(this.dgvSensorData);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.lblContractMap);
			this.Controls.Add(this.lblContractDataDetail);
			this.Controls.Add(this.dgvContractDataSensorDataMap);
			this.Controls.Add(this.dgvContractMap);
			this.Margin = new System.Windows.Forms.Padding(2);
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

		private System.Windows.Forms.DataGridView dgvContractMap;
        private System.Windows.Forms.DataGridView dgvContractDataSensorDataMap;
        private System.Windows.Forms.Label lblContractDataDetail;
        private System.Windows.Forms.Label lblContractMap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContractID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContractDataID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateRecordTime;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvSensorData;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label lblSensorData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContractDataID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SensorDataID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateRecordTime2;
		private System.Windows.Forms.Button btnSendDeleteRequest;
	}
}