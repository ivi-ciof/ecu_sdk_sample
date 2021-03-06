using CIOF_SDK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIOFContractSample_Factory
{
	public partial class CalendarForm : Form
	{
		/// <summary>
		/// コントローラモデル
		/// </summary>
		ControllerModel controllerModel = null;
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public CalendarForm()
		{
			InitializeComponent();
		}
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="controller">コントローラモデル</param>
		public CalendarForm(ControllerModel controller)
		{
			InitializeComponent();

			this.controllerModel = controller;

			RefreshDGV();
		}
		/// <summary>
		/// データグリッドビュー更新
		/// </summary>
		private void RefreshDGV()
		{
			foreach (var calendarInfo in controllerModel.CalendarRoot.calendars)
			{
				var daysOfWeek = calendarInfo.days_of_week != null ? string.Join(",", calendarInfo.days_of_week) : null;
				var weeksOfMonth = calendarInfo.weeks_of_month != null ? string.Join(",", calendarInfo.weeks_of_month) : null;
				dgvCalendar.Rows.Add(calendarInfo.id, calendarInfo.name, calendarInfo.start_date, daysOfWeek, weeksOfMonth, calendarInfo.interval, calendarInfo.interval_type, calendarInfo.end_date, calendarInfo.number_of_occurences, calendarInfo.recurrence_time_zone);
			}
		}
		/// <summary>
		/// refreshボタンクリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnRefresh_Click(object sender, EventArgs e)
		{
			controllerModel.RestartCalendarEvent();
			dgvCalendar.Rows.Clear();
			RefreshDGV();
		}
	}
}
