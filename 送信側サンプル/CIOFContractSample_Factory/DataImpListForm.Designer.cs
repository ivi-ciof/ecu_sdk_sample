
namespace CIOFContractSample_Factory
{
	partial class DataImpListForm
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
			this.dgvDataImple = new System.Windows.Forms.DataGridView();
			this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colLocalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colServiceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSetting = new System.Windows.Forms.DataGridViewButtonColumn();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.btnExportJson = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvDataImple)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvDataImple
			// 
			this.dgvDataImple.AllowUserToAddRows = false;
			this.dgvDataImple.AllowUserToDeleteRows = false;
			this.dgvDataImple.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDataImple.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colLocalId,
            this.colServiceId,
            this.colName,
            this.colDescription,
            this.colSetting});
			this.dgvDataImple.Location = new System.Drawing.Point(23, 62);
			this.dgvDataImple.Margin = new System.Windows.Forms.Padding(2);
			this.dgvDataImple.Name = "dgvDataImple";
			this.dgvDataImple.RowHeadersVisible = false;
			this.dgvDataImple.RowTemplate.Height = 27;
			this.dgvDataImple.Size = new System.Drawing.Size(599, 235);
			this.dgvDataImple.TabIndex = 0;
			this.dgvDataImple.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataImple_CellContentClick);
			// 
			// colId
			// 
			this.colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.Silver;
			this.colId.DefaultCellStyle = dataGridViewCellStyle7;
			this.colId.HeaderText = "DataId";
			this.colId.Name = "colId";
			this.colId.Width = 63;
			// 
			// colLocalId
			// 
			this.colLocalId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.Silver;
			this.colLocalId.DefaultCellStyle = dataGridViewCellStyle8;
			this.colLocalId.HeaderText = "DataLocalId";
			this.colLocalId.Name = "colLocalId";
			this.colLocalId.Width = 90;
			// 
			// colServiceId
			// 
			this.colServiceId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.Silver;
			this.colServiceId.DefaultCellStyle = dataGridViewCellStyle9;
			this.colServiceId.HeaderText = "ServiceId";
			this.colServiceId.Name = "colServiceId";
			this.colServiceId.Width = 77;
			// 
			// colName
			// 
			this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle10.BackColor = System.Drawing.Color.Silver;
			this.colName.DefaultCellStyle = dataGridViewCellStyle10;
			this.colName.HeaderText = "Name";
			this.colName.Name = "colName";
			this.colName.Width = 59;
			// 
			// colDescription
			// 
			this.colDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle11.BackColor = System.Drawing.Color.Silver;
			this.colDescription.DefaultCellStyle = dataGridViewCellStyle11;
			this.colDescription.HeaderText = "Description";
			this.colDescription.Name = "colDescription";
			this.colDescription.Width = 88;
			// 
			// colSetting
			// 
			this.colSetting.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle12.BackColor = System.Drawing.Color.Silver;
			this.colSetting.DefaultCellStyle = dataGridViewCellStyle12;
			this.colSetting.HeaderText = "Setting";
			this.colSetting.Name = "colSetting";
			this.colSetting.Width = 47;
			// 
			// btnRefresh
			// 
			this.btnRefresh.Location = new System.Drawing.Point(23, 12);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(88, 35);
			this.btnRefresh.TabIndex = 1;
			this.btnRefresh.Text = "refresh";
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// btnExportJson
			// 
			this.btnExportJson.Location = new System.Drawing.Point(534, 12);
			this.btnExportJson.Name = "btnExportJson";
			this.btnExportJson.Size = new System.Drawing.Size(88, 35);
			this.btnExportJson.TabIndex = 2;
			this.btnExportJson.Text = "Export Json";
			this.btnExportJson.UseVisualStyleBackColor = true;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(283, 313);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(88, 35);
			this.btnUpdate.TabIndex = 3;
			this.btnUpdate.Text = "update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// DataImpListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(655, 360);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnExportJson);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.dgvDataImple);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DataImpListForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DataImplListForm";
			((System.ComponentModel.ISupportInitialize)(this.dgvDataImple)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvDataImple;
		private System.Windows.Forms.DataGridViewTextBoxColumn colId;
		private System.Windows.Forms.DataGridViewTextBoxColumn colLocalId;
		private System.Windows.Forms.DataGridViewTextBoxColumn colServiceId;
		private System.Windows.Forms.DataGridViewTextBoxColumn colName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
		private System.Windows.Forms.DataGridViewButtonColumn colSetting;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.Button btnExportJson;
		private System.Windows.Forms.Button btnUpdate;
	}
}