﻿
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colContractType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSendType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colServiceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colServiceLocalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colProcessId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colProcessLocalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colEventId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colEventLocalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeColumns = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colContractType,
            this.colSendType,
            this.colServiceId,
            this.colServiceLocalId,
            this.colProcessId,
            this.colProcessLocalId,
            this.colEventId,
            this.colEventLocalId});
			this.dataGridView1.Location = new System.Drawing.Point(24, 21);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 27;
			this.dataGridView1.Size = new System.Drawing.Size(924, 216);
			this.dataGridView1.TabIndex = 0;
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
			// ContractForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(990, 271);
			this.Controls.Add(this.dataGridView1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ContractForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ContractForm";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn colId;
		private System.Windows.Forms.DataGridViewTextBoxColumn colContractType;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSendType;
		private System.Windows.Forms.DataGridViewTextBoxColumn colServiceId;
		private System.Windows.Forms.DataGridViewTextBoxColumn colServiceLocalId;
		private System.Windows.Forms.DataGridViewTextBoxColumn colProcessId;
		private System.Windows.Forms.DataGridViewTextBoxColumn colProcessLocalId;
		private System.Windows.Forms.DataGridViewTextBoxColumn colEventId;
		private System.Windows.Forms.DataGridViewTextBoxColumn colEventLocalId;
	}
}