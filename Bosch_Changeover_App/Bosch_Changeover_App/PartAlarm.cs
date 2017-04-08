using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bosch_Changeover_App

{
    public partial class PartAlarm : UserControl
    {

        public PartAlarm(String partType, String lineNumber, String station, String alarmTime, Boolean desktopNotificationInput, Boolean emailNotificationInput)
        {
            InitializeComponent();
            partTypeLabel.Text = partType;
            lineNum.Text = lineNumber;
            emailNotification.Checked = emailNotificationInput;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            ((Panel)this.Parent).Controls.Remove(this);
        }

        private void PartAlarm_Load(object sender, EventArgs e)
        {

        }
    }
}

