
namespace Clock
{
    partial class FormStopWatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStopWatch));
            this.labelStopWatchHeader = new System.Windows.Forms.Label();
            this.buttonResertStopWatch = new System.Windows.Forms.Button();
            this.buttonPauseStopWatch = new System.Windows.Forms.Button();
            this.labelStopWatch = new System.Windows.Forms.Label();
            this.buttonStartStopWatch = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelStopWatchHeader
            // 
            this.labelStopWatchHeader.AutoSize = true;
            this.labelStopWatchHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStopWatchHeader.Location = new System.Drawing.Point(25, 29);
            this.labelStopWatchHeader.Name = "labelStopWatchHeader";
            this.labelStopWatchHeader.Size = new System.Drawing.Size(167, 37);
            this.labelStopWatchHeader.TabIndex = 13;
            this.labelStopWatchHeader.Text = "Stopwatch";
            // 
            // buttonResertStopWatch
            // 
            this.buttonResertStopWatch.Location = new System.Drawing.Point(352, 30);
            this.buttonResertStopWatch.Name = "buttonResertStopWatch";
            this.buttonResertStopWatch.Size = new System.Drawing.Size(70, 33);
            this.buttonResertStopWatch.TabIndex = 17;
            this.buttonResertStopWatch.Text = "Reset";
            this.buttonResertStopWatch.UseVisualStyleBackColor = true;
            this.buttonResertStopWatch.Click += new System.EventHandler(this.buttonResertStopWatch_Click);
            // 
            // buttonPauseStopWatch
            // 
            this.buttonPauseStopWatch.Location = new System.Drawing.Point(276, 30);
            this.buttonPauseStopWatch.Name = "buttonPauseStopWatch";
            this.buttonPauseStopWatch.Size = new System.Drawing.Size(70, 33);
            this.buttonPauseStopWatch.TabIndex = 16;
            this.buttonPauseStopWatch.Text = "Pause";
            this.buttonPauseStopWatch.UseVisualStyleBackColor = true;
            this.buttonPauseStopWatch.Click += new System.EventHandler(this.buttonPauseStopWatch_Click);
            // 
            // labelStopWatch
            // 
            this.labelStopWatch.AutoSize = true;
            this.labelStopWatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStopWatch.Location = new System.Drawing.Point(428, 30);
            this.labelStopWatch.Name = "labelStopWatch";
            this.labelStopWatch.Size = new System.Drawing.Size(31, 33);
            this.labelStopWatch.TabIndex = 15;
            this.labelStopWatch.Text = "0";
            // 
            // buttonStartStopWatch
            // 
            this.buttonStartStopWatch.Location = new System.Drawing.Point(198, 29);
            this.buttonStartStopWatch.Name = "buttonStartStopWatch";
            this.buttonStartStopWatch.Size = new System.Drawing.Size(72, 34);
            this.buttonStartStopWatch.TabIndex = 14;
            this.buttonStartStopWatch.Text = "Start";
            this.buttonStartStopWatch.UseVisualStyleBackColor = true;
            this.buttonStartStopWatch.Click += new System.EventHandler(this.buttonStartStopWatch_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FormStopWatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 108);
            this.Controls.Add(this.buttonResertStopWatch);
            this.Controls.Add(this.buttonPauseStopWatch);
            this.Controls.Add(this.labelStopWatch);
            this.Controls.Add(this.buttonStartStopWatch);
            this.Controls.Add(this.labelStopWatchHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormStopWatch";
            this.Text = "StopWatch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStopWatchHeader;
        private System.Windows.Forms.Button buttonResertStopWatch;
        private System.Windows.Forms.Button buttonPauseStopWatch;
        private System.Windows.Forms.Label labelStopWatch;
        private System.Windows.Forms.Button buttonStartStopWatch;
        private System.Windows.Forms.Timer timer;
    }
}