
namespace CIOFContractSample
{
	partial class DataSettingForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.lblDataImplementationId = new System.Windows.Forms.Label();
			this.tbxDataImplementationId = new System.Windows.Forms.TextBox();
			this.lblDataImplementationLocalId = new System.Windows.Forms.Label();
			this.tbxDataImplementationLocalId = new System.Windows.Forms.TextBox();
			this.dgvDataProperty = new System.Windows.Forms.DataGridView();
			this.tbxDataIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tbxDataPropertyInplementationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tbxDataImplemtationPropertyLocalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tbxDataName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cbxDataPropertyStatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.tbxDataPropertyRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.lblDataStatus = new System.Windows.Forms.Label();
			this.cbxDataStatus = new System.Windows.Forms.ComboBox();
			this.lblRemarks = new System.Windows.Forms.Label();
			this.tbxRemarks = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvDataProperty)).BeginInit();
			this.SuspendLayout();
			// 
			// lblDataImplementationId
			// 
			this.lblDataImplementationId.AutoSize = true;
			this.lblDataImplementationId.Location = new System.Drawing.Point(29, 25);
			this.lblDataImplementationId.Name = "lblDataImplementationId";
			this.lblDataImplementationId.Size = new System.Drawing.Size(113, 12);
			this.lblDataImplementationId.TabIndex = 0;
			this.lblDataImplementationId.Text = "dataImplementationId";
			// 
			// tbxDataImplementationId
			// 
			this.tbxDataImplementationId.Location = new System.Drawing.Point(181, 22);
			this.tbxDataImplementationId.Name = "tbxDataImplementationId";
			this.tbxDataImplementationId.ReadOnly = true;
			this.tbxDataImplementationId.Size = new System.Drawing.Size(260, 19);
			this.tbxDataImplementationId.TabIndex = 1;
			// 
			// lblDataImplementationLocalId
			// 
			this.lblDataImplementationLocalId.AutoSize = true;
			this.lblDataImplementationLocalId.Location = new System.Drawing.Point(29, 68);
			this.lblDataImplementationLocalId.Name = "lblDataImplementationLocalId";
			this.lblDataImplementationLocalId.Size = new System.Drawing.Size(140, 12);
			this.lblDataImplementationLocalId.TabIndex = 2;
			this.lblDataImplementationLocalId.Text = "dataImplementationLocalId";
			// 
			// tbxDataImplementationLocalId
			// 
			this.tbxDataImplementationLocalId.Location = new System.Drawing.Point(181, 64);
			this.tbxDataImplementationLocalId.Name = "tbxDataImplementationLocalId";
			this.tbxDataImplementationLocalId.Size = new System.Drawing.Size(260, 19);
			this.tbxDataImplementationLocalId.TabIndex = 3;
			// 
			// dgvDataProperty
			// 
			this.dgvDataProperty.AllowUserToAddRows = false;
			this.dgvDataProperty.AllowUserToDeleteRows = false;
			this.dgvDataProperty.AllowUserToResizeColumns = false;
			this.dgvDataProperty.AllowUserToResizeRows = false;
			this.dgvDataProperty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDataProperty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tbxDataIndex,
            this.tbxDataPropertyInplementationId,
            this.tbxDataImplemtationPropertyLocalId,
            this.tbxDataName,
            this.cbxDataPropertyStatus,
            this.tbxDataPropertyRemarks});
			this.dgvDataProperty.Location = new System.Drawing.Point(33, 207);
			this.dgvDataProperty.MultiSelect = false;
			this.dgvDataProperty.Name = "dgvDataProperty";
			this.dgvDataProperty.RowHeadersVisible = false;
			this.dgvDataProperty.RowTemplate.Height = 21;
			this.dgvDataProperty.Size = new System.Drawing.Size(410, 250);
			this.dgvDataProperty.TabIndex = 10;
			// 
			// tbxDataIndex
			// 
			this.tbxDataIndex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
			this.tbxDataIndex.DefaultCellStyle = dataGridViewCellStyle4;
			this.tbxDataIndex.HeaderText = "Index";
			this.tbxDataIndex.Name = "tbxDataIndex";
			this.tbxDataIndex.ReadOnly = true;
			this.tbxDataIndex.Width = 57;
			// 
			// tbxDataPropertyInplementationId
			// 
			this.tbxDataPropertyInplementationId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
			this.tbxDataPropertyInplementationId.DefaultCellStyle = dataGridViewCellStyle5;
			this.tbxDataPropertyInplementationId.HeaderText = "Id";
			this.tbxDataPropertyInplementationId.Name = "tbxDataPropertyInplementationId";
			this.tbxDataPropertyInplementationId.ReadOnly = true;
			this.tbxDataPropertyInplementationId.Width = 39;
			// 
			// tbxDataImplemtationPropertyLocalId
			// 
			this.tbxDataImplemtationPropertyLocalId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.tbxDataImplemtationPropertyLocalId.HeaderText = "LocalId";
			this.tbxDataImplemtationPropertyLocalId.Name = "tbxDataImplemtationPropertyLocalId";
			this.tbxDataImplemtationPropertyLocalId.Width = 66;
			// 
			// tbxDataName
			// 
			this.tbxDataName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.Silver;
			this.tbxDataName.DefaultCellStyle = dataGridViewCellStyle6;
			this.tbxDataName.HeaderText = "Name";
			this.tbxDataName.Name = "tbxDataName";
			this.tbxDataName.ReadOnly = true;
			this.tbxDataName.Width = 59;
			// 
			// cbxDataPropertyStatus
			// 
			this.cbxDataPropertyStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.cbxDataPropertyStatus.HeaderText = "Status";
			this.cbxDataPropertyStatus.Name = "cbxDataPropertyStatus";
			this.cbxDataPropertyStatus.Width = 44;
			// 
			// tbxDataPropertyRemarks
			// 
			this.tbxDataPropertyRemarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.tbxDataPropertyRemarks.HeaderText = "remarks";
			this.tbxDataPropertyRemarks.Name = "tbxDataPropertyRemarks";
			this.tbxDataPropertyRemarks.Width = 71;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(183, 483);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(104, 22);
			this.btnUpdate.TabIndex = 11;
			this.btnUpdate.Text = "update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// lblDataStatus
			// 
			this.lblDataStatus.AutoSize = true;
			this.lblDataStatus.Location = new System.Drawing.Point(29, 111);
			this.lblDataStatus.Name = "lblDataStatus";
			this.lblDataStatus.Size = new System.Drawing.Size(60, 12);
			this.lblDataStatus.TabIndex = 12;
			this.lblDataStatus.Text = "dataStatus";
			// 
			// cbxDataStatus
			// 
			this.cbxDataStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxDataStatus.FormattingEnabled = true;
			this.cbxDataStatus.Location = new System.Drawing.Point(181, 106);
			this.cbxDataStatus.Name = "cbxDataStatus";
			this.cbxDataStatus.Size = new System.Drawing.Size(260, 20);
			this.cbxDataStatus.TabIndex = 13;
			// 
			// lblRemarks
			// 
			this.lblRemarks.AutoSize = true;
			this.lblRemarks.Location = new System.Drawing.Point(29, 160);
			this.lblRemarks.Name = "lblRemarks";
			this.lblRemarks.Size = new System.Drawing.Size(46, 12);
			this.lblRemarks.TabIndex = 14;
			this.lblRemarks.Text = "remarks";
			// 
			// tbxRemarks
			// 
			this.tbxRemarks.Location = new System.Drawing.Point(183, 157);
			this.tbxRemarks.Name = "tbxRemarks";
			this.tbxRemarks.Size = new System.Drawing.Size(260, 19);
			this.tbxRemarks.TabIndex = 15;
			// 
			// DataSettingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(470, 533);
			this.Controls.Add(this.tbxRemarks);
			this.Controls.Add(this.lblRemarks);
			this.Controls.Add(this.cbxDataStatus);
			this.Controls.Add(this.lblDataStatus);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.dgvDataProperty);
			this.Controls.Add(this.tbxDataImplementationLocalId);
			this.Controls.Add(this.lblDataImplementationLocalId);
			this.Controls.Add(this.tbxDataImplementationId);
			this.Controls.Add(this.lblDataImplementationId);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DataSettingForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DataSettingForm";
			((System.ComponentModel.ISupportInitialize)(this.dgvDataProperty)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblDataImplementationId;
		private System.Windows.Forms.TextBox tbxDataImplementationId;
		private System.Windows.Forms.Label lblDataImplementationLocalId;
		private System.Windows.Forms.TextBox tbxDataImplementationLocalId;
		private System.Windows.Forms.DataGridView dgvDataProperty;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Label lblDataStatus;
		private System.Windows.Forms.ComboBox cbxDataStatus;
		private System.Windows.Forms.Label lblRemarks;
		private System.Windows.Forms.TextBox tbxRemarks;
		private System.Windows.Forms.DataGridViewTextBoxColumn tbxDataIndex;
		private System.Windows.Forms.DataGridViewTextBoxColumn tbxDataPropertyInplementationId;
		private System.Windows.Forms.DataGridViewTextBoxColumn tbxDataImplemtationPropertyLocalId;
		private System.Windows.Forms.DataGridViewTextBoxColumn tbxDataName;
		private System.Windows.Forms.DataGridViewComboBoxColumn cbxDataPropertyStatus;
		private System.Windows.Forms.DataGridViewTextBoxColumn tbxDataPropertyRemarks;
	}
}