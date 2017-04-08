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
        int partType;
        int lineNumber;
        int station;
        String alarmT;
        Boolean desktopNot;
        Boolean emailNot;
        int msToSound;

        public PartAlarm(String partT, String ln, String stat, String alarmTime, Boolean desktopNotificationInput, Boolean emailNotificationInput)
        {
            InitializeComponent();

            int.TryParse(partT, out partType);
            int.TryParse(ln, out lineNumber);
            int.TryParse(stat, out station);
            alarmT = alarmTime;
            desktopNot = desktopNotificationInput;
            emailNot = emailNotificationInput;

            partTypeLabel.Text = partType.ToString();
            lineNum.Text = lineNumber.ToString();
            emailNotification.Checked = emailNotificationInput;
        }

        public void update_alarm()
        {

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
            parentForm.editAlarm(partType.ToString(), lineNumber.ToString(), station.ToString(), alarmT, desktopNot, emailNot);

        }
    }
}

