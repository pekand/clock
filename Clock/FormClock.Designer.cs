
namespace Clock
{
    partial class FormClock
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClock));
            this.labelClock = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelDay = new System.Windows.Forms.Label();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTools = new System.Windows.Forms.Panel();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.buttonStartStopWatch = new System.Windows.Forms.Button();
            this.labelStopWatch = new System.Windows.Forms.Label();
            this.buttonPauseStopWatch = new System.Windows.Forms.Button();
            this.buttonResertStopWatch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelStopWatchHeader = new System.Windows.Forms.Label();
            this.labelTimerHeare = new System.Windows.Forms.Label();
            this.buttonStartTimer = new System.Windows.Forms.Button();
            this.labelTimer = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.contextMenu.SuspendLayout();
            this.panelTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelClock
            // 
            this.labelClock.AutoSize = true;
            this.labelClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClock.Location = new System.Drawing.Point(12, 9);
            this.labelClock.Name = "labelClock";
            this.labelClock.Size = new System.Drawing.Size(417, 108);
            this.labelClock.TabIndex = 0;
            this.labelClock.Text = "00:00:00";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(24, 130);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(163, 33);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "2021-01-01";
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDay.Location = new System.Drawing.Point(311, 130);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(118, 33);
            this.labelDay.TabIndex = 2;
            this.labelDay.Text = "Monday";
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alwaysOnTopToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(150, 48);
            this.contextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenu_Opening);
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
            this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.alwaysOnTopToolStripMenuItem.Text = "Always on top";
            this.alwaysOnTopToolStripMenuItem.Click += new System.EventHandler(this.alwaysOnTopToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // panelTools
            // 
            this.panelTools.Controls.Add(this.labelInfo);
            this.panelTools.Controls.Add(this.labelTimer);
            this.panelTools.Controls.Add(this.buttonStartTimer);
            this.panelTools.Controls.Add(this.labelTimerHeare);
            this.panelTools.Controls.Add(this.labelStopWatchHeader);
            this.panelTools.Controls.Add(this.textBox1);
            this.panelTools.Controls.Add(this.buttonResertStopWatch);
            this.panelTools.Controls.Add(this.buttonPauseStopWatch);
            this.panelTools.Controls.Add(this.labelStopWatch);
            this.panelTools.Controls.Add(this.buttonStartStopWatch);
            this.panelTools.Controls.Add(this.monthCalendar);
            this.panelTools.Location = new System.Drawing.Point(12, 184);
            this.panelTools.Name = "panelTools";
            this.panelTools.Size = new System.Drawing.Size(1208, 373);
            this.panelTools.TabIndex = 7;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(0, 0);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 6;
            // 
            // buttonStartStopWatch
            // 
            this.buttonStartStopWatch.Location = new System.Drawing.Point(412, 4);
            this.buttonStartStopWatch.Name = "buttonStartStopWatch";
            this.buttonStartStopWatch.Size = new System.Drawing.Size(72, 34);
            this.buttonStartStopWatch.TabIndex = 7;
            this.buttonStartStopWatch.Text = "Start";
            this.buttonStartStopWatch.UseVisualStyleBackColor = true;
            this.buttonStartStopWatch.Click += new System.EventHandler(this.buttonStartStopWatch_Click);
            // 
            // labelStopWatch
            // 
            this.labelStopWatch.AutoSize = true;
            this.labelStopWatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStopWatch.Location = new System.Drawing.Point(642, 5);
            this.labelStopWatch.Name = "labelStopWatch";
            this.labelStopWatch.Size = new System.Drawing.Size(31, 33);
            this.labelStopWatch.TabIndex = 8;
            this.labelStopWatch.Text = "0";
            // 
            // buttonPauseStopWatch
            // 
            this.buttonPauseStopWatch.Location = new System.Drawing.Point(490, 5);
            this.buttonPauseStopWatch.Name = "buttonPauseStopWatch";
            this.buttonPauseStopWatch.Size = new System.Drawing.Size(70, 33);
            this.buttonPauseStopWatch.TabIndex = 9;
            this.buttonPauseStopWatch.Text = "Pause";
            this.buttonPauseStopWatch.UseVisualStyleBackColor = true;
            this.buttonPauseStopWatch.Click += new System.EventHandler(this.buttonPauseStopWatch_Click);
            // 
            // buttonResertStopWatch
            // 
            this.buttonResertStopWatch.Location = new System.Drawing.Point(566, 5);
            this.buttonResertStopWatch.Name = "buttonResertStopWatch";
            this.buttonResertStopWatch.Size = new System.Drawing.Size(70, 33);
            this.buttonResertStopWatch.TabIndex = 10;
            this.buttonResertStopWatch.Text = "Reset";
            this.buttonResertStopWatch.UseVisualStyleBackColor = true;
            this.buttonResertStopWatch.Click += new System.EventHandler(this.buttonResertStopWatch_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(357, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 49);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "00:00";
            // 
            // labelStopWatchHeader
            // 
            this.labelStopWatchHeader.AutoSize = true;
            this.labelStopWatchHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStopWatchHeader.Location = new System.Drawing.Point(239, 4);
            this.labelStopWatchHeader.Name = "labelStopWatchHeader";
            this.labelStopWatchHeader.Size = new System.Drawing.Size(167, 37);
            this.labelStopWatchHeader.TabIndex = 12;
            this.labelStopWatchHeader.Text = "Stopwatch";
            // 
            // labelTimerHeare
            // 
            this.labelTimerHeare.AutoSize = true;
            this.labelTimerHeare.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimerHeare.Location = new System.Drawing.Point(239, 89);
            this.labelTimerHeare.Name = "labelTimerHeare";
            this.labelTimerHeare.Size = new System.Drawing.Size(112, 42);
            this.labelTimerHeare.TabIndex = 13;
            this.labelTimerHeare.Text = "Timer";
            // 
            // buttonStartTimer
            // 
            this.buttonStartTimer.Location = new System.Drawing.Point(535, 89);
            this.buttonStartTimer.Name = "buttonStartTimer";
            this.buttonStartTimer.Size = new System.Drawing.Size(75, 49);
            this.buttonStartTimer.TabIndex = 14;
            this.buttonStartTimer.Text = "Start";
            this.buttonStartTimer.UseVisualStyleBackColor = true;
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimer.Location = new System.Drawing.Point(616, 92);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(39, 42);
            this.labelTimer.TabIndex = 15;
            this.labelTimer.Text = "0";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(15, 187);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(35, 13);
            this.labelInfo.TabIndex = 16;
            this.labelInfo.Text = "label1";
            // 
            // FormClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 165);
            this.ContextMenuStrip = this.contextMenu;
            this.Controls.Add(this.panelTools);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelClock);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormClock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "00:00:00";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.FormClock_Load);
            this.Resize += new System.EventHandler(this.FormClock_Resize);
            this.contextMenu.ResumeLayout(false);
            this.panelTools.ResumeLayout(false);
            this.panelTools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelClock;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
        private System.Windows.Forms.Panel panelTools;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Button buttonStartStopWatch;
        private System.Windows.Forms.Label labelStopWatch;
        private System.Windows.Forms.Button buttonPauseStopWatch;
        private System.Windows.Forms.Button buttonResertStopWatch;
        private System.Windows.Forms.Label labelStopWatchHeader;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonStartTimer;
        private System.Windows.Forms.Label labelTimerHeare;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Label labelInfo;
    }
}

