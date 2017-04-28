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
    public partial class SettingsUserControl : UserControl
    {



        private static SettingsUserControl _instance;

        public static SettingsUserControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SettingsUserControl();
                return _instance;
            }
        }




        public SettingsUserControl()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Form1 parent = (Form1)this.FindForm();
            parent.saveSettingsInfo(sendDefaultEmail.Checked, emailAddressTextBox.Text);
            parent.goToLines();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Form1 parent = (Form1)this.FindForm();
            parent.goToLines();
        }
    }
}
