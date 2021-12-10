
namespace CIOFContractSample_Factory
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvService = new System.Windows.Forms.DataGridView();
			this.colServiceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colServiceLocalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colServiceDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colProcessId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colProcessLocalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colProcessName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colProcessDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colEventId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colEventLocalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colEventName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colEventDescripton = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSetting = new System.Windows.Forms.DataGridViewButtonColumn();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnExportJson = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvService)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvService
			// 
			this.dgvService.AllowUserToAddRows = false;
			this.dgvService.AllowUserToDeleteRows = false;
			this.dgvService.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colServiceId,
            this.colServiceLocalId,
            this.colServiceName,
            this.colServiceDescription,
            this.colProcessId,
            this.colProcessLocalId,
            this.colProcessName,
            this.colProcessDescription,
            this.colEventId,
            this.colEventLocalId,
            this.colEventName,
            this.colEventDescripton,
            this.colSetting});
			this.dgvService.Location = new System.Drawing.Point(24, 68);
			this.dgvService.Margin = new System.Windows.Forms.Padding(2);
			this.dgvService.Name = "dgvService";
			this.dgvService.RowHeadersVisible = false;
			this.dgvService.RowTemplate.Height = 27;
			this.dgvService.Size = new System.Drawing.Size(1266, 182);
			this.dgvService.TabIndex = 0;
			this.dgvService.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvService_CellContentClick);
			// 
			// colServiceId
			// 
			this.colServiceId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
			this.colServiceId.DefaultCellStyle = dataGridViewCellStyle1;
			this.colServiceId.HeaderText = "ServiceId";
			this.colServiceId.Name = "colServiceId";
			this.colServiceId.ReadOnly = true;
			this.colServiceId.Width = 77;
			// 
			// colServiceLocalId
			// 
			this.colServiceLocalId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
			this.colServiceLocalId.DefaultCellStyle = dataGridViewCellStyle2;
			this.colServiceLocalId.HeaderText = "ServiceLocalId";
			this.colServiceLocalId.Name = "colServiceLocalId";
			this.colServiceLocalId.ReadOnly = true;
			this.colServiceLocalId.Width = 104;
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
			// colProcessId
			// 
			this.colProcessId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
			this.colProcessId.DefaultCellStyle = dataGridViewCellStyle5;
			this.colProcessId.HeaderText = "ProcessId";
			this.colProcessId.Name = "colProcessId";
			this.colProcessId.ReadOnly = true;
			this.colProcessId.Width = 80;
			// 
			// colProcessLocalId
			// 
			this.colProcessLocalId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.Silver;
			this.colProcessLocalId.DefaultCellStyle = dataGridViewCellStyle6;
			this.colProcessLocalId.HeaderText = "ProcessLocalId";
			this.colProcessLocalId.Name = "colProcessLocalId";
			this.colProcessLocalId.ReadOnly = true;
			this.colProcessLocalId.Width = 107;
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
			// colEventDescripton
			// 
			this.colEventDescripton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle12.BackColor = System.Drawing.Color.Silver;
			this.colEventDescripton.DefaultCellStyle = dataGridViewCellStyle12;
			this.colEventDescripton.HeaderText = "EventDescription";
			this.colEventDescripton.Name = "colEventDescripton";
			this.colEventDescripton.ReadOnly = true;
			this.colEventDescripton.Width = 117;
			// 
			// colSetting
			// 
			this.colSetting.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle13.BackColor = System.Drawing.Color.Silver;
			this.colSetting.DefaultCellStyle = dataGridViewCellStyle13;
			this.colSetting.HeaderText = "Setting";
			this.colSetting.Name = "colSetting";
			this.colSetting.ReadOnly = true;
			this.colSetting.Width = 47;
			// 
			// btnRefresh
			// 
			this.btnRefresh.Location = new System.Drawing.Point(24, 23);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(88, 35);
			this.btnRefresh.TabIndex = 1;
			this.btnRefresh.Text = "Refresh";
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(606, 259);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(88, 35);
			this.btnUpdate.TabIndex = 2;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnExportJson
			// 
			this.btnExportJson.Location = new System.Drawing.Point(1201, 23);
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
			this.ClientSize = new System.Drawing.Size(1301, 306);
			this.Controls.Add(this.btnExportJson);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.dgvService);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ServiceListForm";
			this.ShowIcon = false;
			this.Text = "ServiceListForm ";
			((System.ComponentModel.ISupportInitialize)(this.dgvService)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvService;
		private System.Windows.Forms.DataGridViewTextBoxColumn colServiceId;
		private System.Windows.Forms.DataGridViewTextBoxColumn colServiceLocalId;
		private System.Windows.Forms.DataGridViewTextBoxColumn colServiceName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colServiceDescription;
		private System.Windows.Forms.DataGridViewTextBoxColumn colProcessId;
		private System.Windows.Forms.DataGridViewTextBoxColumn colProcessLocalId;
		private System.Windows.Forms.DataGridViewTextBoxColumn colProcessName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colProcessDescription;
		private System.Windows.Forms.DataGridViewTextBoxColumn colEventId;
		private System.Windows.Forms.DataGridViewTextBoxColumn colEventLocalId;
		private System.Windows.Forms.DataGridViewTextBoxColumn colEventName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colEventDescripton;
		private System.Windows.Forms.DataGridViewButtonColumn colSetting;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnExportJson;
	}
}