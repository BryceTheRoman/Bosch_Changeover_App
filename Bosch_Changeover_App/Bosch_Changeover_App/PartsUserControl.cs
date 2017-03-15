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
    public partial class PartsUserControl : UserControl
    {


        private static PartsUserControl _instance;

        public static PartsUserControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PartsUserControl();
                return _instance;
            }
        }



        public PartsUserControl()
        {
            Button bt1 = new Button();
            bt1.Width = 100;
            bt1.Height = 100;
            bt1.Text = "+";
            bt1.Font = new Font(bt1.Font.FontFamily, 40);
            bt1.BackColor = Color.White;
            bt1.Click += btn_Click;
            InitializeComponent();
            panel1.Controls.Add(bt1);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            CreateAlarmPopup popup = new CreateAlarmPopup();
            popup.ShowDialog();
            Button bt1 = new Button();
            bt1.Width = 100;
            bt1.Height = 100;
            bool inp1 = false;
            foreach (Control p in panel1.Controls)
            {
                if (p.GetType() == typeof(Button))
                {
                    bt1 = (Button)p;
                    inp1 = true;
                }

            }
            PartAlarm pa1 = new PartAlarm();
            if (!inp1)
            {
                panel1.Controls.Clear();
                foreach (Control p in panel2.Controls)
                {
                    if (p.GetType() == typeof(Button))
                    {
                        bt1 = (Button)p;
                        inp1 = true;
                    }

                }
                panel1.Controls.Add(bt1);
            }
            else

                panel1.Controls.Add(pa1);
            panel2.Controls.Add(bt1);




        }


    }
}
