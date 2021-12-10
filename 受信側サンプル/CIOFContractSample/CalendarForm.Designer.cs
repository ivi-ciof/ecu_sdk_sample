
namespace CIOFContractSample
{
	partial class CalendarForm
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
			this.dgvCalendar = new System.Windows.Forms.DataGridView();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCalendarName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDaysOfWeek = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colWeeksOfMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colInterval = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colIntervalType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colNumberOfOccurences = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colTimezone = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvCalendar)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvCalendar
			// 
			this.dgvCalendar.AllowUserToAddRows = false;
			this.dgvCalendar.AllowUserToDeleteRows = false;
			this.dgvCalendar.AllowUserToResizeColumns = false;
			this.dgvCalendar.AllowUserToResizeRows = false;
			this.dgvCalendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCalendar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colCalendarName,
            this.colStartDate,
            this.colDaysOfWeek,
            this.colWeeksOfMonth,
            this.colInterval,
            this.colIntervalType,
            this.colEndDate,
            this.colNumberOfOccurences,
            this.colTimezone});
			this.dgvCalendar.Location = new System.Drawing.Point(12, 55);
			this.dgvCalendar.Name = "dgvCalendar";
			this.dgvCalendar.RowHeadersVisible = false;
			this.dgvCalendar.RowTemplate.Height = 21;
			this.dgvCalendar.Size = new System.Drawing.Size(1088, 426);
			this.dgvCalendar.TabIndex = 0;
			// 
			// btnRefresh
			// 
			this.btnRefresh.Location = new System.Drawing.Point(12, 12);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(74, 24);
			this.btnRefresh.TabIndex = 1;
			this.btnRefresh.Text = "refresh";
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
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
			// colCalendarName
			// 
			this.colCalendarName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
			this.colCalendarName.DefaultCellStyle = dataGridViewCellStyle2;
			this.colCalendarName.HeaderText = "Name";
			this.colCalendarName.Name = "colCalendarName";
			this.colCalendarName.ReadOnly = true;
			this.colCalendarName.Width = 59;
			// 
			// colStartDate
			// 
			this.colStartDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
			this.colStartDate.DefaultCellStyle = dataGridViewCellStyle3;
			this.colStartDate.HeaderText = "StartDate";
			this.colStartDate.Name = "colStartDate";
			this.colStartDate.ReadOnly = true;
			this.colStartDate.Width = 79;
			// 
			// colDaysOfWeek
			// 
			this.colDaysOfWeek.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
			this.colDaysOfWeek.DefaultCellStyle = dataGridViewCellStyle4;
			this.colDaysOfWeek.HeaderText = "DaysOfWeek";
			this.colDaysOfWeek.Name = "colDaysOfWeek";
			this.colDaysOfWeek.ReadOnly = true;
			this.colDaysOfWeek.Width = 95;
			// 
			// colWeeksOfMonth
			// 
			this.colWeeksOfMonth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
			this.colWeeksOfMonth.DefaultCellStyle = dataGridViewCellStyle5;
			this.colWeeksOfMonth.HeaderText = "WeeksOfMonth";
			this.colWeeksOfMonth.Name = "colWeeksOfMonth";
			this.colWeeksOfMonth.ReadOnly = true;
			this.colWeeksOfMonth.Width = 106;
			// 
			// colInterval
			// 
			this.colInterval.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.Silver;
			this.colInterval.DefaultCellStyle = dataGridViewCellStyle6;
			this.colInterval.HeaderText = "Interval";
			this.colInterval.Name = "colInterval";
			this.colInterval.ReadOnly = true;
			this.colInterval.Width = 68;
			// 
			// colIntervalType
			// 
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.Silver;
			this.colIntervalType.DefaultCellStyle = dataGridViewCellStyle7;
			this.colIntervalType.HeaderText = "IntervalType";
			this.colIntervalType.Name = "colIntervalType";
			this.colIntervalType.ReadOnly = true;
			// 
			// colEndDate
			// 
			this.colEndDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.Silver;
			this.colEndDate.DefaultCellStyle = dataGridViewCellStyle8;
			this.colEndDate.HeaderText = "EndDate";
			this.colEndDate.Name = "colEndDate";
			this.colEndDate.ReadOnly = true;
			this.colEndDate.Width = 73;
			// 
			// colNumberOfOccurences
			// 
			this.colNumberOfOccurences.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.Silver;
			this.colNumberOfOccurences.DefaultCellStyle = dataGridViewCellStyle9;
			this.colNumberOfOccurences.HeaderText = "NumberOfOccurences";
			this.colNumberOfOccurences.Name = "colNumberOfOccurences";
			this.colNumberOfOccurences.ReadOnly = true;
			this.colNumberOfOccurences.Width = 141;
			// 
			// colTimezone
			// 
			this.colTimezone.HeaderText = "Timezone";
			this.colTimezone.Name = "colTimezone";
			this.colTimezone.ReadOnly = true;
			// 
			// CalendarForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1121, 493);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.dgvCalendar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "CalendarForm";
			this.Text = "CalendarForn";
			((System.ComponentModel.ISupportInitialize)(this.dgvCalendar)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvCalendar;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.DataGridViewTextBoxColumn colId;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCalendarName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colStartDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDaysOfWeek;
		private System.Windows.Forms.DataGridViewTextBoxColumn colWeeksOfMonth;
		private System.Windows.Forms.DataGridViewTextBoxColumn colInterval;
		private System.Windows.Forms.DataGridViewTextBoxColumn colIntervalType;
		private System.Windows.Forms.DataGridViewTextBoxColumn colEndDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn colNumberOfOccurences;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTimezone;
	}
}