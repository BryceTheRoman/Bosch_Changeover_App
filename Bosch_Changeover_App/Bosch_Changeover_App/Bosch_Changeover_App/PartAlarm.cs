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
using System.Net;
using System.Net.Mail;

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


        private void sendEmail()
        {
            NetworkCredential login;
            SmtpClient client;
            MailMessage msg;
            string emailRecipient = "bosch.changeover@gmail.com";

            login = new NetworkCredential("bosch.changeover", "boschcharleston");
            client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Credentials = login;
            msg = new MailMessage("bosch.changeover@gmail.com", emailRecipient, "Part "+this.partType+" is Entering Line "+this.lineNumber, "Email send test from visual studio");
            msg.BodyEncoding = UTF8Encoding.UTF8;
            msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            client.Send(msg);
        }

    }
}

