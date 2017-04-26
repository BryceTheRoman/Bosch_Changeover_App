using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bosch_Changeover_App
{
    public partial class Form1 : Form
    {
        CreateAlarmPopup popup;
        LinesLayoutUserControl lluc;
        Information information;

        public Form1()
        {

            InitializeComponent();

            lluc = new LinesLayoutUserControl(mainPanel);
            mainPanel.Controls.Add(SettingsUserControl.Instance);
            SettingsUserControl.Instance.Dock = DockStyle.Fill;
            information = new Information(this);


            mainPanel.Controls.Add(lluc);
            lluc.Dock = DockStyle.Fill;
            lluc.BringToFront();
            update_currentTime();
            //update_lines();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void update_currentTime()
        {

            currentTimeLabel.Text = DateTime.Now.ToString("hh:mm tt");
        }

        public void update_partAlarms()
        {
            foreach (PartAlarm pa in partAlarmsPanel.Controls)
            {
                pa.update_alarm();
            }
        }

        public void goToLines()
        {
            selectionLabel.Text = "Line Overview";
            lluc.BringToFront();
        }


        public void add_lines(List<Card> line1List, List<Card> offline1List, List<Card> line2List, List<Card> offline2List, List<Card> line3List, List<Card> offline3List)
        {
            lluc.addAll(line1List, offline1List, line2List, offline2List, line3List, offline3List);
        }

        public void update_lines(List<Card> line1List, List<Card> offline1List, List<Card> line2List, List<Card> offline2List, List<Card> line3List, List<Card> offline3List)
        {
            lluc.updateAll(line1List, offline1List, line2List, offline2List, line3List, offline3List);
        }


        private void selectionLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxSettings_Click(object sender, EventArgs e)
        {
            selectionLabel.Text = "Settings";
            SettingsUserControl.Instance.BringToFront();
        }

        public void editAlarm(string partType, string lineNum, string station, string alarmTime, bool desktopNotification, bool emailNotification)
        {
            popup = new CreateAlarmPopup(this);
            popup.editAlarm(partType, lineNum, station, alarmTime, desktopNotification, emailNotification);
            popup.ShowDialog();
        }

        public void linebtn_Click(object sender, EventArgs e, int line)
        {
            Button Lbtn = sender as Button;
            string partNum = Lbtn.Text.Substring(0, 10);
            popup = new CreateAlarmPopup(this);
            popup.createAlarmFromLineButton(information.getCard(partNum, line));
            popup.ShowDialog();


            /*            PartAlarm pa1 = new PartAlarm();
                        int numAlarms = partAlarmsPanel.Controls.Count;
                        int locY = numAlarms * pa1.Height + 10 * numAlarms;
                        pa1.Location = new Point(partAlarmsPanel.Location.X + partAlarmsPanel.Width / 2 - pa1.Width / 2, locY);
                        partAlarmsPanel.Controls.Add(pa1);*/


        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            popup = new CreateAlarmPopup(this);
            popup.ShowDialog();

            /*  PartAlarm pa1 = new PartAlarm();
              int numAlarms = partAlarmsPanel.Controls.Count;
              int locY = numAlarms * pa1.Height + 10 * numAlarms;
              pa1.Location = new Point(partAlarmsPanel.Location.X + partAlarmsPanel.Width / 2 - pa1.Width / 2, locY);
              partAlarmsPanel.Controls.Add(pa1);*/
        }

        public void saveButtonClicked()
        {
            string partType = popup.getPartType();
            string lineNum = popup.getLine();
            string station = popup.getStation();
            string alarmTime = popup.getAlarmTime();
            bool desktopNotification = popup.getDesktopNotification();
            bool emailNotification = popup.getEmailNotification();
            int n = popup.getN();
            addAlarmtoPanel(partType, lineNum, station, alarmTime, desktopNotification, emailNotification, n, null);
        }

        public void addAlarmtoPanel(string partType, string lineNum, string station, string alarmTime, bool desktopNotification, bool emailNotification, int n, Timer timer1)
        {
            partAlarmsPanel.AutoScrollPosition = new Point(0, 0);
            Card c = information.getCard(partType, Int32.Parse(lineNum));
            PartAlarm pa1 = new PartAlarm(partType, lineNum, station, alarmTime, desktopNotification, emailNotification, n, c);
            int numAlarms = partAlarmsPanel.Controls.Count;
            int locY = numAlarms * pa1.Height + 10 * numAlarms;
            pa1.Location = new Point(partAlarmsPanel.Location.X + partAlarmsPanel.Width / 2 - pa1.Width / 2, locY);
            partAlarmsPanel.Controls.Add(pa1);
            if (c != null)
            {
                information.addAlarm(pa1);
                pa1.update_alarm(); //gotta set the timer
                pa1.startTimer(); //gotta start the timer
            }
        }

        public void removeAlarm(PartAlarm pa)
        {
            partAlarmsPanel.Controls.Remove(pa);
            information.removeAlarm(pa);

            List<PartAlarm> paList = new List<PartAlarm>();

            foreach (PartAlarm p in partAlarmsPanel.Controls)
            {
                paList.Add(p);
            }

            foreach (PartAlarm p in paList)
            {
                partAlarmsPanel.Controls.Remove(p);
            }

            foreach (PartAlarm p in paList)
            {
                slideUpAlarm(p);
            }
        }

        private void slideUpAlarm(PartAlarm pa1)
        {
            int numAlarms = partAlarmsPanel.Controls.Count;
            int locY = numAlarms * pa1.Height + 10 * numAlarms;
            pa1.Location = new Point(partAlarmsPanel.Location.X + partAlarmsPanel.Width / 2 - pa1.Width / 2, locY);
            partAlarmsPanel.Controls.Add(pa1);
        }



        private void Form1_Resize(object sender, EventArgs e)
        {
            lluc.formResized();
            partAlarmsPanel.Height = mainPanel.Height - 190;
        }


    }
}

