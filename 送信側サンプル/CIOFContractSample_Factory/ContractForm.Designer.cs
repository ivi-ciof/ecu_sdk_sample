
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
			this.dgvContract = new System.Windows.Forms.DataGridView();
			this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colContractType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.data_implementation_local_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.service_implementation_local_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.process_implementation_local_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colEventId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.event_implementation_local_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvContract)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvContract
			// 
			this.dgvContract.AllowUserToAddRows = false;
			this.dgvContract.AllowUserToDeleteRows = false;
			this.dgvContract.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvContract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvContract.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colContractType,
            this.data_implementation_local_id,
            this.service_implementation_local_id,
            this.process_implementation_local_id,
            this.colEventId,
            this.event_implementation_local_id,
            this.StartTime,
            this.EndTime});
			this.dgvContract.Location = new System.Drawing.Point(11, 11);
			this.dgvContract.Margin = new System.Windows.Forms.Padding(2);
			this.dgvContract.Name = "dgvContract";
			this.dgvContract.RowHeadersVisible = false;
			this.dgvContract.RowTemplate.Height = 27;
			this.dgvContract.Size = new System.Drawing.Size(1238, 272);
			this.dgvContract.TabIndex = 0;
			// 
			// colId
			// 
			this.colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colId.HeaderText = "Id";
			this.colId.Name = "colId";
			this.colId.Width = 39;
			// 
			// colContractType
			// 
			this.colContractType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colContractType.HeaderText = "ContractType";
			this.colContractType.Name = "colContractType";
			this.colContractType.Width = 99;
			// 
			// data_implementation_local_id
			// 
			this.data_implementation_local_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.data_implementation_local_id.HeaderText = "data_implementation_local_id";
			this.data_implementation_local_id.Name = "data_implementation_local_id";
			this.data_implementation_local_id.Width = 174;
			// 
			// service_implementation_local_id
			// 
			this.service_implementation_local_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.service_implementation_local_id.HeaderText = "service_implementation_local_id";
			this.service_implementation_local_id.Name = "service_implementation_local_id";
			this.service_implementation_local_id.Width = 189;
			// 
			// process_implementation_local_id
			// 
			this.process_implementation_local_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.process_implementation_local_id.HeaderText = "process_implementation_local_id";
			this.process_implementation_local_id.Name = "process_implementation_local_id";
			this.process_implementation_local_id.Width = 192;
			// 
			// colEventId
			// 
			this.colEventId.HeaderText = "EventId";
			this.colEventId.Name = "colEventId";
			this.colEventId.ReadOnly = true;
			// 
			// event_implementation_local_id
			// 
			this.event_implementation_local_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.event_implementation_local_id.HeaderText = "event_implementation_local_id";
			this.event_implementation_local_id.Name = "event_implementation_local_id";
			this.event_implementation_local_id.ReadOnly = true;
			this.event_implementation_local_id.Width = 180;
			// 
			// StartTime
			// 
			this.StartTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.StartTime.HeaderText = "StartTime";
			this.StartTime.Name = "StartTime";
			this.StartTime.Width = 80;
			// 
			// EndTime
			// 
			this.EndTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.EndTime.HeaderText = "EndTime";
			this.EndTime.Name = "EndTime";
			this.EndTime.Width = 74;
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
			this.ShowIcon = false;
			this.Text = "ContractForm";
			((System.ComponentModel.ISupportInitialize)(this.dgvContract)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvContract;
		private System.Windows.Forms.DataGridViewTextBoxColumn colId;
		private System.Windows.Forms.DataGridViewTextBoxColumn colContractType;
		private System.Windows.Forms.DataGridViewTextBoxColumn data_implementation_local_id;
		private System.Windows.Forms.DataGridViewTextBoxColumn service_implementation_local_id;
		private System.Windows.Forms.DataGridViewTextBoxColumn process_implementation_local_id;
		private System.Windows.Forms.DataGridViewTextBoxColumn colEventId;
		private System.Windows.Forms.DataGridViewTextBoxColumn event_implementation_local_id;
		private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn EndTime;
	}
}