using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class FormClock : Form
    {
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

            this.Text = time;
            labelClock.Text = time;

            labelDate.Text = this.getDate();

            labelDay.Text = this.getDay();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.updateClock();
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

            monthCalendar.Top = labelDate.Top + labelDate.Height + 10;
        }

        private void FormClock_Resize(object sender, EventArgs e)
        {
            this.resizeElements();
        }

        
    }
}
