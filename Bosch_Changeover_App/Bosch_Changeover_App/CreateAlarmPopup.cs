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
    public partial class CreateAlarmPopup : Form
    {
        Form1 parentForm;
        public CreateAlarmPopup(Form1 pf)
        {
            InitializeComponent();
            parentForm = pf;
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
            
            parentForm.saveButtonClicked();
            this.Close();
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
