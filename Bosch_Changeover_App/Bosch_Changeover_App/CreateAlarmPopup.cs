using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Bosch_Changeover_App

{
    public partial class CreateAlarmPopup : Form
    {
        Form1 parentForm;
        public CreateAlarmPopup(Form1 pf)
        {
            InitializeComponent();
            parentForm = pf;
            alarmTimeComboBox.Text = "351";
        }

        public void createAlarmFromLineButton(Card partType)
        {

            partTypeTextBox.Text = partType.getPartType().ToString();
            lineComboBox.SelectedIndex = lineComboBox.FindStringExact( partType.getLine().ToString() );
            stationComboBox.SelectedIndex = stationComboBox.FindStringExact( partType.getStartStation().ToString() + "-" + partType.getEndStation().ToString() );
        }


        public void editAlarm(String partType, String lineNum, String station, String alarmTime, Boolean desktopNotification, Boolean emailNotification)
        {
            partTypeTextBox.Text = partType;
            lineComboBox.SelectedIndex = lineComboBox.FindStringExact( lineNum );
            stationComboBox.SelectedIndex = stationComboBox.FindStringExact( station );
            if (!alarmTimeComboBox.Items.Contains(alarmTime))
            {
                alarmTimeComboBox.SelectedItem = "Custom";
            }
            //alarmTimeComboBox.SelectedIndex= alarmTimeComboBox.FindStringExact( alarmTime );
            //alarmTimeComboBox.Text = alarmTime;
            desktopCheckBox.Checked = desktopNotification;
            emailCheckBox.Checked = emailNotification;
        }


        private void CreateAlarmPopup_Load(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int i;
            int s;
            int l = -1;
            Debug.WriteLine(partTypeTextBox.Text.All(char.IsDigit));
            
            if (!partTypeTextBox.Text.All(char.IsDigit) || partTypeTextBox.Text.Length != 10)
            {
                MessageBox.Show("Part Type must be a 10 digit number.");
            }

            else if (!int.TryParse(stationComboBox.Text, out s))
            {
                MessageBox.Show("Station must be an integer.");
            }
            else if (!int.TryParse(lineComboBox.Text, out l) || !( l == 1 || l == 2 || l == 3))
            {
                MessageBox.Show("Line must be either 1, 2, or 3.");
            }
            else if (!int.TryParse(alarmTimeComboBox.Text, out i))
            {
                MessageBox.Show("Alarm Time must be an integer.");
            }
            else
            {
                parentForm.saveButtonClicked();
                this.Close();
            }
        }

        public string getPartType()
        {
            return partTypeTextBox.Text;
        }

        public string getLine()
        {
            return lineComboBox.Text;
        }

        public string getStation()
        {
            return stationComboBox.Text;
        }

        public string getAlarmTime()
        {
            return alarmTimeComboBox.Text;
        }

        public Boolean getDesktopNotification()
        {
            return desktopCheckBox.Checked;
        }

        public Boolean getEmailNotification()
        {
            return emailCheckBox.Checked;
        }



    }
}
