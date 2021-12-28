
namespace CIOFContractSample_Factory
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvDataList = new System.Windows.Forms.DataGridView();
			this.colDataId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDataLocalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colServiceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSetting = new System.Windows.Forms.DataGridViewButtonColumn();
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
			this.dgvDataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDataList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDataId,
            this.colDataLocalId,
            this.colServiceId,
            this.colName,
            this.colDescription,
            this.colSetting});
			this.dgvDataList.Location = new System.Drawing.Point(12, 72);
			this.dgvDataList.Margin = new System.Windows.Forms.Padding(2);
			this.dgvDataList.Name = "dgvDataList";
			this.dgvDataList.RowHeadersVisible = false;
			this.dgvDataList.RowTemplate.Height = 27;
			this.dgvDataList.Size = new System.Drawing.Size(807, 426);
			this.dgvDataList.TabIndex = 0;
			this.dgvDataList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataImple_CellContentClick);
			// 
			// colDataId
			// 
			this.colDataId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
			this.colDataId.DefaultCellStyle = dataGridViewCellStyle1;
			this.colDataId.HeaderText = "DataId";
			this.colDataId.Name = "colDataId";
			this.colDataId.Width = 63;
			// 
			// colDataLocalId
			// 
			this.colDataLocalId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
			this.colDataLocalId.DefaultCellStyle = dataGridViewCellStyle2;
			this.colDataLocalId.HeaderText = "DataLocalId";
			this.colDataLocalId.Name = "colDataLocalId";
			this.colDataLocalId.Width = 90;
			// 
			// colServiceId
			// 
			this.colServiceId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
			this.colServiceId.DefaultCellStyle = dataGridViewCellStyle3;
			this.colServiceId.HeaderText = "ServiceId";
			this.colServiceId.Name = "colServiceId";
			this.colServiceId.Width = 77;
			// 
			// colName
			// 
			this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
			this.colName.DefaultCellStyle = dataGridViewCellStyle4;
			this.colName.HeaderText = "Name";
			this.colName.Name = "colName";
			this.colName.Width = 59;
			// 
			// colDescription
			// 
			this.colDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
			this.colDescription.DefaultCellStyle = dataGridViewCellStyle5;
			this.colDescription.HeaderText = "Description";
			this.colDescription.Name = "colDescription";
			this.colDescription.Width = 88;
			// 
			// colSetting
			// 
			this.colSetting.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.Silver;
			this.colSetting.DefaultCellStyle = dataGridViewCellStyle6;
			this.colSetting.HeaderText = "Setting";
			this.colSetting.Name = "colSetting";
			this.colSetting.Width = 47;
			// 
			// btnRefresh
			// 
			this.btnRefresh.Location = new System.Drawing.Point(12, 21);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(88, 35);
			this.btnRefresh.TabIndex = 1;
			this.btnRefresh.Text = "refresh";
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
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
			this.btnUpdate.Location = new System.Drawing.Point(371, 519);
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
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DataListForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DataImplListForm";
			((System.ComponentModel.ISupportInitialize)(this.dgvDataList)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvDataList;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.Button btnExportJson;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDataId;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDataLocalId;
		private System.Windows.Forms.DataGridViewTextBoxColumn colServiceId;
		private System.Windows.Forms.DataGridViewTextBoxColumn colName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
		private System.Windows.Forms.DataGridViewButtonColumn colSetting;
	}
}