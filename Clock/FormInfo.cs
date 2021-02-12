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
    public partial class FormInfo : Form
    {
        public FormInfo()
        {
            InitializeComponent();
        }

        private void FormInfo_Load(object sender, EventArgs e)
        {
            TimeZone localZone = TimeZone.CurrentTimeZone;

            DaylightTime daylight =
            localZone.GetDaylightChanges(DateTime.Now.Year);


            this.textBox.Text =
                "Timezone: " + localZone.StandardName +
                " \r\nDaylight saving time name: " + localZone.DaylightName +
                " \r\nDaylight saving time: " + localZone.IsDaylightSavingTime(DateTime.Now) +

                " \r\nDaylight start: " + daylight.Start.ToString() +
                " \r\nDaylight end: " + daylight.End.ToString() +
                " \r\nDelta: " + daylight.Delta +

                " \r\nUTC time: " + localZone.ToUniversalTime(DateTime.Now) +
                " \r\nUTC offset: " + localZone.GetUtcOffset(DateTime.Now)
                ;

            this.textBox.SelectionStart = 0;
            this.textBox.SelectionLength = 0;

        }
    }
}
