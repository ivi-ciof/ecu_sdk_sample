
namespace CIOFContractSample_Factory
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
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
			this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnRefresh = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvContract)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvContract
			// 
			this.dgvContract.AllowUserToAddRows = false;
			this.dgvContract.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvContract.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.StartTime,
            this.EndTime});
			dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle15.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvContract.DefaultCellStyle = dataGridViewCellStyle15;
			this.dgvContract.Location = new System.Drawing.Point(24, 73);
			this.dgvContract.Margin = new System.Windows.Forms.Padding(2);
			this.dgvContract.Name = "dgvContract";
			dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle16.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvContract.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
			this.dgvContract.RowHeadersVisible = false;
			this.dgvContract.RowTemplate.Height = 27;
			this.dgvContract.Size = new System.Drawing.Size(1238, 272);
			this.dgvContract.TabIndex = 0;
			// 
			// colId
			// 
			this.colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
			this.colId.DefaultCellStyle = dataGridViewCellStyle2;
			this.colId.HeaderText = "Id";
			this.colId.Name = "colId";
			this.colId.ReadOnly = true;
			this.colId.Width = 39;
			// 
			// colContractType
			// 
			this.colContractType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
			this.colContractType.DefaultCellStyle = dataGridViewCellStyle3;
			this.colContractType.HeaderText = "ContractType";
			this.colContractType.Name = "colContractType";
			this.colContractType.ReadOnly = true;
			this.colContractType.Width = 99;
			// 
			// colSendType
			// 
			this.colSendType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
			this.colSendType.DefaultCellStyle = dataGridViewCellStyle4;
			this.colSendType.HeaderText = "SendType";
			this.colSendType.Name = "colSendType";
			this.colSendType.ReadOnly = true;
			this.colSendType.Width = 80;
			// 
			// colServiceId
			// 
			this.colServiceId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
			this.colServiceId.DefaultCellStyle = dataGridViewCellStyle5;
			this.colServiceId.HeaderText = "ServiceId";
			this.colServiceId.Name = "colServiceId";
			this.colServiceId.ReadOnly = true;
			this.colServiceId.Width = 77;
			// 
			// colServiceLocalId
			// 
			this.colServiceLocalId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.Silver;
			this.colServiceLocalId.DefaultCellStyle = dataGridViewCellStyle6;
			this.colServiceLocalId.HeaderText = "ServiceLocalId";
			this.colServiceLocalId.Name = "colServiceLocalId";
			this.colServiceLocalId.ReadOnly = true;
			this.colServiceLocalId.Width = 104;
			// 
			// colProcessId
			// 
			this.colProcessId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.Silver;
			this.colProcessId.DefaultCellStyle = dataGridViewCellStyle7;
			this.colProcessId.HeaderText = "ProcessId";
			this.colProcessId.Name = "colProcessId";
			this.colProcessId.ReadOnly = true;
			this.colProcessId.Width = 80;
			// 
			// colProcessLocalId
			// 
			this.colProcessLocalId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.Silver;
			this.colProcessLocalId.DefaultCellStyle = dataGridViewCellStyle8;
			this.colProcessLocalId.HeaderText = "ProcessLocalId";
			this.colProcessLocalId.Name = "colProcessLocalId";
			this.colProcessLocalId.ReadOnly = true;
			this.colProcessLocalId.Width = 107;
			// 
			// colEventId
			// 
			this.colEventId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.Silver;
			this.colEventId.DefaultCellStyle = dataGridViewCellStyle9;
			this.colEventId.HeaderText = "EventId";
			this.colEventId.Name = "colEventId";
			this.colEventId.ReadOnly = true;
			this.colEventId.Width = 68;
			// 
			// colEventLocalId
			// 
			this.colEventLocalId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle10.BackColor = System.Drawing.Color.Silver;
			this.colEventLocalId.DefaultCellStyle = dataGridViewCellStyle10;
			this.colEventLocalId.HeaderText = "EventLocalId";
			this.colEventLocalId.Name = "colEventLocalId";
			this.colEventLocalId.ReadOnly = true;
			this.colEventLocalId.Width = 95;
			// 
			// colDataId
			// 
			this.colDataId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle11.BackColor = System.Drawing.Color.Silver;
			this.colDataId.DefaultCellStyle = dataGridViewCellStyle11;
			this.colDataId.HeaderText = "DataId";
			this.colDataId.Name = "colDataId";
			this.colDataId.ReadOnly = true;
			this.colDataId.Width = 63;
			// 
			// colDataLocalId
			// 
			this.colDataLocalId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle12.BackColor = System.Drawing.Color.Silver;
			this.colDataLocalId.DefaultCellStyle = dataGridViewCellStyle12;
			this.colDataLocalId.HeaderText = "DataLocalId";
			this.colDataLocalId.Name = "colDataLocalId";
			this.colDataLocalId.ReadOnly = true;
			this.colDataLocalId.Width = 90;
			// 
			// StartTime
			// 
			this.StartTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle13.BackColor = System.Drawing.Color.Silver;
			this.StartTime.DefaultCellStyle = dataGridViewCellStyle13;
			this.StartTime.HeaderText = "StartTime";
			this.StartTime.Name = "StartTime";
			this.StartTime.ReadOnly = true;
			this.StartTime.Width = 80;
			// 
			// EndTime
			// 
			this.EndTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle14.BackColor = System.Drawing.Color.Silver;
			this.EndTime.DefaultCellStyle = dataGridViewCellStyle14;
			this.EndTime.HeaderText = "EndTime";
			this.EndTime.Name = "EndTime";
			this.EndTime.ReadOnly = true;
			this.EndTime.Width = 74;
			// 
			// btnRefresh
			// 
			this.btnRefresh.Location = new System.Drawing.Point(24, 12);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(116, 45);
			this.btnRefresh.TabIndex = 1;
			this.btnRefresh.Text = "refresh";
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// ContractForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1286, 367);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.dgvContract);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ContractForm";
			this.ShowIcon = false;
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
		private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn EndTime;
		private System.Windows.Forms.Button btnRefresh;
	}
}