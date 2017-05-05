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



/*
 *  This class contains the code for taking in a list of cards and updating the parts shown on the lines.
 */


namespace Bosch_Changeover_App
{
    public partial class LineUserControl : UserControl
    {
    //    private static LineUserControl _instance;
        private Form1 parentForm;
        private Dictionary<long, Button> buttons;

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
            buttons = new Dictionary<long, Button>();

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


        private void removeButtonFromPanel(Button b, Panel p)
        {
            p.Controls.Remove(b);
        }

        public void removeAll()
        {
            foreach(Button b in panelOnLine1.Controls)
            {
                panelOnLine1.Controls.Remove(b);
            }
            buttons = new Dictionary<long, Button>();
            foreach(Button b in panelOffLine1.Controls){
                panelOffLine1.Controls.Remove(b);
            }
        }

        private void getButtonIndexFromPanel(List<Button> temp, Panel original)
        {
            foreach (Button b in original.Controls)
            {
                temp.Add(b);
            }
        }

        public void updateAll(List<Card> listCards, List<Card> offLineCards)
        {
            List<int> removed = new List<int>();

            List<long> keyList = new List<long>(this.buttons.Keys); //remove the ones that show up in the cards lists, anything that's left needs to be removed

            List<Button> tempOffLine = new List<Button>();
            List<Button> tempOnLine = new List<Button>();
            getButtonIndexFromPanel(tempOffLine, panelOffLine1);
            getButtonIndexFromPanel(tempOnLine, panelOnLine1);
            foreach (Card card in listCards)
            {
                if (!buttons.ContainsKey(card.getPartType()))
                {
                    addButton(card);
                }
                else
                {
                    Button b = buttons[card.getPartType()];


                    string text = card.getPartType().ToString("0000000000") + "          " + card.getPartsRemaining().ToString() + "                  " + card.getStartStation().ToString() + " - " + card.getEndStation().ToString() + "           " + convertStoString(card.getTimeToFinish());
                    if (panelOffLine1.Contains(b))
                    {
                        removed.Add(tempOffLine.IndexOf(b));
                        panelOffLine1.Controls.Remove(b);
                        buttons.Remove(card.getPartType());
                        addButtontoPanel(card.getPartType(), text, panelOnLine1);
                    }
                    else
                    {
                        b.Text = text;
                    }
                    keyList.Remove(card.getPartType());
                }
            }

            foreach (Card card in offLineCards)
            {
                if (!buttons.ContainsKey(card.getPartType()))
                {
                    addButton(card);
                }
                else
                {
                    Button b = buttons[card.getPartType()];

                    int numberAbove = 0;    //number of buttons above the current one that have been removed, need to know how much to move it up
                    foreach (int index in removed)
                    {
                        if (index < tempOffLine.IndexOf(b))
                        {
                            numberAbove++;
                        }
                    }
                    b.Location = new Point(b.Location.X, b.Location.Y - numberAbove * (b.Height + 5));
                    b.Text = card.getPartType().ToString("0000000000") + "          " + card.getPartsRemaining().ToString() + "                " + convertStoString(card.getTimeRemaining()) + "        " + convertStoString(card.getTimeToFinish());
                    keyList.Remove(card.getPartType());
                }
            }

            int removed_onLineButtons = 0;
            foreach (long buttonKey in buttons.Keys)   //remove any keys left in keylist since they never show up in the cards list, they have been deleted
            {
                if (panelOnLine1.Controls.Contains(buttons[buttonKey]))
                {
                    if (keyList.Contains(buttonKey))
                    {
                        panelOnLine1.Controls.Remove(buttons[buttonKey]);
                        removed_onLineButtons++;
                    }
                }
            }

            foreach (Button b in panelOnLine1.Controls)    //move up the buttons if a key has been deleted
            {
                b.Location = new Point(b.Location.X, b.Location.Y - removed_onLineButtons * (b.Height + 5));
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
                addButtontoPanel(card.getPartType(), card.getPartType().ToString("0000000000") + "          " + card.getPartsRemaining().ToString() + "                  " + card.getStartStation().ToString() + " - " + card.getEndStation().ToString() + "           " + convertStoString(card.getTimeToFinish()), panelOnLine1);

            }
            else
            {
                addButtontoPanel(card.getPartType(), card.getPartType().ToString("0000000000") + "          " + card.getPartsRemaining().ToString() + "                " + convertStoString(card.getTimeRemaining()) + "        " + convertStoString(card.getTimeToFinish()), panelOffLine1);
            }
        }

        private void addButtontoPanel(long partType, String buttonText, Panel p)
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

            //add the new button to the buttons list
            buttons.Add(partType, b);
            

        }

       // private List<Button> checkForDuplicates(long partType)
     //   {
 //           List<Button>
   //     }

        private void addOneButtonToPanel(Button b, Panel p)
        {

            int numButtons = p.Controls.Count;
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
