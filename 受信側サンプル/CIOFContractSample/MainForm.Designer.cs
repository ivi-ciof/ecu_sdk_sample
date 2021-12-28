
namespace CIOFContractSample
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
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.lblAddress = new System.Windows.Forms.Label();
			this.btnInitialSetting = new System.Windows.Forms.Button();
			this.btnStop = new System.Windows.Forms.Button();
			this.lblPollingRate = new System.Windows.Forms.Label();
			this.lblSecond = new System.Windows.Forms.Label();
			this.nudPollingRate = new System.Windows.Forms.NumericUpDown();
			this.btnStart = new System.Windows.Forms.Button();
			this.btnShowContract = new System.Windows.Forms.Button();
			this.btnShowEnvironmentData = new System.Windows.Forms.Button();
			this.btnSendRequest = new System.Windows.Forms.Button();
			this.gbxSaveType = new System.Windows.Forms.GroupBox();
			this.rbtnSaveFile = new System.Windows.Forms.RadioButton();
			this.rbtnDB = new System.Windows.Forms.RadioButton();
			this.btnShowServiceList = new System.Windows.Forms.Button();
			this.btnShowDataList = new System.Windows.Forms.Button();
			this.btnShowCalendar = new System.Windows.Forms.Button();
			this.btnShowHistory = new System.Windows.Forms.Button();
			this.btnDeleteData = new System.Windows.Forms.Button();
			this.lblFilePath = new System.Windows.Forms.Label();
			this.tbxSelect = new System.Windows.Forms.TextBox();
			this.btnSelect = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nudPollingRate)).BeginInit();
			this.gbxSaveType.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(120, 26);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(174, 19);
			this.txtAddress.TabIndex = 1;
			this.txtAddress.Text = "http://localhost";
			// 
			// lblAddress
			// 
			this.lblAddress.AutoSize = true;
			this.lblAddress.Location = new System.Drawing.Point(30, 29);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new System.Drawing.Size(41, 12);
			this.lblAddress.TabIndex = 0;
			this.lblAddress.Text = "アドレス";
			// 
			// btnInitialSetting
			// 
			this.btnInitialSetting.Location = new System.Drawing.Point(315, 13);
			this.btnInitialSetting.Name = "btnInitialSetting";
			this.btnInitialSetting.Size = new System.Drawing.Size(115, 44);
			this.btnInitialSetting.TabIndex = 6;
			this.btnInitialSetting.Text = "Initial Setting";
			this.btnInitialSetting.UseVisualStyleBackColor = true;
			this.btnInitialSetting.Click += new System.EventHandler(this.btnInitialSetting_Click);
			// 
			// btnStop
			// 
			this.btnStop.Location = new System.Drawing.Point(315, 210);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(115, 44);
			this.btnStop.TabIndex = 16;
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
			this.lblPollingRate.TabIndex = 2;
			this.lblPollingRate.Text = "ポーリング周期";
			// 
			// lblSecond
			// 
			this.lblSecond.AutoSize = true;
			this.lblSecond.Location = new System.Drawing.Point(277, 65);
			this.lblSecond.Name = "lblSecond";
			this.lblSecond.Size = new System.Drawing.Size(17, 12);
			this.lblSecond.TabIndex = 4;
			this.lblSecond.Text = "秒";
			// 
			// nudPollingRate
			// 
			this.nudPollingRate.Location = new System.Drawing.Point(151, 63);
			this.nudPollingRate.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.nudPollingRate.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.nudPollingRate.Name = "nudPollingRate";
			this.nudPollingRate.Size = new System.Drawing.Size(120, 19);
			this.nudPollingRate.TabIndex = 3;
			this.nudPollingRate.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(444, 13);
			this.btnStart.Margin = new System.Windows.Forms.Padding(2);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(115, 44);
			this.btnStart.TabIndex = 7;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// btnShowContract
			// 
			this.btnShowContract.Location = new System.Drawing.Point(568, 83);
			this.btnShowContract.Margin = new System.Windows.Forms.Padding(2);
			this.btnShowContract.Name = "btnShowContract";
			this.btnShowContract.Size = new System.Drawing.Size(115, 44);
			this.btnShowContract.TabIndex = 10;
			this.btnShowContract.Text = "Show Contract";
			this.btnShowContract.UseVisualStyleBackColor = true;
			this.btnShowContract.Click += new System.EventHandler(this.btnShowContract_Click);
			// 
			// btnShowEnvironmentData
			// 
			this.btnShowEnvironmentData.Location = new System.Drawing.Point(315, 150);
			this.btnShowEnvironmentData.Name = "btnShowEnvironmentData";
			this.btnShowEnvironmentData.Size = new System.Drawing.Size(115, 44);
			this.btnShowEnvironmentData.TabIndex = 12;
			this.btnShowEnvironmentData.Text = "Show Environment Data";
			this.btnShowEnvironmentData.UseVisualStyleBackColor = true;
			this.btnShowEnvironmentData.Click += new System.EventHandler(this.btnShowEnvironmentData_Click);
			// 
			// btnSendRequest
			// 
			this.btnSendRequest.Location = new System.Drawing.Point(444, 150);
			this.btnSendRequest.Name = "btnSendRequest";
			this.btnSendRequest.Size = new System.Drawing.Size(115, 43);
			this.btnSendRequest.TabIndex = 13;
			this.btnSendRequest.Text = "Send Request";
			this.btnSendRequest.UseVisualStyleBackColor = true;
			this.btnSendRequest.Click += new System.EventHandler(this.btnSendRequest_Click);
			// 
			// gbxSaveType
			// 
			this.gbxSaveType.Controls.Add(this.rbtnSaveFile);
			this.gbxSaveType.Controls.Add(this.rbtnDB);
			this.gbxSaveType.Location = new System.Drawing.Point(33, 100);
			this.gbxSaveType.Name = "gbxSaveType";
			this.gbxSaveType.Size = new System.Drawing.Size(261, 53);
			this.gbxSaveType.TabIndex = 5;
			this.gbxSaveType.TabStop = false;
			this.gbxSaveType.Text = "Save Type";
			// 
			// rbtnSaveFile
			// 
			this.rbtnSaveFile.AutoSize = true;
			this.rbtnSaveFile.Location = new System.Drawing.Point(137, 18);
			this.rbtnSaveFile.Name = "rbtnSaveFile";
			this.rbtnSaveFile.Size = new System.Drawing.Size(42, 16);
			this.rbtnSaveFile.TabIndex = 1;
			this.rbtnSaveFile.Text = "File";
			this.rbtnSaveFile.UseVisualStyleBackColor = true;
			// 
			// rbtnDB
			// 
			this.rbtnDB.AutoSize = true;
			this.rbtnDB.Checked = true;
			this.rbtnDB.Location = new System.Drawing.Point(27, 18);
			this.rbtnDB.Name = "rbtnDB";
			this.rbtnDB.Size = new System.Drawing.Size(39, 16);
			this.rbtnDB.TabIndex = 0;
			this.rbtnDB.TabStop = true;
			this.rbtnDB.Text = "DB";
			this.rbtnDB.UseVisualStyleBackColor = true;
			// 
			// btnShowServiceList
			// 
			this.btnShowServiceList.Location = new System.Drawing.Point(315, 83);
			this.btnShowServiceList.Name = "btnShowServiceList";
			this.btnShowServiceList.Size = new System.Drawing.Size(115, 44);
			this.btnShowServiceList.TabIndex = 8;
			this.btnShowServiceList.Text = "Show Service List";
			this.btnShowServiceList.UseVisualStyleBackColor = true;
			this.btnShowServiceList.Click += new System.EventHandler(this.btnShowServiceList_Click);
			// 
			// btnShowDataList
			// 
			this.btnShowDataList.Location = new System.Drawing.Point(444, 83);
			this.btnShowDataList.Name = "btnShowDataList";
			this.btnShowDataList.Size = new System.Drawing.Size(114, 44);
			this.btnShowDataList.TabIndex = 9;
			this.btnShowDataList.Text = "Show Data List";
			this.btnShowDataList.UseVisualStyleBackColor = true;
			this.btnShowDataList.Click += new System.EventHandler(this.btnShowDataList_Click);
			// 
			// btnShowCalendar
			// 
			this.btnShowCalendar.Location = new System.Drawing.Point(692, 83);
			this.btnShowCalendar.Name = "btnShowCalendar";
			this.btnShowCalendar.Size = new System.Drawing.Size(115, 44);
			this.btnShowCalendar.TabIndex = 11;
			this.btnShowCalendar.Text = "Show Calendar";
			this.btnShowCalendar.UseVisualStyleBackColor = true;
			this.btnShowCalendar.Click += new System.EventHandler(this.btnShowCalendar_Click);
			// 
			// btnShowHistory
			// 
			this.btnShowHistory.Location = new System.Drawing.Point(568, 150);
			this.btnShowHistory.Name = "btnShowHistory";
			this.btnShowHistory.Size = new System.Drawing.Size(114, 44);
			this.btnShowHistory.TabIndex = 14;
			this.btnShowHistory.Text = "Show History";
			this.btnShowHistory.UseVisualStyleBackColor = true;
			this.btnShowHistory.Click += new System.EventHandler(this.btnShowHistory_Click);
			// 
			// btnDeleteData
			// 
			this.btnDeleteData.Location = new System.Drawing.Point(692, 152);
			this.btnDeleteData.Name = "btnDeleteData";
			this.btnDeleteData.Size = new System.Drawing.Size(114, 41);
			this.btnDeleteData.TabIndex = 15;
			this.btnDeleteData.Text = "Delete Data";
			this.btnDeleteData.UseVisualStyleBackColor = true;
			this.btnDeleteData.Click += new System.EventHandler(this.btnDeleteData_Click);
			// 
			// lblFilePath
			// 
			this.lblFilePath.AutoSize = true;
			this.lblFilePath.Location = new System.Drawing.Point(36, 166);
			this.lblFilePath.Name = "lblFilePath";
			this.lblFilePath.Size = new System.Drawing.Size(47, 12);
			this.lblFilePath.TabIndex = 17;
			this.lblFilePath.Text = "FilePath";
			// 
			// tbxSelect
			// 
			this.tbxSelect.Location = new System.Drawing.Point(89, 163);
			this.tbxSelect.Name = "tbxSelect";
			this.tbxSelect.Size = new System.Drawing.Size(145, 19);
			this.tbxSelect.TabIndex = 18;
			// 
			// btnSelect
			// 
			this.btnSelect.Location = new System.Drawing.Point(240, 162);
			this.btnSelect.Name = "btnSelect";
			this.btnSelect.Size = new System.Drawing.Size(54, 20);
			this.btnSelect.TabIndex = 19;
			this.btnSelect.Text = "select";
			this.btnSelect.UseVisualStyleBackColor = true;
			this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(819, 277);
			this.Controls.Add(this.btnSelect);
			this.Controls.Add(this.tbxSelect);
			this.Controls.Add(this.lblFilePath);
			this.Controls.Add(this.btnDeleteData);
			this.Controls.Add(this.btnShowHistory);
			this.Controls.Add(this.btnShowCalendar);
			this.Controls.Add(this.btnShowDataList);
			this.Controls.Add(this.btnShowServiceList);
			this.Controls.Add(this.gbxSaveType);
			this.Controls.Add(this.btnSendRequest);
			this.Controls.Add(this.btnShowEnvironmentData);
			this.Controls.Add(this.btnShowContract);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.nudPollingRate);
			this.Controls.Add(this.lblSecond);
			this.Controls.Add(this.lblPollingRate);
			this.Controls.Add(this.btnStop);
			this.Controls.Add(this.btnInitialSetting);
			this.Controls.Add(this.lblAddress);
			this.Controls.Add(this.txtAddress);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "OfficeSide";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.nudPollingRate)).EndInit();
			this.gbxSaveType.ResumeLayout(false);
			this.gbxSaveType.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.Label lblAddress;
		private System.Windows.Forms.Button btnInitialSetting;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.Label lblPollingRate;
		private System.Windows.Forms.Label lblSecond;
		private System.Windows.Forms.NumericUpDown nudPollingRate;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnShowContract;
		private System.Windows.Forms.Button btnShowEnvironmentData;
		private System.Windows.Forms.Button btnSendRequest;
		private System.Windows.Forms.GroupBox gbxSaveType;
		private System.Windows.Forms.RadioButton rbtnSaveFile;
		private System.Windows.Forms.RadioButton rbtnDB;
		private System.Windows.Forms.Button btnShowServiceList;
		private System.Windows.Forms.Button btnShowDataList;
		private System.Windows.Forms.Button btnShowCalendar;
		private System.Windows.Forms.Button btnShowHistory;
		private System.Windows.Forms.Button btnDeleteData;
		private System.Windows.Forms.Label lblFilePath;
		private System.Windows.Forms.TextBox tbxSelect;
		private System.Windows.Forms.Button btnSelect;
	}
}

