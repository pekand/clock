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

        public FormClock()
        {
            InitializeComponent();
        }

        private void FormClock_Load(object sender, EventArgs e)
        {
            this.updateClock();
            this.resizeElements();
            this.timer.Enabled = true;

            this.Height = 200;
            this.Width = 430;

            DoubleBuffered = true;

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
                //labelClock.Text = time;
                //labelDate.Text = this.getDate();
                //labelDay.Text = this.getDay();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {

            string time = this.getTime();
            string date = this.getDate(); ;
            if (this.time != time || this.date != date)
            {
                this.time = time;
                this.date = date;

                this.Invalidate();
            }

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
            //labelClock.Font = new Font(labelClock.Font.FontFamily, this.Width / 7);
            //labelDate.Font = new Font(labelDate.Font.FontFamily, this.Width / 20);
            //labelDay.Font = new Font(labelDay.Font.FontFamily, this.Width / 20);

            //labelDate.Top = labelClock.Top + labelClock.Height + 10;
            //labelDay.Top = labelClock.Top + labelClock.Height + 10;
            //labelDay.Left = labelClock.Left + labelClock.Width - labelDay.Width;
        }

        private void FormClock_Resize(object sender, EventArgs e)
        {
            //this.resizeElements();

            //this.Invalidate();

            this.Invalidate();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new FormInfo()).Show();
        }

        private void stopWatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new FormStopWatch()).Show();
        }

        private void calendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new FormCalendar()).Show();
        }



        private SizeF measureString(string text, Font font) {
            Graphics g = this.CreateGraphics();
            SizeF stringSize = new SizeF();
            return g.MeasureString(text, font);
        }



        private Font calculateFontSize(string text, int width) {

            SizeF stringSize = new SizeF();

            int fontSize = 8;

            Font stringFont = new Font("Consolas", fontSize);

            stringFont = new Font("Consolas", fontSize);
            stringSize = this.measureString(text, stringFont);

            while (fontSize < 1000 &&  stringSize.Width < this.Width)
            {
                fontSize++;
                stringFont = new Font("Consolas", fontSize);
                stringSize = this.measureString(text, stringFont);
            }

            stringFont = new Font("Consolas", fontSize-1);
            stringSize = this.measureString(text, stringFont);

            return stringFont;
        }


        private int lastTimeWidth = 0;
        private Font lastTimeFont = null;
        private Font calculateTimeFontSize(string text, int width)
        {
            if (width == lastTimeWidth) {
                return lastTimeFont;
            }

            lastTimeWidth = width;

            this.lastTimeFont =  this.calculateFontSize(text, this.Width);

            return this.lastTimeFont;
        }

        private int lastDateWidth = 0;
        private Font lastDateFont = null;

        private Font calculateDateFontSize(string text, int width)
        {
            if (width == lastDateWidth)
            {
                return lastDateFont;
            }

            lastDateWidth = width;

            this.lastDateFont = this.calculateFontSize(text, this.Width);

            return this.lastDateFont;
        }



        private int lastWidth = 0;
        private string time = "";
        private string date = "";

        private void FormClock_Paint(object sender, PaintEventArgs e)
        {

            Font timeFont = this.calculateTimeFontSize(time, this.Width);
            e.Graphics.DrawString(this.time, timeFont, Brushes.Black, new PointF(0, 0));

            SizeF timeSize = measureString(this.time, timeFont);

            Font dateFont = this.calculateDateFontSize(this.date, this.Width);
            e.Graphics.DrawString(this.date, dateFont, Brushes.Black, new PointF(0, timeSize.Height));

        }

        private void FormClock_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(this.date+" "+this.time);
        }

        private void copyToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.date + " " + this.time);
        }
    }
}
