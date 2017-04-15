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
        List<PartAlarm> alarms;
        
        public Form1()
        {

            InitializeComponent();

            lluc = new LinesLayoutUserControl(mainPanel);
            mainPanel.Controls.Add(SettingsUserControl.Instance);
            SettingsUserControl.Instance.Dock = DockStyle.Fill;
            information= new Information(this);


            mainPanel.Controls.Add(lluc);
            lluc.Dock = DockStyle.Fill;
            lluc.BringToFront();
            update_currentTime();
            alarms = new List<PartAlarm>();

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
            foreach (PartAlarm pa in partAlarmsPanel.Controls){
                pa.update_alarm();
            }
        }

        public void goToLines()
        {
            selectionLabel.Text = "Line Overview";
            lluc.BringToFront();
        }

 

        private void selectionLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxSettings_Click(object sender, EventArgs e)
        {
            selectionLabel.Text = "Settings";
            SettingsUserControl.Instance.BringToFront();
        }

        public void editAlarm(String partType, String lineNum, String station, String alarmTime, Boolean desktopNotification, Boolean emailNotification)
        {
            popup = new CreateAlarmPopup(this);
            popup.editAlarm(partType, lineNum, station, alarmTime, desktopNotification, emailNotification);
            popup.ShowDialog();
        }

        public void linebtn_Click(object sender, EventArgs e, int line)
        {
            Button Lbtn = sender as Button;
            String partNum = Lbtn.Text.Substring(0, 10);
            popup = new CreateAlarmPopup(this);
            popup.ShowDialog();
            popup.createAlarmFromLineButton(information.getCard(partNum, line));

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
            String partType = popup.getPartType();
            String lineNum = popup.getLine();
            String station = popup.getStation();
            String alarmTime = popup.getAlarmTime();
            Boolean desktopNotification = popup.getDesktopNotification();
            Boolean emailNotification = popup.getEmailNotification();
            int n = popup.getN();
            Timer timer1 = popup.getTimer();
            addAlarmtoPanel(partType, lineNum, station, alarmTime, desktopNotification, emailNotification, n, timer1);
        }

        public void addAlarmtoPanel(String partType, String lineNum, String station, String alarmTime, Boolean desktopNotification, Boolean emailNotification, int n, Timer timer1)
        {

            PartAlarm pa1 = new PartAlarm(partType, lineNum, station, alarmTime, desktopNotification, emailNotification, n, timer1);
            int numAlarms = partAlarmsPanel.Controls.Count;
            int locY = numAlarms * pa1.Height + 10 * numAlarms;
            pa1.Location = new Point(partAlarmsPanel.Location.X + partAlarmsPanel.Width / 2 - pa1.Width / 2, locY);
            partAlarmsPanel.Controls.Add(pa1);
            alarms.Add(pa1);
            information.addAlarm(pa1);
        }

        public void removeAlarm(PartAlarm pa)
        {
            alarms.Remove(pa);
            partAlarmsPanel.Controls.Remove(pa);
            information.removeAlarm(pa);
        }



        private void Form1_Resize(object sender, EventArgs e)
        {
            lluc.formResized();
            partAlarmsPanel.Height = mainPanel.Height - 190;
        }


    }
}
