
namespace CIOFContractSample_Factory
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.lblDataImplementationId = new System.Windows.Forms.Label();
			this.tbxDataImplementationId = new System.Windows.Forms.TextBox();
			this.lblDataImplementationLocalId = new System.Windows.Forms.Label();
			this.tbxDataImplementationLocalId = new System.Windows.Forms.TextBox();
			this.lblDataStatus = new System.Windows.Forms.Label();
			this.cbxDataStatus = new System.Windows.Forms.ComboBox();
			this.lblServiceImplementationId = new System.Windows.Forms.Label();
			this.tbxServiceImplementationId = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.tbxName = new System.Windows.Forms.TextBox();
			this.lblDescription = new System.Windows.Forms.Label();
			this.tbxDescription = new System.Windows.Forms.TextBox();
			this.lblRemarks = new System.Windows.Forms.Label();
			this.tbxRemarks = new System.Windows.Forms.TextBox();
			this.dgvDataProperty = new System.Windows.Forms.DataGridView();
			this.colIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colLocalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colStatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.colRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnUpdate = new System.Windows.Forms.Button();
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
			this.tbxDataImplementationLocalId.Location = new System.Drawing.Point(181, 65);
			this.tbxDataImplementationLocalId.Name = "tbxDataImplementationLocalId";
			this.tbxDataImplementationLocalId.Size = new System.Drawing.Size(260, 19);
			this.tbxDataImplementationLocalId.TabIndex = 3;
			// 
			// lblDataStatus
			// 
			this.lblDataStatus.AutoSize = true;
			this.lblDataStatus.Location = new System.Drawing.Point(29, 111);
			this.lblDataStatus.Name = "lblDataStatus";
			this.lblDataStatus.Size = new System.Drawing.Size(60, 12);
			this.lblDataStatus.TabIndex = 4;
			this.lblDataStatus.Text = "dataStatus";
			// 
			// cbxDataStatus
			// 
			this.cbxDataStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxDataStatus.FormattingEnabled = true;
			this.cbxDataStatus.Location = new System.Drawing.Point(181, 108);
			this.cbxDataStatus.Name = "cbxDataStatus";
			this.cbxDataStatus.Size = new System.Drawing.Size(260, 20);
			this.cbxDataStatus.TabIndex = 5;
			// 
			// lblServiceImplementationId
			// 
			this.lblServiceImplementationId.AutoSize = true;
			this.lblServiceImplementationId.Location = new System.Drawing.Point(29, 154);
			this.lblServiceImplementationId.Name = "lblServiceImplementationId";
			this.lblServiceImplementationId.Size = new System.Drawing.Size(128, 12);
			this.lblServiceImplementationId.TabIndex = 6;
			this.lblServiceImplementationId.Text = "serviceImplementationId";
			// 
			// tbxServiceImplementationId
			// 
			this.tbxServiceImplementationId.Location = new System.Drawing.Point(181, 151);
			this.tbxServiceImplementationId.Name = "tbxServiceImplementationId";
			this.tbxServiceImplementationId.ReadOnly = true;
			this.tbxServiceImplementationId.Size = new System.Drawing.Size(260, 19);
			this.tbxServiceImplementationId.TabIndex = 7;
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(29, 194);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(32, 12);
			this.lblName.TabIndex = 8;
			this.lblName.Text = "name";
			// 
			// tbxName
			// 
			this.tbxName.Location = new System.Drawing.Point(181, 191);
			this.tbxName.Name = "tbxName";
			this.tbxName.ReadOnly = true;
			this.tbxName.Size = new System.Drawing.Size(260, 19);
			this.tbxName.TabIndex = 9;
			// 
			// lblDescription
			// 
			this.lblDescription.AutoSize = true;
			this.lblDescription.Location = new System.Drawing.Point(29, 240);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(61, 12);
			this.lblDescription.TabIndex = 10;
			this.lblDescription.Text = "description";
			// 
			// tbxDescription
			// 
			this.tbxDescription.Location = new System.Drawing.Point(181, 233);
			this.tbxDescription.Name = "tbxDescription";
			this.tbxDescription.ReadOnly = true;
			this.tbxDescription.Size = new System.Drawing.Size(260, 19);
			this.tbxDescription.TabIndex = 11;
			// 
			// lblRemarks
			// 
			this.lblRemarks.AutoSize = true;
			this.lblRemarks.Location = new System.Drawing.Point(29, 283);
			this.lblRemarks.Name = "lblRemarks";
			this.lblRemarks.Size = new System.Drawing.Size(46, 12);
			this.lblRemarks.TabIndex = 12;
			this.lblRemarks.Text = "remarks";
			// 
			// tbxRemarks
			// 
			this.tbxRemarks.Location = new System.Drawing.Point(181, 280);
			this.tbxRemarks.Name = "tbxRemarks";
			this.tbxRemarks.Size = new System.Drawing.Size(260, 19);
			this.tbxRemarks.TabIndex = 13;
			// 
			// dgvDataProperty
			// 
			this.dgvDataProperty.AllowUserToAddRows = false;
			this.dgvDataProperty.AllowUserToDeleteRows = false;
			this.dgvDataProperty.AllowUserToResizeColumns = false;
			this.dgvDataProperty.AllowUserToResizeRows = false;
			this.dgvDataProperty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDataProperty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIndex,
            this.colId,
            this.colLocalId,
            this.colName,
            this.colStatus,
            this.colRemarks});
			this.dgvDataProperty.Location = new System.Drawing.Point(31, 322);
			this.dgvDataProperty.Name = "dgvDataProperty";
			this.dgvDataProperty.RowHeadersVisible = false;
			this.dgvDataProperty.RowTemplate.Height = 21;
			this.dgvDataProperty.Size = new System.Drawing.Size(410, 250);
			this.dgvDataProperty.TabIndex = 14;
			// 
			// colIndex
			// 
			this.colIndex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
			this.colIndex.DefaultCellStyle = dataGridViewCellStyle1;
			this.colIndex.HeaderText = "Index";
			this.colIndex.Name = "colIndex";
			this.colIndex.ReadOnly = true;
			this.colIndex.Width = 57;
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
			// colLocalId
			// 
			this.colLocalId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colLocalId.HeaderText = "LocalId";
			this.colLocalId.Name = "colLocalId";
			this.colLocalId.Width = 66;
			// 
			// colName
			// 
			this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
			this.colName.DefaultCellStyle = dataGridViewCellStyle3;
			this.colName.HeaderText = "Name";
			this.colName.Name = "colName";
			this.colName.ReadOnly = true;
			this.colName.Width = 59;
			// 
			// colStatus
			// 
			this.colStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colStatus.HeaderText = "colStatus";
			this.colStatus.Name = "colStatus";
			this.colStatus.Width = 59;
			// 
			// colRemarks
			// 
			this.colRemarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colRemarks.HeaderText = "Remarks";
			this.colRemarks.Name = "colRemarks";
			this.colRemarks.Width = 75;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(183, 578);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(104, 22);
			this.btnUpdate.TabIndex = 15;
			this.btnUpdate.Text = "update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// DataSettingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(470, 612);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.dgvDataProperty);
			this.Controls.Add(this.tbxRemarks);
			this.Controls.Add(this.lblRemarks);
			this.Controls.Add(this.tbxDescription);
			this.Controls.Add(this.lblDescription);
			this.Controls.Add(this.tbxName);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.tbxServiceImplementationId);
			this.Controls.Add(this.lblServiceImplementationId);
			this.Controls.Add(this.cbxDataStatus);
			this.Controls.Add(this.lblDataStatus);
			this.Controls.Add(this.tbxDataImplementationLocalId);
			this.Controls.Add(this.lblDataImplementationLocalId);
			this.Controls.Add(this.tbxDataImplementationId);
			this.Controls.Add(this.lblDataImplementationId);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DataSettingForm";
			this.ShowIcon = false;
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
		private System.Windows.Forms.Label lblDataStatus;
		private System.Windows.Forms.ComboBox cbxDataStatus;
		private System.Windows.Forms.Label lblServiceImplementationId;
		private System.Windows.Forms.TextBox tbxServiceImplementationId;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.TextBox tbxName;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.TextBox tbxDescription;
		private System.Windows.Forms.Label lblRemarks;
		private System.Windows.Forms.TextBox tbxRemarks;
		private System.Windows.Forms.DataGridView dgvDataProperty;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.DataGridViewTextBoxColumn colIndex;
		private System.Windows.Forms.DataGridViewTextBoxColumn colId;
		private System.Windows.Forms.DataGridViewTextBoxColumn colLocalId;
		private System.Windows.Forms.DataGridViewTextBoxColumn colName;
		private System.Windows.Forms.DataGridViewComboBoxColumn colStatus;
		private System.Windows.Forms.DataGridViewTextBoxColumn colRemarks;
	}
}