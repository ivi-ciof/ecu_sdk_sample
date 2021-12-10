
namespace CIOFContractSample
{
	partial class ServiceListForm
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
			this.dgvServiceList = new System.Windows.Forms.DataGridView();
			this.colServiceImplementetionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colServiceImplementetionLocalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colServiceDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colProcessImplementationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colProcessImplementationLocalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colProcessName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colProcessDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colEventImplementationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colEventImplementationLocalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colEventName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colEventDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSetting = new System.Windows.Forms.DataGridViewButtonColumn();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnExportJson = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvServiceList)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvServiceList
			// 
			this.dgvServiceList.AllowUserToAddRows = false;
			this.dgvServiceList.AllowUserToDeleteRows = false;
			this.dgvServiceList.AllowUserToResizeColumns = false;
			this.dgvServiceList.AllowUserToResizeRows = false;
			this.dgvServiceList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvServiceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvServiceList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colServiceImplementetionId,
            this.colServiceImplementetionLocalId,
            this.colServiceName,
            this.colServiceDescription,
            this.colProcessImplementationId,
            this.colProcessImplementationLocalId,
            this.colProcessName,
            this.colProcessDescription,
            this.colEventImplementationId,
            this.colEventImplementationLocalId,
            this.colEventName,
            this.colEventDescription,
            this.colSetting});
			this.dgvServiceList.Location = new System.Drawing.Point(12, 52);
			this.dgvServiceList.MultiSelect = false;
			this.dgvServiceList.Name = "dgvServiceList";
			this.dgvServiceList.RowHeadersVisible = false;
			this.dgvServiceList.RowTemplate.Height = 21;
			this.dgvServiceList.Size = new System.Drawing.Size(1267, 191);
			this.dgvServiceList.TabIndex = 0;
			this.dgvServiceList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServiceList_CellContentClick);
			// 
			// colServiceImplementetionId
			// 
			this.colServiceImplementetionId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
			this.colServiceImplementetionId.DefaultCellStyle = dataGridViewCellStyle1;
			this.colServiceImplementetionId.HeaderText = "ServiceId";
			this.colServiceImplementetionId.Name = "colServiceImplementetionId";
			this.colServiceImplementetionId.ReadOnly = true;
			this.colServiceImplementetionId.Width = 77;
			// 
			// colServiceImplementetionLocalId
			// 
			this.colServiceImplementetionLocalId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
			this.colServiceImplementetionLocalId.DefaultCellStyle = dataGridViewCellStyle2;
			this.colServiceImplementetionLocalId.HeaderText = "ServiceLocalId";
			this.colServiceImplementetionLocalId.Name = "colServiceImplementetionLocalId";
			this.colServiceImplementetionLocalId.ReadOnly = true;
			this.colServiceImplementetionLocalId.Width = 104;
			// 
			// colServiceName
			// 
			this.colServiceName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
			this.colServiceName.DefaultCellStyle = dataGridViewCellStyle3;
			this.colServiceName.HeaderText = "ServiceName";
			this.colServiceName.Name = "colServiceName";
			this.colServiceName.ReadOnly = true;
			this.colServiceName.Width = 97;
			// 
			// colServiceDescription
			// 
			this.colServiceDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
			this.colServiceDescription.DefaultCellStyle = dataGridViewCellStyle4;
			this.colServiceDescription.HeaderText = "ServiceDescription";
			this.colServiceDescription.Name = "colServiceDescription";
			this.colServiceDescription.ReadOnly = true;
			this.colServiceDescription.Width = 126;
			// 
			// colProcessImplementationId
			// 
			this.colProcessImplementationId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
			this.colProcessImplementationId.DefaultCellStyle = dataGridViewCellStyle5;
			this.colProcessImplementationId.HeaderText = "ProcessId";
			this.colProcessImplementationId.Name = "colProcessImplementationId";
			this.colProcessImplementationId.ReadOnly = true;
			this.colProcessImplementationId.Width = 80;
			// 
			// colProcessImplementationLocalId
			// 
			this.colProcessImplementationLocalId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.Silver;
			this.colProcessImplementationLocalId.DefaultCellStyle = dataGridViewCellStyle6;
			this.colProcessImplementationLocalId.HeaderText = "ProcessLocalId";
			this.colProcessImplementationLocalId.Name = "colProcessImplementationLocalId";
			this.colProcessImplementationLocalId.ReadOnly = true;
			this.colProcessImplementationLocalId.Width = 107;
			// 
			// colProcessName
			// 
			this.colProcessName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.Silver;
			this.colProcessName.DefaultCellStyle = dataGridViewCellStyle7;
			this.colProcessName.HeaderText = "ProcessName";
			this.colProcessName.Name = "colProcessName";
			this.colProcessName.ReadOnly = true;
			// 
			// colProcessDescription
			// 
			this.colProcessDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.Silver;
			this.colProcessDescription.DefaultCellStyle = dataGridViewCellStyle8;
			this.colProcessDescription.HeaderText = "ProcessDescription";
			this.colProcessDescription.Name = "colProcessDescription";
			this.colProcessDescription.ReadOnly = true;
			this.colProcessDescription.Width = 129;
			// 
			// colEventImplementationId
			// 
			this.colEventImplementationId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.Silver;
			this.colEventImplementationId.DefaultCellStyle = dataGridViewCellStyle9;
			this.colEventImplementationId.HeaderText = "EventId";
			this.colEventImplementationId.Name = "colEventImplementationId";
			this.colEventImplementationId.ReadOnly = true;
			this.colEventImplementationId.Width = 68;
			// 
			// colEventImplementationLocalId
			// 
			this.colEventImplementationLocalId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle10.BackColor = System.Drawing.Color.Silver;
			this.colEventImplementationLocalId.DefaultCellStyle = dataGridViewCellStyle10;
			this.colEventImplementationLocalId.HeaderText = "EventLocalId";
			this.colEventImplementationLocalId.Name = "colEventImplementationLocalId";
			this.colEventImplementationLocalId.ReadOnly = true;
			this.colEventImplementationLocalId.Width = 95;
			// 
			// colEventName
			// 
			this.colEventName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle11.BackColor = System.Drawing.Color.Silver;
			this.colEventName.DefaultCellStyle = dataGridViewCellStyle11;
			this.colEventName.HeaderText = "EventName";
			this.colEventName.Name = "colEventName";
			this.colEventName.ReadOnly = true;
			this.colEventName.Width = 88;
			// 
			// colEventDescription
			// 
			this.colEventDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle12.BackColor = System.Drawing.Color.Silver;
			this.colEventDescription.DefaultCellStyle = dataGridViewCellStyle12;
			this.colEventDescription.HeaderText = "EventDescription";
			this.colEventDescription.Name = "colEventDescription";
			this.colEventDescription.ReadOnly = true;
			this.colEventDescription.Width = 117;
			// 
			// colSetting
			// 
			this.colSetting.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colSetting.HeaderText = "Setting";
			this.colSetting.Name = "colSetting";
			this.colSetting.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.colSetting.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.colSetting.Text = "Setting";
			this.colSetting.Width = 66;
			// 
			// btnRefresh
			// 
			this.btnRefresh.Location = new System.Drawing.Point(12, 11);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(88, 35);
			this.btnRefresh.TabIndex = 1;
			this.btnRefresh.Text = "Refresh";
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(601, 260);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(88, 35);
			this.btnUpdate.TabIndex = 2;
			this.btnUpdate.Text = "update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnExportJson
			// 
			this.btnExportJson.Location = new System.Drawing.Point(1190, 11);
			this.btnExportJson.Name = "btnExportJson";
			this.btnExportJson.Size = new System.Drawing.Size(88, 35);
			this.btnExportJson.TabIndex = 3;
			this.btnExportJson.Text = "Export Json";
			this.btnExportJson.UseVisualStyleBackColor = true;
			this.btnExportJson.Click += new System.EventHandler(this.btnExportJson_Click);
			// 
			// ServiceListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1290, 306);
			this.Controls.Add(this.btnExportJson);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.dgvServiceList);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ServiceListForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ServiceListForm";
			((System.ComponentModel.ISupportInitialize)(this.dgvServiceList)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvServiceList;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.DataGridViewTextBoxColumn colServiceImplementetionId;
		private System.Windows.Forms.DataGridViewTextBoxColumn colServiceImplementetionLocalId;
		private System.Windows.Forms.DataGridViewTextBoxColumn colServiceName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colServiceDescription;
		private System.Windows.Forms.DataGridViewTextBoxColumn colProcessImplementationId;
		private System.Windows.Forms.DataGridViewTextBoxColumn colProcessImplementationLocalId;
		private System.Windows.Forms.DataGridViewTextBoxColumn colProcessName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colProcessDescription;
		private System.Windows.Forms.DataGridViewTextBoxColumn colEventImplementationId;
		private System.Windows.Forms.DataGridViewTextBoxColumn colEventImplementationLocalId;
		private System.Windows.Forms.DataGridViewTextBoxColumn colEventName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colEventDescription;
		private System.Windows.Forms.DataGridViewButtonColumn colSetting;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnExportJson;
	}
}