using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class FormClock : Form
    {
        DateTime stopWatch;
        double stopWatchCount = 0;
        bool stopWatchRunning = false;
        bool stopWatchPaused = false;

        public FormClock()
        {
            InitializeComponent();
        }

        private void FormClock_Load(object sender, EventArgs e)
        {
            this.updateClock();
            this.resizeElements();
            this.timer.Enabled = true;

            this.monthCalendar.SetDate(DateTime.Now);

            this.Height = 200;
            this.Width = 430;

            TimeZone localZone = TimeZone.CurrentTimeZone;

            DaylightTime daylight =
            localZone.GetDaylightChanges(DateTime.Now.Year);

            
            this.labelInfo.Text = 
                "Timezone: "+localZone.StandardName + 
                " \nDaylight saving time name: " + localZone.DaylightName + 
                " \nDaylight saving time: " + localZone.IsDaylightSavingTime(DateTime.Now)+

                " \nDaylight start: " + daylight.Start.ToString() +
                " \nDaylight end: " + daylight.End.ToString() +
                " \nDelta: " + daylight.Delta +

                " \nUTC time: " + localZone.ToUniversalTime(DateTime.Now) +
                " \nUTC offset: " + localZone.GetUtcOffset(DateTime.Now)
                ;
        }

        public string getTime() {
            DateTime localDate = DateTime.Now;

            return 
                localDate.Hour.ToString().PadLeft(2, '0') + ":"+
                localDate.Minute.ToString().PadLeft(2, '0') + ":"+
                localDate.Second.ToString().PadLeft(2, '0');

        }

        public string getDate()
        {
            DateTime localDate = DateTime.Now;

            return
                localDate.Year.ToString() + "-" +
                localDate.Month.ToString().PadLeft(2, '0') + "-" +
                localDate.Day.ToString().PadLeft(2, '0') + " " +
                localDate.ToString("MMMM") + ", " + 
                localDate.ToString("dddd");

        }

        public string getDay()
        {
            return "";

        }

        public void updateClock() {
            string time = this.getTime();

            if (this.Text != time) {
                this.Text = time;
                labelClock.Text = time;
                labelDate.Text = this.getDate();
                labelDay.Text = this.getDay();
            }
        }

        public void updateStopWatch()
        {
            if (this.stopWatchRunning) {
                double diff = this.stopWatchCount + DateTime.Now.Subtract(this.stopWatch).TotalSeconds;
                double minutest = (int)diff / 60;
                double seconds = diff - (minutest * 60);
                this.labelStopWatch.Text = minutest.ToString() + ":" + seconds.ToString();
            }
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.updateClock();
            this.updateStopWatch();
        }

        private void contextMenu_Opening(object sender, CancelEventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void alwaysOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TopMost = !this.TopMost;
        }


        public void resizeElements() {
            labelClock.Font = new Font(labelClock.Font.FontFamily, this.Width / 7);
            labelDate.Font = new Font(labelDate.Font.FontFamily, this.Width / 20);
            labelDay.Font = new Font(labelDay.Font.FontFamily, this.Width / 20);

            labelDate.Top = labelClock.Top + labelClock.Height + 10;
            labelDay.Top = labelClock.Top + labelClock.Height + 10;
            labelDay.Left = labelClock.Left + labelClock.Width - labelDay.Width;

            panelTools.Top = labelDate.Top + labelDate.Height + 10;
        }

        private void FormClock_Resize(object sender, EventArgs e)
        {
            this.resizeElements();
        }

        private void buttonStartStopWatch_Click(object sender, EventArgs e)
        {
            if (!this.stopWatchRunning) {
                this.stopWatch = DateTime.Now;
                this.stopWatchRunning = true;
            }

            if (this.stopWatchRunning)
            {
                
            }

            if (this.stopWatchPaused)
            {

            }
        }

        private void buttonPauseStopWatch_Click(object sender, EventArgs e)
        {
            if (this.stopWatchRunning) {
                this.stopWatchRunning = false;
                this.stopWatchPaused = true;
                this.stopWatchCount += DateTime.Now.Subtract(this.stopWatch).TotalSeconds;
            }
        }

        private void buttonResertStopWatch_Click(object sender, EventArgs e)
        {
            if (this.stopWatchRunning || this.stopWatchPaused)
            {
                this.stopWatchRunning = false;
                this.stopWatchPaused = false;
                this.stopWatchCount = 0;
                this.stopWatch = DateTime.Now;
                this.labelStopWatch.Text = "0";
            }
            
        }
    }
}
