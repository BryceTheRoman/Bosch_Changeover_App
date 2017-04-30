using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bosch_Changeover_App
{
    public partial class alarmNotification : Form
    {
        static CreateAlarmPopup form;
        string _message;
        SoundPlayer player;

        public alarmNotification(SoundPlayer player)
        {
            InitializeComponent();

            //form = f;
            this.player = player;
            this.BringToFront();
            this.Closing += alarmNotification_FormClosing;
        }

        public void Message(string message)
        {
            _message = message;
            messageLabel.Text = message;
        }

        private void ringingForm_Shown(object sender, EventArgs e)
        {
            messageLabel.Text = _message;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void alarmNotification_FormClosing(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void alarmNotification_Load(object sender, EventArgs e)
        {

        }
    }
}
