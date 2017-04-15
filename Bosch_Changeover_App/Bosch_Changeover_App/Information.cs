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


    public class Information : AbstractInformation
    {
        Form1 form;
        List<Card> line1List;
        List<Card> line2List;
        List<Card> line3List;
        List<PartAlarm> alarms;
        public static readonly int TIMER_INTERVAL = 1000;




        public Information(Form1 form)
        {
            this.form = form;

            //Create Timer Object
            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
            t.Interval = TIMER_INTERVAL;
            t.Tick += new EventHandler(timerEvent);
            t.Start();

            this.line1List = new List<Card>();
            this.line2List = new List<Card>();
            this.line3List = new List<Card>();
            this.alarms = new List<PartAlarm>();
        }



        //timer that controls all updates for the program!
        void timerEvent(Object sender, EventArgs e)
        {
            form.update_currentTime();
            for( int i = 0; i< this.alarms.Count; i++)
            {

            }
            //read information from files


            //update array lists
            //send updated information to form1
        }

        public void addAlarm(PartAlarm pa)
        {
            this.alarms.Add(pa);
        }

        public void removeAlarm(PartAlarm pa)
        {
            this.alarms.Remove(pa);
        }

        public int hasCard(int partType)
        {
            foreach(Card c in line1List)
            {
                if(c.getPartType() == partType)
                {
                    return 1;
                }
            }
            foreach (Card c in line2List)
            {
                if (c.getPartType() == partType)
                {
                    return 2;
                }
            }
            foreach (Card c in line3List)
            {
                if (c.getPartType() == partType)
                {
                    return 3;
                }
            }
            return -1;
        }

        public void updateAlarms()
        {

        }

        /*
        public Station getStation(String filename)
        {
            int counter = 0;
            string line;

            int totalCounter;
            int cycleTime;
            int partNumber;
            string lineNumber;
            int stationNumber;

            string[] keywords = { "LineNr:", "PartNrVar:", "TotalCounter:", "CycleTime" };
            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(filename);
            while ((line = file.ReadLine()) != null)
            {

                    if (line.Contains(keywords[0]))
                    {
                        line.Replace(" ", string.Empty);
                        int startPos = line.LastIndexOf(keywords[0]) + 1;
                        int length = line.Length;
                        string temp = line.Substring(5,length);
                        string lineNumber = temp;
                    }
                    if (line.Contains(keywords[1]))
                    {
                        line.Replace(" ", string.Empty);
                        int startPos = line.LastIndexOf(keywords[0]) + 1;
                        int length = line.Length;
                        string temp = line.Substring(5, length);
                        string partNumber = temp;
                    }
                    if (line.Contains(keywords[2]))
                    {
                        line.Replace(" ", string.Empty);
                        int startPos = line.LastIndexOf(keywords[0]) + 1;
                        int length = line.Length;
                        string temp = line.Substring(5, length);
                        string totalCounter = temp;
                    }
                    if (line.Contains(keywords[3]))
                    {
                        line.Replace(" ", string.Empty);
                        int startPos = line.LastIndexOf(keywords[0]) + 1;
                        int length = line.Length;
                        string temp = line.Substring(5, length);
                        string cycleTime = temp;
                    }
                
                counter++;
            }

            file.Close();

            string stationTitle = "Station " + stationNumber;
            Station station = new Station(stationNumber, lineNumber, totalCounter, cycleTime, partNumber);

        }

    */
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

        public void addCard(Card c)
        {
            if (c.getLine() == 1)
            {
                this.line1List.Add(c);
            }
            else if (c.getLine() == 2)
            {
                this.line2List.Add(c);
            }
            else
            {
                this.line3List.Add(c);
            }
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
            return -1;
        }

        public int calcTimeToFinish(Card part)
        {
            return 0;
        }
        public static void main(String [] args){

}
    }

}
