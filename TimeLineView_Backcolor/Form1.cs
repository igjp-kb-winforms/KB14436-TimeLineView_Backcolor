using Infragistics.Win.UltraWinSchedule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeLineView_Backcolor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //ultraTimelineView1の設定
            ultraTimelineView1.EnsureDateTimeVisible(new DateTime(2024, 1, 1));

            //Timeslot intervalの設定
            DateInterval dateInterval = new DateInterval(1, DateIntervalUnits.Days);
            dateInterval.HeaderTextFormat = "MM/dd";
            this.ultraTimelineView1.AdditionalIntervals.Add(dateInterval); 
            DateInterval datePInterval = new DateInterval(1, DateIntervalUnits.Days);
            datePInterval.HeaderTextFormat = "ddd";
            this.ultraTimelineView1.PrimaryInterval = datePInterval;

            // UltraCalendarInfo を TimeLineView コントロールに指定する
            this.ultraTimelineView1.CalendarInfo = this.ultraCalendarInfo1;
            // UltraCalendarLook を TimeLineView コントロールに指定する
            this.ultraTimelineView1.CalendarLook = this.ultraCalendarLook1;

            //特定の日にちの背景色を変更する
            ultraCalendarLook1.DaysOfYearLook[(int)YearMonthEnum.January, 5].Appearance.BackColor = Color.Red;
            ultraCalendarLook1.DaysOfYearLook[(int)YearMonthEnum.January, 10].Appearance.BackColor = Color.Blue;



            //ultraTimelineView2の設定
            ultraTimelineView2.EnsureDateTimeVisible(new DateTime(2024, 1, 1));

            //Timeslot intervalの設定
            DateInterval dateInterval2 = new DateInterval(1, DateIntervalUnits.Days);
            dateInterval2.HeaderTextFormat = "MM/dd";
            this.ultraTimelineView2.AdditionalIntervals.Add(dateInterval2); 
            DateInterval datePInterval2 = new DateInterval(1, DateIntervalUnits.Days);
            datePInterval2.HeaderTextFormat = "ddd";
            this.ultraTimelineView2.PrimaryInterval = datePInterval2;

            // UltraCalendarInfo を TimeLineView コントロールに指定する
            this.ultraTimelineView2.CalendarInfo = this.ultraCalendarInfo2;
            // UltraCalendarLook を TimeLineView コントロールに指定する
            this.ultraTimelineView2.CalendarLook = this.ultraCalendarLook2;

            //特定の曜日の背景色を変更する
            ultraCalendarLook2.DaysOfWeekLook[DayOfWeekEnum.Wednesday].Appearance.BackColor = Color.Green;
        }
    }
}
