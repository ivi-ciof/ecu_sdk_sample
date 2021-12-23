
namespace CIOFContractSample_Factory
{
	partial class MainForm
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.txtIP = new System.Windows.Forms.TextBox();
			this.lblAddress = new System.Windows.Forms.Label();
			this.btnInitialSetting = new System.Windows.Forms.Button();
			this.btnStop = new System.Windows.Forms.Button();
			this.lblPollingRate = new System.Windows.Forms.Label();
			this.lblSecond = new System.Windows.Forms.Label();
			this.nudPollingRate = new System.Windows.Forms.NumericUpDown();
			this.btnStart = new System.Windows.Forms.Button();
			this.btnShowContract = new System.Windows.Forms.Button();
			this.btnShowCalendar = new System.Windows.Forms.Button();
			this.btnSendData = new System.Windows.Forms.Button();
			this.btnSendDeleteReq = new System.Windows.Forms.Button();
			this.btnHistory = new System.Windows.Forms.Button();
			this.btnDataList = new System.Windows.Forms.Button();
			this.btnShowService = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvEnvironmentData = new System.Windows.Forms.DataGridView();
			this.Temperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Humidity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TimeStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnExecuteEvent = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nudPollingRate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvEnvironmentData)).BeginInit();
			this.SuspendLayout();
			// 
			// txtIP
			// 
			this.txtIP.Location = new System.Drawing.Point(151, 29);
			this.txtIP.Name = "txtIP";
			this.txtIP.Size = new System.Drawing.Size(143, 19);
			this.txtIP.TabIndex = 2;
			this.txtIP.Text = "http://localhost:80";
			// 
			// lblAddress
			// 
			this.lblAddress.AutoSize = true;
			this.lblAddress.Location = new System.Drawing.Point(30, 32);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new System.Drawing.Size(41, 12);
			this.lblAddress.TabIndex = 0;
			this.lblAddress.Text = "アドレス";
			// 
			// btnInitialSetting
			// 
			this.btnInitialSetting.Location = new System.Drawing.Point(318, 16);
			this.btnInitialSetting.Name = "btnInitialSetting";
			this.btnInitialSetting.Size = new System.Drawing.Size(115, 44);
			this.btnInitialSetting.TabIndex = 0;
			this.btnInitialSetting.Text = "Initial Setting";
			this.btnInitialSetting.UseVisualStyleBackColor = true;
			this.btnInitialSetting.Click += new System.EventHandler(this.btnInitialSetting_Click);
			// 
			// btnStop
			// 
			this.btnStop.Location = new System.Drawing.Point(318, 203);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(115, 44);
			this.btnStop.TabIndex = 0;
			this.btnStop.Text = "Stop";
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// lblPollingRate
			// 
			this.lblPollingRate.AutoSize = true;
			this.lblPollingRate.Location = new System.Drawing.Point(30, 65);
			this.lblPollingRate.Name = "lblPollingRate";
			this.lblPollingRate.Size = new System.Drawing.Size(74, 12);
			this.lblPollingRate.TabIndex = 3;
			this.lblPollingRate.Text = "ポーリング周期";
			// 
			// lblSecond
			// 
			this.lblSecond.AutoSize = true;
			this.lblSecond.Location = new System.Drawing.Point(277, 65);
			this.lblSecond.Name = "lblSecond";
			this.lblSecond.Size = new System.Drawing.Size(17, 12);
			this.lblSecond.TabIndex = 5;
			this.lblSecond.Text = "秒";
			// 
			// nudPollingRate
			// 
			this.nudPollingRate.Location = new System.Drawing.Point(151, 63);
			this.nudPollingRate.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.nudPollingRate.Name = "nudPollingRate";
			this.nudPollingRate.Size = new System.Drawing.Size(120, 19);
			this.nudPollingRate.TabIndex = 4;
			this.nudPollingRate.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(449, 16);
			this.btnStart.Margin = new System.Windows.Forms.Padding(2);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(115, 44);
			this.btnStart.TabIndex = 0;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// btnShowContract
			// 
			this.btnShowContract.Location = new System.Drawing.Point(577, 79);
			this.btnShowContract.Margin = new System.Windows.Forms.Padding(2);
			this.btnShowContract.Name = "btnShowContract";
			this.btnShowContract.Size = new System.Drawing.Size(115, 44);
			this.btnShowContract.TabIndex = 0;
			this.btnShowContract.Text = "Show Contract";
			this.btnShowContract.UseVisualStyleBackColor = true;
			this.btnShowContract.Click += new System.EventHandler(this.btnShowContract_Click);
			// 
			// btnShowCalendar
			// 
			this.btnShowCalendar.Location = new System.Drawing.Point(701, 80);
			this.btnShowCalendar.Name = "btnShowCalendar";
			this.btnShowCalendar.Size = new System.Drawing.Size(114, 43);
			this.btnShowCalendar.TabIndex = 6;
			this.btnShowCalendar.Text = "Show Calendar";
			this.btnShowCalendar.UseVisualStyleBackColor = true;
			this.btnShowCalendar.Click += new System.EventHandler(this.btnShowCalendar_Click);
			// 
			// btnSendData
			// 
			this.btnSendData.Location = new System.Drawing.Point(318, 144);
			this.btnSendData.Name = "btnSendData";
			this.btnSendData.Size = new System.Drawing.Size(114, 43);
			this.btnSendData.TabIndex = 5;
			this.btnSendData.Text = "Send Data";
			this.btnSendData.UseVisualStyleBackColor = true;
			this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
			// 
			// btnSendDeleteReq
			// 
			this.btnSendDeleteReq.Location = new System.Drawing.Point(449, 143);
			this.btnSendDeleteReq.Margin = new System.Windows.Forms.Padding(2);
			this.btnSendDeleteReq.Name = "btnSendDeleteReq";
			this.btnSendDeleteReq.Size = new System.Drawing.Size(115, 44);
			this.btnSendDeleteReq.TabIndex = 4;
			this.btnSendDeleteReq.Text = "Latest Data Delete Req";
			this.btnSendDeleteReq.UseVisualStyleBackColor = true;
			this.btnSendDeleteReq.Click += new System.EventHandler(this.btnSendDeleteReq_Click);
			// 
			// btnHistory
			// 
			this.btnHistory.Location = new System.Drawing.Point(577, 143);
			this.btnHistory.Margin = new System.Windows.Forms.Padding(2);
			this.btnHistory.Name = "btnHistory";
			this.btnHistory.Size = new System.Drawing.Size(115, 44);
			this.btnHistory.TabIndex = 3;
			this.btnHistory.Text = "Show History";
			this.btnHistory.UseVisualStyleBackColor = true;
			this.btnHistory.Click += new System.EventHandler(this.btnShowHistory_Click);
			// 
			// btnDataList
			// 
			this.btnDataList.Location = new System.Drawing.Point(449, 79);
			this.btnDataList.Margin = new System.Windows.Forms.Padding(2);
			this.btnDataList.Name = "btnDataList";
			this.btnDataList.Size = new System.Drawing.Size(115, 44);
			this.btnDataList.TabIndex = 2;
			this.btnDataList.Text = "Show Data List";
			this.btnDataList.UseVisualStyleBackColor = true;
			this.btnDataList.Click += new System.EventHandler(this.btnDataImp_Click);
			// 
			// btnShowService
			// 
			this.btnShowService.Location = new System.Drawing.Point(318, 79);
			this.btnShowService.Margin = new System.Windows.Forms.Padding(2);
			this.btnShowService.Name = "btnShowService";
			this.btnShowService.Size = new System.Drawing.Size(115, 44);
			this.btnShowService.TabIndex = 1;
			this.btnShowService.Text = "Show Service";
			this.btnShowService.UseVisualStyleBackColor = true;
			this.btnShowService.Click += new System.EventHandler(this.btnShowService_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(149, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(119, 12);
			this.label1.TabIndex = 1;
			this.label1.Text = "例) http://localhost:80";
			// 
			// dgvEnvironmentData
			// 
			this.dgvEnvironmentData.AllowUserToAddRows = false;
			this.dgvEnvironmentData.AllowUserToDeleteRows = false;
			this.dgvEnvironmentData.AllowUserToResizeColumns = false;
			this.dgvEnvironmentData.AllowUserToResizeRows = false;
			this.dgvEnvironmentData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvEnvironmentData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Temperature,
            this.Humidity,
            this.TimeStamp});
			this.dgvEnvironmentData.Location = new System.Drawing.Point(28, 130);
			this.dgvEnvironmentData.Name = "dgvEnvironmentData";
			this.dgvEnvironmentData.RowHeadersVisible = false;
			this.dgvEnvironmentData.RowTemplate.Height = 21;
			this.dgvEnvironmentData.Size = new System.Drawing.Size(266, 117);
			this.dgvEnvironmentData.TabIndex = 14;
			// 
			// Temperature
			// 
			this.Temperature.HeaderText = "Temperature";
			this.Temperature.Name = "Temperature";
			this.Temperature.Width = 80;
			// 
			// Humidity
			// 
			this.Humidity.HeaderText = "Humidity";
			this.Humidity.Name = "Humidity";
			this.Humidity.Width = 80;
			// 
			// TimeStamp
			// 
			this.TimeStamp.HeaderText = "TimeStamp";
			this.TimeStamp.Name = "TimeStamp";
			this.TimeStamp.Width = 90;
			// 
			// btnExecuteEvent
			// 
			this.btnExecuteEvent.Location = new System.Drawing.Point(701, 145);
			this.btnExecuteEvent.Name = "btnExecuteEvent";
			this.btnExecuteEvent.Size = new System.Drawing.Size(113, 41);
			this.btnExecuteEvent.TabIndex = 15;
			this.btnExecuteEvent.Text = "Execute Event";
			this.btnExecuteEvent.UseVisualStyleBackColor = true;
			this.btnExecuteEvent.Click += new System.EventHandler(this.btnExecuteEvent_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(827, 272);
			this.Controls.Add(this.btnExecuteEvent);
			this.Controls.Add(this.btnStop);
			this.Controls.Add(this.btnDataList);
			this.Controls.Add(this.btnSendDeleteReq);
			this.Controls.Add(this.btnShowCalendar);
			this.Controls.Add(this.btnHistory);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.btnSendData);
			this.Controls.Add(this.dgvEnvironmentData);
			this.Controls.Add(this.btnInitialSetting);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnShowService);
			this.Controls.Add(this.btnShowContract);
			this.Controls.Add(this.nudPollingRate);
			this.Controls.Add(this.lblSecond);
			this.Controls.Add(this.lblPollingRate);
			this.Controls.Add(this.lblAddress);
			this.Controls.Add(this.txtIP);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FactorySensorSide";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.nudPollingRate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvEnvironmentData)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtIP;
		private System.Windows.Forms.Label lblAddress;
		private System.Windows.Forms.Button btnInitialSetting;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.Label lblPollingRate;
		private System.Windows.Forms.Label lblSecond;
		private System.Windows.Forms.NumericUpDown nudPollingRate;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnShowContract;
        private System.Windows.Forms.Button btnShowService;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDataList;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnSendDeleteReq;
		private System.Windows.Forms.DataGridView dgvEnvironmentData;
		private System.Windows.Forms.DataGridViewTextBoxColumn Temperature;
		private System.Windows.Forms.DataGridViewTextBoxColumn Humidity;
		private System.Windows.Forms.DataGridViewTextBoxColumn TimeStamp;
		private System.Windows.Forms.Button btnSendData;
		private System.Windows.Forms.Button btnShowCalendar;
		private System.Windows.Forms.Button btnExecuteEvent;
	}
}

