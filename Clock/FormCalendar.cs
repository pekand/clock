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

        private int lastWidth = 0;

        private void FormCalendar_Paint(object sender, PaintEventArgs e)
        {

            int width = this.Width / 38;

            if (this.bitmap == null || lastWidth != width) 
            {

                lastWidth = width;

                this.bitmap = new Bitmap(this.Width, this.Height);
                

                int center = (width - 10)/ 2;

                using (Graphics gr = Graphics.FromImage(this.bitmap))
                {

                    using (Pen thick_pen = new Pen(Color.Blue, 5))
                    {
                        int px = width;
                        int py = width;

                        Pen blackPen = new Pen(Color.Gray, 1);


                        int year = DateTime.Now.Year;

                        int mx = 0;
                        int my = width;
                        for (int m = 1; m < 13; m++)
                        {
                            SolidBrush blueBrush = new SolidBrush(System.Drawing.ColorTranslator.FromHtml("#FFF28A"));
                            gr.FillRectangle(blueBrush, new Rectangle(mx, my, width, width));
                            gr.DrawString(m.ToString(), this.Font, Brushes.Black, mx + center, my + center);
                            my = my + width;
                        }

                        for (int m = 1; m < 13; m++)
                        {
                            DateTime startDay = new DateTime(year, m, 1);
                            for (int s = 0; s < this.DayToSpace(startDay.DayOfWeek); s++)
                            {
                                SolidBrush blueBrush = new SolidBrush(System.Drawing.ColorTranslator.FromHtml("#FFFFFF"));
                                gr.FillRectangle(blueBrush, new Rectangle(px, py, width, width));
                                px = px + width;
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

                                gr.FillRectangle(blueBrush, new Rectangle(px, py, width, width));
                                gr.DrawString(d.ToString(), this.Font, Brushes.Black, px + center, py + center);
                                px = px + width;
                            }

                            for (int s = this.DayToSpace(startDay.DayOfWeek) + DateTime.DaysInMonth(year, m); s < 31 + 6; s++)
                            {
                                SolidBrush blueBrush = new SolidBrush(System.Drawing.ColorTranslator.FromHtml("#FFFFFF"));
                                gr.FillRectangle(blueBrush, new Rectangle(px, py, width, width));
                                px = px + width;
                            }

                            px = width;
                            py = py + width;
                        }

                        int dx = width;
                        int dy = 0;
                        string[] days = new string[] { "Mo", "Tu", "We", "Th", "Fr", "Sa", "Su" };
                        for (int d = 0; d < 31 + 6; d++)
                        {
                            SolidBrush blueBrush = new SolidBrush(System.Drawing.ColorTranslator.FromHtml("#FFF28A"));
                            gr.FillRectangle(blueBrush, new Rectangle(dx, dy, width, width));
                            gr.DrawString(days[d % 7], this.Font, Brushes.Black, dx + center, dy + center);
                            dx = dx + width;
                        }
                    }
                }

            }


            e.Graphics.DrawImage(this.bitmap, 0, 0);



        }

        private void FormCalendar_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
