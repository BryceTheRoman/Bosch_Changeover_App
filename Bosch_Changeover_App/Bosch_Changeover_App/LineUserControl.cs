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
    public partial class LineUserControl : UserControl
    {
        private static LineUserControl _instance;

        public static LineUserControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LineUserControl();
                return _instance;
            }
        }
        public LineUserControl()
        {
            InitializeComponent();
            addButton("32          6511.589.611          32-End           1:42", panelOnLine1);
            addButton("32          6511.589.611          32-End           1:42", panelOnLine1);
            addButton("32          6511.589.611          32-End           1:42", panelOnLine1);
            addButton("32          6511.589.611          32-End           1:42", panelOnLine1);
            addButton("32          6511.589.611          32-End           1:42", panelOffLine1);
            addButton("32          6511.589.611          32-End           1:42", panelOffLine1);
            addButton("32          6511.589.611          32-End           1:42", panelOffLine1);
            addButton("32          6511.589.611          32-End           1:42", panelOffLine1);

            addButton("32          6511.589.611          32-End           1:42", panelOnLine2);
            addButton("32          6511.589.611          32-End           1:42", panelOffLine2);
            addButton("32          6511.589.611          32-End           1:42", panelOffLine2);
            addButton("32          6511.589.611          32-End           1:42", panelOffLine2);
            addButton("32          6511.589.611          32-End           1:42", panelOffLine2);
            addButton("32          6511.589.611          32-End           1:42", panelOffLine2);
            addButton("32          6511.589.611          32-End           1:42", panelOffLine2);
            addButton("32          6511.589.611          32-End           1:42", panelOffLine2);
            addButton("32          6511.589.611          32-End           1:42", panelOffLine2);

            addButton("32          6511.589.611          32-End           1:42", panelOnLine3);
            addButton("32          6511.589.611          32-End           1:42", panelOnLine3);
            addButton("32          6511.589.611          32-End           1:42", panelOffLine3);
            addButton("32          6511.589.611          32-End           1:42", panelOffLine3);
            addButton("32          6511.589.611          32-End           1:42", panelOffLine3);
            addButton("32          6511.589.611          32-End           1:42", panelOffLine3);
            addButton("32          6511.589.611          32-End           1:42", panelOffLine3);
            addButton("32          6511.589.611          32-End           1:42", panelOffLine3);
        }

        public void addButton(String name, Panel p)
        {
            if(p == panelOnLine1 || p == panelOnLine2 || p == panelOnLine3)
            {
                int numButtons = p.Controls.Count;
                Button b = new Button();
                b.Text = name;
                b.Width = p.Width- 25;
                b.Height = p.Height / 4 + 5;
                //b.BackColor = Color.LightGreen;
                b.BackColor = Color.FromArgb(33, 95, 139);// 0, 59, 106);
                b.ForeColor = Color.White;
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                b.Font = new Font(b.Font.FontFamily, 11);


                if (numButtons != 0)
                {


                    b.Location = new Point(p.Controls[numButtons-1].Location.X, p.Controls[numButtons-1].Location.Y+b.Height + 5);
                }
                else
                {
                    b.Location = new Point(0, 0);
                }
                p.Controls.Add(b);
            }
            else
            {
                int numButtons = p.Controls.Count;
                Button b = new Button();
                b.Text = name;
                b.Width = p.Width - 25;
                b.Height = panelOnLine1.Height / 4 + 5;
                b.FlatStyle = FlatStyle.Flat;
                b.BackColor = Color.FromArgb(198, 205, 209);// 198, 205, 209);//190, 205, 214);
                b.FlatAppearance.BorderSize = 0;
                b.Font = new Font(b.Font.FontFamily, 11);

                if (numButtons != 0)
                {
                    b.Location = new Point(p.Controls[numButtons - 1].Location.X, p.Controls[numButtons - 1].Location.Y + b.Height + 5);
                }
                else
                {
                    b.Location = new Point(0, 0);
                }
                p.Controls.Add(b);
            }
        }

        private void LineUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
