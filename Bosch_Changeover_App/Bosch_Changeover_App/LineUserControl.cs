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
            addButton("button 1 test", panelOnLine1);
            addButton("1324.153.752", panelOnLine1);
            addButton("1324.153.752", panelOnLine1);
            addButton("1324.153.752", panelOnLine1);
            addButton("button 1 test", panelOffLine1);
            addButton("1324.153.752", panelOffLine1);
            addButton("1324.153.752", panelOffLine1);
            addButton("1324.153.752", panelOffLine1);
        }

        public void addButton(String name, Panel p)
        {
            if(p == panelOnLine1)
            {
                int numButtons = p.Controls.Count;
                Button b = new Button();
                b.Text = name;
                b.Width = p.Width- 25;
                b.Height = p.Height / 4;
                b.BackColor = Color.LightGreen;
                b.FlatStyle = FlatStyle.Flat;
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
                b.Height = panelOnLine1.Height / 4;
                b.FlatStyle = FlatStyle.Flat;
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




    }
}
