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
        int countDownSecs;
        Timer partAlarmTimer;

        public PartAlarm(string partT, string ln, string stat, string alarmTime, Boolean desktopNotificationInput, Boolean emailNotificationInput, int N, Timer timer1)
        {
            InitializeComponent();

            partType = partT;
            lineNumber = ln;
            station = stat;
            alarmT = alarmTime;
            desktopNot = desktopNotificationInput;
            emailNot = emailNotificationInput;
            countDownSecs = N;
            partAlarmTimer = timer1;

            partTypeLabel.Text = partT;
            timeRemaining.Text = "00:00:" + alarmTime;
            //countDownSecs = ((int)alarmHours * 3600) + 
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1 = partAlarmTimer;
            partAlarmTimer.Start();
        }
    }
}

