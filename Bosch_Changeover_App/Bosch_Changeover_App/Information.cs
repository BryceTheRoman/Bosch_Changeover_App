using System;
using System.Collections.Generic;

namespace Bosch_Changeover_App
{


    public class Information : AbstractInformation
    {
        Form1 form;
        List<Card> line1List;
        List<Card> line2List;
        List<Card> line3List;
        public static readonly int TIMER_INTERVAL = 1000;
        public Information(Form1 form)
        {
            this.form = form;
            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
            t.Interval = TIMER_INTERVAL;
            t.Tick += new EventHandler(timerEvent);
            t.Start();

            this.line1List = new List<Card>();
            this.line2List = new List<Card>();
            this.line3List = new List<Card>();
        }

        void timerEvent(Object sender, EventArgs e)
        {
            form.update_currentTime();

            //read information from files
            //update array lists
            //send updated information to form1
        }

        public Card getCard(String partType, int line)
        {
            if (line == 1)
            {
                //look through line lists to get the part type card
                for (int i = 0; i < line1List.Count; i++)
                {
                    if (line1List[i].getPartType().ToString() == partType)
                    {
                        return line1List[i];
                    }
                }
            }

            else if (line == 2)
            {
                for (int i = 0; i < line2List.Count; i++)
                {
                    if (line2List[i].getPartType().ToString() == partType)
                    {
                        return line2List[i];
                    }
                }
            }
            else if (line == 3)
            {
                for (int i = 0; i < line3List.Count; i++)
                {
                    if (line3List[i].getPartType().ToString() == partType)
                    {
                        return line3List[i];
                    }
                }
            }
            return null;
            
        }

        public string calcNumberofSpanningStations(Card part)
        {
            return "";
        }

        public int calcPartsRemaining(Card part)
        {
            return 0;
        }

        public string calcRealWorldApproximation(int time)
        {
            return "";
        }

        public int calcTimeRemaining(Card part)
        {
            return 0;
        }

        public int calcTimeToFinish(Card part)
        {
            return 0;
        }
    }
}
