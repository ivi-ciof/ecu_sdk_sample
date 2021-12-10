
namespace CIOFContractSample
{
	partial class ContractForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvContract = new System.Windows.Forms.DataGridView();
			this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colContractType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSendType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colServiceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colServiceLocalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colProcessId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colProcessLocalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colEventId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colEventLocalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDataId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDataLocalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvContract)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvContract
			// 
			this.dgvContract.AllowUserToAddRows = false;
			this.dgvContract.AllowUserToDeleteRows = false;
			this.dgvContract.AllowUserToResizeColumns = false;
			this.dgvContract.AllowUserToResizeRows = false;
			this.dgvContract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvContract.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colContractType,
            this.colSendType,
            this.colServiceId,
            this.colServiceLocalId,
            this.colProcessId,
            this.colProcessLocalId,
            this.colEventId,
            this.colEventLocalId,
            this.colDataId,
            this.colDataLocalId,
            this.colStartDate,
            this.colEndDate});
			this.dgvContract.Location = new System.Drawing.Point(24, 21);
			this.dgvContract.Margin = new System.Windows.Forms.Padding(2);
			this.dgvContract.MultiSelect = false;
			this.dgvContract.Name = "dgvContract";
			this.dgvContract.RowHeadersVisible = false;
			this.dgvContract.RowTemplate.Height = 27;
			this.dgvContract.Size = new System.Drawing.Size(1238, 272);
			this.dgvContract.TabIndex = 0;
			// 
			// colId
			// 
			this.colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
			this.colId.DefaultCellStyle = dataGridViewCellStyle1;
			this.colId.HeaderText = "Id";
			this.colId.Name = "colId";
			this.colId.ReadOnly = true;
			this.colId.Width = 39;
			// 
			// colContractType
			// 
			this.colContractType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
			this.colContractType.DefaultCellStyle = dataGridViewCellStyle2;
			this.colContractType.HeaderText = "ContractType";
			this.colContractType.Name = "colContractType";
			this.colContractType.ReadOnly = true;
			this.colContractType.Width = 99;
			// 
			// colSendType
			// 
			this.colSendType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
			this.colSendType.DefaultCellStyle = dataGridViewCellStyle3;
			this.colSendType.HeaderText = "SendType";
			this.colSendType.Name = "colSendType";
			this.colSendType.ReadOnly = true;
			this.colSendType.Width = 80;
			// 
			// colServiceId
			// 
			this.colServiceId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
			this.colServiceId.DefaultCellStyle = dataGridViewCellStyle4;
			this.colServiceId.HeaderText = "ServiceId";
			this.colServiceId.Name = "colServiceId";
			this.colServiceId.ReadOnly = true;
			this.colServiceId.Width = 77;
			// 
			// colServiceLocalId
			// 
			this.colServiceLocalId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
			this.colServiceLocalId.DefaultCellStyle = dataGridViewCellStyle5;
			this.colServiceLocalId.HeaderText = "ServiceLocalId";
			this.colServiceLocalId.Name = "colServiceLocalId";
			this.colServiceLocalId.ReadOnly = true;
			this.colServiceLocalId.Width = 104;
			// 
			// colProcessId
			// 
			this.colProcessId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.Silver;
			this.colProcessId.DefaultCellStyle = dataGridViewCellStyle6;
			this.colProcessId.HeaderText = "ProcessId";
			this.colProcessId.Name = "colProcessId";
			this.colProcessId.ReadOnly = true;
			this.colProcessId.Width = 80;
			// 
			// colProcessLocalId
			// 
			this.colProcessLocalId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.Silver;
			this.colProcessLocalId.DefaultCellStyle = dataGridViewCellStyle7;
			this.colProcessLocalId.HeaderText = "ProcessLocalId";
			this.colProcessLocalId.Name = "colProcessLocalId";
			this.colProcessLocalId.ReadOnly = true;
			this.colProcessLocalId.Width = 107;
			// 
			// colEventId
			// 
			this.colEventId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.Silver;
			this.colEventId.DefaultCellStyle = dataGridViewCellStyle8;
			this.colEventId.HeaderText = "EventId";
			this.colEventId.Name = "colEventId";
			this.colEventId.ReadOnly = true;
			this.colEventId.Width = 68;
			// 
			// colEventLocalId
			// 
			this.colEventLocalId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.Silver;
			this.colEventLocalId.DefaultCellStyle = dataGridViewCellStyle9;
			this.colEventLocalId.HeaderText = "EventLocalId";
			this.colEventLocalId.Name = "colEventLocalId";
			this.colEventLocalId.ReadOnly = true;
			this.colEventLocalId.Width = 95;
			// 
			// colDataId
			// 
			this.colDataId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle10.BackColor = System.Drawing.Color.Silver;
			this.colDataId.DefaultCellStyle = dataGridViewCellStyle10;
			this.colDataId.HeaderText = "DataId";
			this.colDataId.Name = "colDataId";
			this.colDataId.ReadOnly = true;
			this.colDataId.Width = 63;
			// 
			// colDataLocalId
			// 
			this.colDataLocalId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle11.BackColor = System.Drawing.Color.Silver;
			this.colDataLocalId.DefaultCellStyle = dataGridViewCellStyle11;
			this.colDataLocalId.HeaderText = "DataLocalId";
			this.colDataLocalId.Name = "colDataLocalId";
			this.colDataLocalId.ReadOnly = true;
			this.colDataLocalId.Width = 90;
			// 
			// colStartDate
			// 
			this.colStartDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle12.BackColor = System.Drawing.Color.Silver;
			this.colStartDate.DefaultCellStyle = dataGridViewCellStyle12;
			this.colStartDate.HeaderText = "StartDate";
			this.colStartDate.Name = "colStartDate";
			this.colStartDate.ReadOnly = true;
			this.colStartDate.Width = 79;
			// 
			// colEndDate
			// 
			this.colEndDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle13.BackColor = System.Drawing.Color.Silver;
			this.colEndDate.DefaultCellStyle = dataGridViewCellStyle13;
			this.colEndDate.HeaderText = "EndDate";
			this.colEndDate.Name = "colEndDate";
			this.colEndDate.ReadOnly = true;
			this.colEndDate.Width = 73;
			// 
			// ContractForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1286, 304);
			this.Controls.Add(this.dgvContract);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ContractForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ContractForm";
			((System.ComponentModel.ISupportInitialize)(this.dgvContract)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvContract;
		private System.Windows.Forms.DataGridViewTextBoxColumn colId;
		private System.Windows.Forms.DataGridViewTextBoxColumn colContractType;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSendType;
		private System.Windows.Forms.DataGridViewTextBoxColumn colServiceId;
		private System.Windows.Forms.DataGridViewTextBoxColumn colServiceLocalId;
		private System.Windows.Forms.DataGridViewTextBoxColumn colProcessId;
		private System.Windows.Forms.DataGridViewTextBoxColumn colProcessLocalId;
		private System.Windows.Forms.DataGridViewTextBoxColumn colEventId;
		private System.Windows.Forms.DataGridViewTextBoxColumn colEventLocalId;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDataId;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDataLocalId;
		private System.Windows.Forms.DataGridViewTextBoxColumn colStartDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn colEndDate;
	}
}