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
    public partial class alarmNotification : Form
    {
        static CreateAlarmPopup form;
        string _message;
        private Information information;

        public alarmNotification(CreateAlarmPopup f)
        {
            InitializeComponent();

            form = f;
        }

        public alarmNotification(Information information)
        {
            this.information = information;
        }

        public void Message(string message)
        {
           _message = message;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Resume();
        }

        private void ringingForm_Shown(object sender, EventArgs e)
        {
           richTextBox1.Text = _message;
        }
    }
}
