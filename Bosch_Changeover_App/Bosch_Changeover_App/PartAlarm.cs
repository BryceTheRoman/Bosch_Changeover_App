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
        String pt;
        String ln;
        String stat;
        String alarmT;
        Boolean desktopNot;
        Boolean emailNot;
        public PartAlarm(String partType, String lineNumber, String station, String alarmTime, Boolean desktopNotificationInput, Boolean emailNotificationInput)
        {
            InitializeComponent();
            partTypeLabel.Text = partType;
            lineNum.Text = lineNumber;
            emailNotification.Checked = emailNotificationInput;
            pt = partType;
            ln = lineNumber;
            stat = station;
            alarmT = alarmTime;
            desktopNot = desktopNotificationInput;
            emailNot = emailNotificationInput;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            ((Panel)this.Parent).Controls.Remove(this);
        }

        private void PartAlarm_Load(object sender, EventArgs e)
        {

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Form1 parentForm = (Form1)this.FindForm();
            ((Panel)this.Parent).Controls.Remove(this);
            parentForm.editAlarm(pt, ln, stat,alarmT, desktopNot, emailNot);

        }
    }
}

