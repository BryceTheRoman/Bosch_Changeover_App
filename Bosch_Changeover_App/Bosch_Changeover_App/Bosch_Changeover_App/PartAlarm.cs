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
using System.Media;
using System.Timers;

namespace Bosch_Changeover_App

{
    public partial class PartAlarm : UserControl
    {
        string partType;
        string lineNumber;
        string station;
        string alarmT;
        bool desktopNot;
        bool emailNot;
        int msToSound;
        int countDownSecs;
        System.Threading.Timer partAlarmTimer;

        //private System.Timers.Timer timer;
        private TimeSpan currentTime;
        private TimeSpan userTimer;
        private Card part;
        private Form1 parentForm;

        public PartAlarm(string partT, string ln, string stat, string alarmTime, bool desktopNotificationInput, bool emailNotificationInput, int N, Card c, Form1 pForm)
        {
            InitializeComponent();

            this.parentForm = pForm;

            if(c == null)
            {
                partType = partT;
                lineNumber = ln;
                station = stat;
                alarmT = alarmTime; //a string that is number ofminutes before goes on line to sound the alarm
                desktopNot = desktopNotificationInput;
                emailNot = emailNotificationInput;
                countDownSecs = N; //not sure what this is used for
                this.part = c;

                partTypeLabel.Text = partT;
                timeRemaining.Text = "Not in Queue";
                timeRemaining.Font = new Font(timeRemaining.Font.FontFamily, 18);
                numberOfParts.Text = "NA";

                lineNum.Text = lineNumber;
                emailNotification.Checked = emailNotificationInput;

            }
            else
            {
                partType = partT;
                lineNumber = ln;
                station = stat;
                alarmT = alarmTime; //a string that is number ofminutes before goes on line to sound the alarm
                desktopNot = desktopNotificationInput;
                emailNot = emailNotificationInput;
                countDownSecs = N; //not sure what this is used for

                numberOfParts.Text = c.getPartsRemaining().ToString();

                partTypeLabel.Text = partT;
                timeRemaining.Text = "00:00:00";

                lineNum.Text = lineNumber;
                emailNotification.Checked = emailNotificationInput;


                currentTime = DateTime.Now - DateTime.Now.Date;
                userTimer = new TimeSpan(0, 0, 0);
                //timer = new System.Timers.Timer();
                //timer.Interval = 1000;
                //timer.Elapsed += Timer_Elapsed;
                part = c;
            }



        }

        public void startTimer()
        {
            //timer.Start();
        }

        delegate void UpdateLabel(Label lbl, string val);
        void UpdateDataLabel(Label lbl, string val)
        {
            lbl.Text = val;
        }

        public void countDown()
        {
            currentTime = DateTime.Now - DateTime.Now.Date;
            userTimer = userTimer.Subtract(new TimeSpan(0, 0, 1));

            UpdateLabel upd = UpdateDataLabel;
            if (timeRemaining.InvokeRequired)
            {
                string display = string.Format("{0:D2}:{1:D2}:{2:D2}",
                                    userTimer.Hours,
                                    userTimer.Minutes,
                                    userTimer.Seconds);
                Invoke(upd, timeRemaining, display);
            }
            else
            {
                string display = string.Format("{0:D2}:{1:D2}:{2:D2}",
                                    userTimer.Hours,
                                    userTimer.Minutes,
                                    userTimer.Seconds);
                timeRemaining.Text = display;
            }

            //if (userTimer.Equals(currentTime))
            if (userTimer.Equals(new TimeSpan(0, 0, 0)))
            {
                //Form1 parentForm = (Form1)this.FindForm();
                parentForm.removeAlarm(this);

                //timer.Stop();
                try
                {
                    SoundPlayer player = new SoundPlayer();
                    player.SoundLocation = @"C:\WINDOWS\MEDIA\Alarm01.wav";
                    player.PlayLooping();
                    alarmNotification notifier = new alarmNotification(player);
                    notifier.Message("Part "+this.partType+" will enter Line "+this.lineNumber+" in "+this.alarmT+" minutes.");
                    notifier.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                sendEmail();
            }
        }

        public void update_alarm()
        {
            currentTime = DateTime.Now - DateTime.Now.Date;

            //int minutesToAlarm = part.getPartsRemaining() * part.getCycletime();

            //userTimer = currentTime - new TimeSpan(0, minutesToAlarm, 0) + new TimeSpan(0, 30, 0);

            int minutesToAlarm = Int32.Parse(alarmT); //user said this is how many minutes before going online where they want the alarm to sound
            int timeRemaining = part.getTimeRemaining(); //passed in this card, this is the time remaining value, an integer in seconds according to the LineUserControl class
            long ms1 = timeRemaining * 1000;
            long ms2 = minutesToAlarm * 60 * 1000;
            TimeSpan t = TimeSpan.FromMilliseconds(ms1);
            TimeSpan m = TimeSpan.FromMilliseconds(ms2);

            userTimer = t.Subtract(m);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
        //    Form1 parentForm = (Form1)this.FindForm();
            parentForm.removeAlarm(this);
            //((Panel)this.Parent).Controls.Remove(this);
        }

        private void PartAlarm_Load(object sender, EventArgs e)
        {

        }

        private void editButton_Click(object sender, EventArgs e)
        {
        //    Form1 parentForm = (Form1)this.FindForm();
            // ((Panel)this.Parent).Controls.Remove(this);
            parentForm.removeAlarm(this);
            parentForm.editAlarm(partType, lineNumber, station, alarmT, desktopNot, emailNot);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //timer1 = partAlarmTimer;
            //partAlarmTimer.Start();
        }


        private void sendEmail()
        {

            NetworkCredential login;
            SmtpClient client;
            MailMessage msg;
       //     Form1 parentForm = (Form1)this.FindForm();
            string emailRecipient = parentForm.getUserEmail(); //"bosch.changeover@gmail.com";
            login = new NetworkCredential("bosch.changeover", "boschcharleston");
            client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Credentials = login;
            msg = new MailMessage("bosch.changeover@gmail.com", emailRecipient, "Part " + this.partType + " is entering line " + this.lineNumber+" in "+this.alarmT+" minutes", "Part " + this.partType + " is entering line " + this.lineNumber + " in " + this.alarmT + " minutes");
            msg.BodyEncoding = UTF8Encoding.UTF8;
            msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            client.Send(msg);
        }

    }
}

