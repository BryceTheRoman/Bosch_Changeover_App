using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Bosch_Changeover_App
{
    public partial class LineUserControl : UserControl
    {
    //    private static LineUserControl _instance;
        private Form1 parentForm;

        /*     public static LineUserControl Instance
             {
                 get
                 {
                     if (_instance == null)
                         _instance = new LineUserControl();
                     return _instance;
                 }
             }*/
        int line;
        public LineUserControl(int line)
        {
            InitializeComponent();
            lineLabel.Text = "Line " + line.ToString() ;
            this.line = line;
            /* addButton("6511588611          32                32-End        00:01:42", panelOnLine1);
            addButton("6511588611          32                32-End        00:01:42", panelOnLine1);
            addButton("6511588611          32                32-End        00:01:42", panelOnLine1);
            addButton("6511588611          32                32-End        00:01:42", panelOnLine1);
            addButton("6511588611          32              00:01:42        00:02:42", panelOffLine1);
            addButton("6511588611          32              00:01:42        00:02:42", panelOffLine1);
            addButton("6511588611          32              00:01:42        00:02:42", panelOffLine1);
            addButton("6511588611          32              00:01:42        00:02:42", panelOffLine1);
            addButton("6511588611          32              00:01:42        00:02:42", panelOffLine1);
            addButton("6511588611          32              00:01:42        00:02:42", panelOffLine1);
            addButton("6511588611          32              00:01:42        00:02:42", panelOffLine1);
        */
        }

        public void addButtonToPanel(Card card)
        {
            if (card.checkOnline())
            {
                addButton(card.getPartType().ToString() + "          " + card.getPartsRemaining().ToString() + "                "+card.getStartStation().ToString()+"-"+card.getEndStation().ToString()+ "        " +card.getTimeToFinish().ToString(), panelOnLine1);

            }
            else
            {
                addButton(card.getPartType().ToString() + "          " + card.getPartsRemaining().ToString() + "                " + card.getTimeRemaining().ToString() + "        " + card.getTimeToFinish().ToString(), panelOffLine1);
            }
        }

        private void addButton(String buttonText, Panel p)
        {  

            int numButtons = p.Controls.Count;
            Button b = new Button();
            b.Text = buttonText;
            b.Width = p.Width- 25;
            b.Height = panelOnLine1.Height / 4 + 5;
            if (p == panelOnLine1)// || p == panelOnLine2 || p == panelOnLine3)
            {
                b.BackColor = Color.FromArgb(33, 95, 139);// 0, 59, 106);
                b.ForeColor = Color.White;
            }
            else
            {
                b.BackColor = Color.FromArgb(198, 205, 209);
                b.Cursor = Cursors.Hand;
                b.Click += btn_Click;
            }

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

        private void LineUserControl_Load(object sender, EventArgs e)
        {

        }


        private void btn_Click(object sender, EventArgs e)
        {
            parentForm = (Form1)this.FindForm();
            parentForm.linebtn_Click(sender, e, line);
            

        }

    }
}
