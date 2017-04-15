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
        List<Card> line1CardList;
        List<Card> line2CardList;
        List<Card> line3CardList;
         
        List<Station> line1StationList;
        List<Station> line2StationList;
        List<Station> line3StationList;

        List<PartAlarm> alarms;
        public static readonly int TIMER_INTERVAL = 1000;


        List<string> stationComponents;
        string totalCounter;
        string cycleTime;
        string partNumber;
        string lineNumber;



        public Information(Form1 form)
        {
            this.form = form;

            //Create Timer Object
            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
            t.Interval = TIMER_INTERVAL;
            t.Tick += new EventHandler(timerEvent);
            t.Start();

            this.line1CardList = new List<Card>();
            this.line2CardList = new List<Card>();
            this.line3CardList = new List<Card>();
            this.alarms = new List<PartAlarm>();

            this.line1StationList = new List<Station>();
            this.line2StationList = new List<Station>();
            this.line3StationList = new List<Station>();

           
        
            // string directoryPath = "@blah blah blah Bosch Directory Location";


        }



        //timer that controls all updates for the program!
        void timerEvent(Object sender, EventArgs e)
        {
            form.update_currentTime();
            for( int i = 0; i< this.alarms.Count; i++)
            {

            }
            //read information from files
            while ()
            {

            }

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
        public Station getAllStations(String directoryPath)
        {
            while (System.IO.Directory.Exists(directoryName){
                List<string> fileList;
                fileList.Add(System.IO.Directory.GetFiles);

                string stationTitle = "Station " + stationNumber;.
                Station station = new Station(stationNumber, lineNumber, totalCounter, cycleTime, partNumber);


            }
            return null;
        }
        
        public void addStation(String filename)
        {

            int counter = 0;
            string line;

            List<string> stationComponents;
            string totalCounter;
            string cycleTime;
            string partNumber;
            string lineNumber;

            int lastIndex = filename.IndexOf(".dat") - 1;
            int firstIndex = filename.LastIndexOf("MCD_") + 1;
            string stationNumber = filename.Substring(firstIndex, lastIndex);


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
                        string tempLineNumber = line.Substring(startPos, length);
                        lineNumber = tempLineNumber;
                    }
                    if (line.Contains(keywords[1]))
                    {
                        line.Replace(" ", string.Empty);
                        int startPos = line.LastIndexOf(keywords[0]) + 1;
                        int length = line.Length;
                        string tempPartNumber = line.Substring(startPos, length);
                        partNumber = tempPartNumber;
                    }
                    if (line.Contains(keywords[2]))
                    {
                        line.Replace(" ", string.Empty);
                        int startPos = line.LastIndexOf(keywords[0]) + 1;
                        int length = line.Length;
                        string temp = line.Substring(startPos, length);
                        totalCounter = temp;
                    }
                    if (line.Contains(keywords[3]))
                    {
                        line.Replace(" ", string.Empty);
                        int startPos = line.LastIndexOf(keywords[0]) + 1;
                        int length = line.Length;
                        string tempCycleTime = line.Substring(startPos, length);
                         cycleTime = tempCycleTime;
                    }
                
                counter++;
            }



            file.Close();

            
            stationComponents.Add(stationNumber);
            stationComponents.Add(lineNumber);
            stationComponents.Add(totalCounter);
            stationComponents.Add(cycleTime);
            stationComponents.Add(partNumber);

        }

    
        public Card getCard(String partType, int line)
        {
            if (line == 1)
            {
                //look through line lists to get the part type card
                for (int i = 0; i < line1CardList.Count; i++)
                {
                    if (line1CardList[i].getPartType().ToString() == partType)
                    {
                        return line1CardList[i];
                    }
                }
            }

            else if (line == 2)
            {
                for (int i = 0; i < line2CardList.Count; i++)
                {
                    if (line2CardList[i].getPartType().ToString() == partType)
                    {
                        return line2CardList[i];
                    }
                }
            }
            else if (line == 3)
            {
                for (int i = 0; i < line3CardList.Count; i++)
                {
                    if (line3CardList[i].getPartType().ToString() == partType)
                    {
                        return line3CardList[i];
                    }
                }
            }
            return null;
            
        }

        public void addCard(Card c)
        {
            if (c.getLine() == 1)
            {
                this.line1CardList.Add(c);
            }
            else if (c.getLine() == 2)
            {
                this.line2CardList.Add(c);
            }
            else
            {
                this.line3CardList.Add(c);
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
