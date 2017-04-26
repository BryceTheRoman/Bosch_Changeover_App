﻿using System;
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
        private Dictionary<int, Button> buttons;

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
            buttons = new Dictionary<int, Button>();
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

        private string convertStoString(int s)
        {
            // Thanks to walther on stackoverflow: http://stackoverflow.com/questions/9993883/convert-milliseconds-to-human-readable-time-lapse
            long ms = s * 1000;
            TimeSpan t = TimeSpan.FromMilliseconds(ms);
            string answer = string.Format("{0:D2}:{1:D2}:{2:D2}",
                                    t.Hours,
                                    t.Minutes,
                                    t.Seconds);
            return answer;
        }

        public void removeButton(Card card)
        {
    /*        if (card.checkOnline())
            {
                addButtontoPanel(card.getPartType(), card.getPartType().ToString() + "          " + card.getPartsRemaining().ToString() + "                " + card.getStartStation().ToString() + "-" + card.getEndStation().ToString() + "        " + convertStoString( card.getTimeToFinish() ), panelOnLine1);

            }
            else
            {
                addButtontoPanel(card.getPartType(), card.getPartType().ToString() + "          " + card.getPartsRemaining().ToString() + "                " + convertStoString( card.getTimeRemaining() ) + "        " + convertStoString( card.getTimeToFinish() ), panelOffLine1);
            }*/
        }

        private void removeButtonFromPanel()
        {

        }

        public void removeAll()
        {
            foreach(Button b in panelOnLine1.Controls)
            {
                panelOnLine1.Controls.Remove(b);
            }
            foreach(Button b in panelOffLine1.Controls){
                panelOffLine1.Controls.Remove(b);
            }
        }

        public void updateAll(List<Card> listCards, List<Card> offLineCards)
        {
            foreach (Card card in listCards)
            {
                buttons[card.getPartType()].Text = card.getPartType().ToString() + "          " + card.getPartsRemaining().ToString() + "                  " + card.getStartStation().ToString() + " - " + card.getEndStation().ToString() + "           " + convertStoString(card.getTimeToFinish());
            }
            foreach (Card card in offLineCards)
            {
                buttons[card.getPartType()].Text = card.getPartType().ToString() + "          " + card.getPartsRemaining().ToString() + "                " + convertStoString(card.getTimeRemaining()) + "        " + convertStoString(card.getTimeToFinish());
            }
        }

        public void addAll(List<Card> listCards, List<Card> offLineCards)
        {
            foreach(Card c in listCards)
            {
                addButton(c);
            }
            foreach(Card c in offLineCards)
            {
                addButton(c);
            }
        }

        public void addButton(Card card)
        {
            if (card.checkOnline())
            {
                addButtontoPanel(card.getPartType(), card.getPartType().ToString() + "          " + card.getPartsRemaining().ToString() + "                  " + card.getStartStation().ToString() + " - " + card.getEndStation().ToString() + "           " + convertStoString(card.getTimeToFinish()), panelOnLine1);

            }
            else
            {
                addButtontoPanel(card.getPartType(), card.getPartType().ToString() + "          " + card.getPartsRemaining().ToString() + "                " + convertStoString(card.getTimeRemaining()) + "        " + convertStoString(card.getTimeToFinish()), panelOffLine1);
            }
        }

        private void addButtontoPanel(int partType, String buttonText, Panel p)
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
            buttons.Add(partType, b);
            

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
