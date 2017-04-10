using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Bosch_Changeover_App

{
    public partial class PartAlarm : UserControl
    {
        String partType;
        String lineNumber;
        String station;
        String alarmT;
        Boolean desktopNot;
        Boolean emailNot;
        int msToSound;

        public PartAlarm(String partT, String ln, String stat, String alarmTime, Boolean desktopNotificationInput, Boolean emailNotificationInput)
        {
            InitializeComponent();

            partType = partT;
            lineNumber = ln;
            station = stat;
            alarmT = alarmTime;
            desktopNot = desktopNotificationInput;
            emailNot = emailNotificationInput;

            partTypeLabel.Text = partT;
            lineNum.Text = lineNumber;
            emailNotification.Checked = emailNotificationInput;
        }

        public void update_alarm()
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Form1 parentForm = (Form1)this.FindForm();
            parentForm.removeAlarm(this);
            //((Panel)this.Parent).Controls.Remove(this);
        }

        private void PartAlarm_Load(object sender, EventArgs e)
        {

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Form1 parentForm = (Form1)this.FindForm();
            // ((Panel)this.Parent).Controls.Remove(this);
            parentForm.removeAlarm(this);
            parentForm.editAlarm(partType, lineNumber, station, alarmT, desktopNot, emailNot);

        }
    }
}

