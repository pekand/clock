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
    public partial class FormStopWatch : Form
    {
        DateTime stopWatch;
        double stopWatchCount = 0;
        bool stopWatchRunning = false;
        bool stopWatchPaused = false;

        public FormStopWatch()
        {
            InitializeComponent();
        }

        public void updateStopWatch()
        {
            if (this.stopWatchRunning)
            {
                double diff = this.stopWatchCount + DateTime.Now.Subtract(this.stopWatch).TotalSeconds;
                double minutest = (int)diff / 60;
                double seconds = diff - (minutest * 60);
                this.labelStopWatch.Text = minutest.ToString() + ":" + seconds.ToString();
                this.Text = this.labelStopWatch.Text;
            }

        }

        private void buttonStartStopWatch_Click(object sender, EventArgs e)
        {
            if (!this.stopWatchRunning)
            {
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
            if (this.stopWatchRunning)
            {
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

        private void timer_Tick(object sender, EventArgs e)
        {
            this.updateStopWatch();
        }
    }
}
