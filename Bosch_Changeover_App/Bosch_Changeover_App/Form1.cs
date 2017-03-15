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
        Button selectedButton = new Button();

        public Form1()
        {

            selectedButton = linesButton;
            InitializeComponent();
            linesButton.BackColor = Color.FromArgb(0, 59, 106);

            mainPanel.Controls.Add(LineUserControl.Instance);
            LineUserControl.Instance.Dock = DockStyle.Fill;
            LineUserControl.Instance.BringToFront();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linesButton_Click(object sender, EventArgs e)
        {
            selectedButton = linesButton;
            linesButton.BackColor = Color.FromArgb(0, 59, 106);
            partsButton.BackColor = Color.FromArgb(33, 95, 139);
            settingsButton.BackColor = Color.FromArgb(33, 95, 139);
            selectionLabel.Text = "Line Overview";

            if (!mainPanel.Controls.Contains(LineUserControl.Instance))
            {
                mainPanel.Controls.Add(LineUserControl.Instance);
                LineUserControl.Instance.Dock = DockStyle.Fill;
                LineUserControl.Instance.BringToFront();

            }
            else
            {
                LineUserControl.Instance.BringToFront();
            }

        }

        private void partsButton_Click(object sender, EventArgs e)
        {

            selectedButton = partsButton;
            partsButton.BackColor = Color.FromArgb(0, 59, 106);
            linesButton.BackColor = Color.FromArgb(33, 95, 139);
            settingsButton.BackColor = Color.FromArgb(33, 95, 139);
            selectionLabel.Text = "Part Alarms";


            if (!mainPanel.Controls.Contains(PartsUserControl.Instance))
            {
                mainPanel.Controls.Add(PartsUserControl.Instance);
                PartsUserControl.Instance.Dock = DockStyle.Fill;
                PartsUserControl.Instance.BringToFront();

            }
            else
            {
                PartsUserControl.Instance.BringToFront();
            }




        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            selectedButton = settingsButton;
            settingsButton.BackColor = Color.FromArgb(0, 59, 106);
            partsButton.BackColor = Color.FromArgb(33, 95, 139);
            linesButton.BackColor = Color.FromArgb(33, 95, 139);
            selectionLabel.Text = "Settings";



            if (!mainPanel.Controls.Contains(SettingsUserControl.Instance))
            {
                mainPanel.Controls.Add(SettingsUserControl.Instance);
                SettingsUserControl.Instance.Dock = DockStyle.Fill;
                SettingsUserControl.Instance.BringToFront();

            }
            else
            {
                SettingsUserControl.Instance.BringToFront();
            }

        }

        private void selectionLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
