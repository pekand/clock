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
    public partial class FormCalendar : Form
    {
        public FormCalendar()
        {
            InitializeComponent();
        }

        private void FormCalendar_Load(object sender, EventArgs e)
        {
            int year = DateTime.Now.Year;

            /*int[12][3] calendar = new int[] {
                { 0, 0, 0},
                { 0, 0, 0},
                { 0, 0, 0},
                { 0, 0, 0},
                { 0, 0, 0},
                { 0, 0, 0},
                { 0, 0, 0},
                { 0, 0, 0},
                { 0, 0, 0},
                { 0, 0, 0},
                { 0, 0, 0},
                { 0, 0, 0},
            };*/

            

            DateTime firstDay = DateTime.Parse(year.ToString()+"-01-01");

            for (int i = 1; i < 13; i++)
            {

            }
        }

        private Bitmap bitmap = null;


        private int DayToSpace(DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek) {
                case DayOfWeek.Monday: 
                    return 0;
                case DayOfWeek.Tuesday:
                    return 1;
                case DayOfWeek.Wednesday:
                    return 2;
                case DayOfWeek.Thursday:
                    return 3;
                case DayOfWeek.Friday:
                    return 4;
                case DayOfWeek.Saturday:
                    return 5;
                case DayOfWeek.Sunday:
                    return 6;

            }

            return 0;
        }

        private void FormCalendar_Paint(object sender, PaintEventArgs e)
        {

            

            if (this.bitmap == null) 
            {
                this.bitmap = new Bitmap(1200, 400);
                using (Graphics gr = Graphics.FromImage(this.bitmap))
                {

                    using (Pen thick_pen = new Pen(Color.Blue, 5))
                    {
                        int px = 40;
                        int py = 40;

                        Pen blackPen = new Pen(Color.Gray, 1);


                        int year = DateTime.Now.Year;

                        int mx = 10;
                        int my = 40;
                        for (int m = 1; m < 13; m++)
                        {
                            SolidBrush blueBrush = new SolidBrush(Color.Yellow);
                            gr.FillRectangle(blueBrush, new Rectangle(mx, my, 30, 30));
                            gr.DrawString(m.ToString(), this.Font, Brushes.Black, mx + 10, my + 10);
                            my = my + 30;
                        }

                        for (int m = 1; m < 13; m++)
                        {
                            DateTime startDay = new DateTime(year, m, 1);
                            for (int s = 0; s < this.DayToSpace(startDay.DayOfWeek); s++)
                            {
                                SolidBrush blueBrush = new SolidBrush(Color.Gray);
                                gr.FillRectangle(blueBrush, new Rectangle(px, py, 30, 30));
                                px = px + 30;
                            }


                            for (int d = 1; d <= DateTime.DaysInMonth(year, m); d++)
                            {
                                SolidBrush blueBrush = new SolidBrush(Color.AliceBlue);

                                DateTime day = new DateTime(year, m, d);


                                if (day.DayOfWeek == DayOfWeek.Saturday || day.DayOfWeek == DayOfWeek.Sunday)
                                {
                                    blueBrush = new SolidBrush(Color.Beige);
                                }

                                if (m == DateTime.Now.Month && d == DateTime.Now.Day)
                                {
                                    blueBrush = new SolidBrush(Color.Red);
                                }

                                gr.FillRectangle(blueBrush, new Rectangle(px, py, 30, 30));
                                gr.DrawString(d.ToString(), this.Font, Brushes.Black, px + 10, py + 10);
                                px = px + 30;
                            }

                            for (int s = this.DayToSpace(startDay.DayOfWeek) + DateTime.DaysInMonth(year, m); s < 31 + 6; s++)
                            {
                                SolidBrush blueBrush = new SolidBrush(Color.Gray);
                                gr.FillRectangle(blueBrush, new Rectangle(px, py, 30, 30));
                                px = px + 30;
                            }

                            px = 40;
                            py = py + 30;
                        }

                        int dx = 40;
                        int dy = 10;
                        string[] days = new string[] { "Mo", "Tu", "We", "Th", "Fr", "Sa", "Su" };
                        for (int d = 0; d < 31 + 6; d++)
                        {
                            SolidBrush blueBrush = new SolidBrush(Color.Green);
                            gr.FillRectangle(blueBrush, new Rectangle(dx, dy, 30, 30));
                            gr.DrawString(days[d % 7], this.Font, Brushes.Black, dx + 10, dy + 10);
                            dx = dx + 30;
                        }
                    }
                }

            }


            e.Graphics.DrawImage(this.bitmap, 0, 0);



        }
    }
}
