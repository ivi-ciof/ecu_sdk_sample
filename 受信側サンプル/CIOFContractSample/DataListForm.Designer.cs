
namespace CIOFContractSample
{
	partial class DataListForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvDataList = new System.Windows.Forms.DataGridView();
			this.DataImplementationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DataImplementationLocalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ServiceImplementationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DataName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DataDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DataSettings = new System.Windows.Forms.DataGridViewButtonColumn();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.btnExportJson = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvDataList)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvDataList
			// 
			this.dgvDataList.AllowUserToAddRows = false;
			this.dgvDataList.AllowUserToDeleteRows = false;
			this.dgvDataList.AllowUserToResizeColumns = false;
			this.dgvDataList.AllowUserToResizeRows = false;
			this.dgvDataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDataList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataImplementationId,
            this.DataImplementationLocalId,
            this.ServiceImplementationId,
            this.DataName,
            this.DataDescription,
            this.DataSettings});
			this.dgvDataList.Location = new System.Drawing.Point(12, 72);
			this.dgvDataList.MultiSelect = false;
			this.dgvDataList.Name = "dgvDataList";
			this.dgvDataList.RowHeadersVisible = false;
			this.dgvDataList.Size = new System.Drawing.Size(807, 426);
			this.dgvDataList.TabIndex = 0;
			this.dgvDataList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataList_CellContentClick);
			// 
			// DataImplementationId
			// 
			dataGridViewCellStyle11.BackColor = System.Drawing.Color.Silver;
			this.DataImplementationId.DefaultCellStyle = dataGridViewCellStyle11;
			this.DataImplementationId.HeaderText = "DataImplementationId";
			this.DataImplementationId.Name = "DataImplementationId";
			this.DataImplementationId.ReadOnly = true;
			this.DataImplementationId.Width = 140;
			// 
			// DataImplementationLocalId
			// 
			dataGridViewCellStyle12.BackColor = System.Drawing.Color.Silver;
			this.DataImplementationLocalId.DefaultCellStyle = dataGridViewCellStyle12;
			this.DataImplementationLocalId.HeaderText = "DataImplementationLocalId";
			this.DataImplementationLocalId.Name = "DataImplementationLocalId";
			this.DataImplementationLocalId.ReadOnly = true;
			this.DataImplementationLocalId.Width = 170;
			// 
			// ServiceImplementationId
			// 
			dataGridViewCellStyle13.BackColor = System.Drawing.Color.Silver;
			this.ServiceImplementationId.DefaultCellStyle = dataGridViewCellStyle13;
			this.ServiceImplementationId.HeaderText = "ServiceId";
			this.ServiceImplementationId.Name = "ServiceImplementationId";
			this.ServiceImplementationId.ReadOnly = true;
			// 
			// DataName
			// 
			dataGridViewCellStyle14.BackColor = System.Drawing.Color.Silver;
			this.DataName.DefaultCellStyle = dataGridViewCellStyle14;
			this.DataName.HeaderText = "Name";
			this.DataName.Name = "DataName";
			this.DataName.ReadOnly = true;
			this.DataName.Width = 140;
			// 
			// DataDescription
			// 
			dataGridViewCellStyle15.BackColor = System.Drawing.Color.Silver;
			this.DataDescription.DefaultCellStyle = dataGridViewCellStyle15;
			this.DataDescription.HeaderText = "Description";
			this.DataDescription.Name = "DataDescription";
			this.DataDescription.ReadOnly = true;
			this.DataDescription.Width = 140;
			// 
			// DataSettings
			// 
			this.DataSettings.HeaderText = "Settings";
			this.DataSettings.Name = "DataSettings";
			this.DataSettings.ReadOnly = true;
			// 
			// btnRefresh
			// 
			this.btnRefresh.Location = new System.Drawing.Point(12, 21);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(88, 35);
			this.btnRefresh.TabIndex = 1;
			this.btnRefresh.Text = "refresh";
			this.btnRefresh.UseVisualStyleBackColor = true;
			// 
			// btnExportJson
			// 
			this.btnExportJson.Location = new System.Drawing.Point(731, 21);
			this.btnExportJson.Name = "btnExportJson";
			this.btnExportJson.Size = new System.Drawing.Size(88, 35);
			this.btnExportJson.TabIndex = 2;
			this.btnExportJson.Text = "Export Json";
			this.btnExportJson.UseVisualStyleBackColor = true;
			this.btnExportJson.Click += new System.EventHandler(this.btnExportJson_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(373, 517);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(88, 35);
			this.btnUpdate.TabIndex = 3;
			this.btnUpdate.Text = "update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// DataListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(831, 578);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnExportJson);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.dgvDataList);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DataListForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DataListForm";
			((System.ComponentModel.ISupportInitialize)(this.dgvDataList)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvDataList;
		private System.Windows.Forms.DataGridViewTextBoxColumn DataImplementationId;
		private System.Windows.Forms.DataGridViewTextBoxColumn DataImplementationLocalId;
		private System.Windows.Forms.DataGridViewTextBoxColumn ServiceImplementationId;
		private System.Windows.Forms.DataGridViewTextBoxColumn DataName;
		private System.Windows.Forms.DataGridViewTextBoxColumn DataDescription;
		private System.Windows.Forms.DataGridViewButtonColumn DataSettings;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.Button btnExportJson;
		private System.Windows.Forms.Button btnUpdate;
	}
}