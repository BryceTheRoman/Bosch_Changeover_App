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

        public Form1()
        {


            InitializeComponent();


            mainPanel.Controls.Add(SettingsUserControl.Instance);
            SettingsUserControl.Instance.Dock = DockStyle.Fill;

            mainPanel.Controls.Add(LineUserControl.Instance);
            LineUserControl.Instance.Dock = DockStyle.Fill;
            LineUserControl.Instance.BringToFront();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        public void goToLines()
        {
            selectionLabel.Text = "Line Overview";
            LineUserControl.Instance.BringToFront();
        }

 

        private void selectionLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxSettings_Click(object sender, EventArgs e)
        {
            selectionLabel.Text = "Settings";
            SettingsUserControl.Instance.BringToFront();
        }



        public void linebtn_Click()
        {
            CreateAlarmPopup popup = new CreateAlarmPopup();
            popup.ShowDialog();

            PartAlarm pa1 = new PartAlarm();
            int numAlarms = partAlarmsPanel.Controls.Count;
            int locY = numAlarms * pa1.Height + 10 * numAlarms;
            pa1.Location = new Point(partAlarmsPanel.Location.X + partAlarmsPanel.Width / 2 - pa1.Width / 2, locY);
            partAlarmsPanel.Controls.Add(pa1);


        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            CreateAlarmPopup popup = new CreateAlarmPopup();
            popup.ShowDialog();

            PartAlarm pa1 = new PartAlarm();
            int numAlarms = partAlarmsPanel.Controls.Count;
            int locY = numAlarms * pa1.Height + 10 * numAlarms;
            pa1.Location = new Point(partAlarmsPanel.Location.X + partAlarmsPanel.Width / 2 - pa1.Width / 2, locY);
            partAlarmsPanel.Controls.Add(pa1);
        }
    }
}
