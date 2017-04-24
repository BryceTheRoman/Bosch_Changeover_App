using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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

        List<Card> offLine1CardList;
        List<Card> offLine2CardList;
        List<Card> offLine3CardList;

        List<Station> line1StationList;
        List<Station> line2StationList;
        List<Station> line3StationList;

        List<PartAlarm> alarms;

        //Negative stations are ones that can be run in parallel with the adjacent negative station
        public static readonly int[] LINE1_STATIONS = { 02, -18, -16, 12, 14, 20, 24, 28, 29, 30, 32, 38, 22, 40, 42, 142, -44, -46, 34, 51, 52, 58, 60, -62, -64, 66, -84, -85, 86, 65, 68, 70, 71, 72, 74 };
        public static readonly int[] LINE2_STATIONS = { 02, 18, 17, 16, 12, 14, 20, 22, -24, -25, 28, 29, 30, 31, 32, 38, 48, 49, 39, 42, 40, 140, -44, -46, 34, 50, 150, 51, 53, 58, 60, -62, -64, 66, 94, 68, 70, 71, 72, 74 };
        public static readonly int[] LINE3_STATIONS = { 02, -18, -16, 12, 14, 20, 24, 28, 29, 30, 32, 38, 22, 42, 40, 140, -44, -46, 34, 51, 52, 58, 60, -62, -64, 66, 68, 70, 71, 72, 74 };

        public static readonly int TIMER_INTERVAL = 1000;

        List<string> stationComponents;
        string totalCounter;
        string cycleTime;
        string partNumber;
        string lineNumber;
        string stationNumber;



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

            this.offLine1CardList = new List<Card>();
            this.offLine2CardList = new List<Card>();
            this.offLine3CardList = new List<Card>();

            this.alarms = new List<PartAlarm>();

            this.line1StationList = new List<Station>();
            this.line2StationList = new List<Station>();
            this.line3StationList = new List<Station>();

            this.stationComponents = new List<string>();


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


            //update array lists
            //send updated information to form1
            form.update_lines(line1CardList, line2CardList, line3CardList);
        }

        public void addAlarm(PartAlarm pa)
        {
            this.alarms.Add(pa);
        }

        public void removeAlarm(PartAlarm pa)
        {
            this.alarms.Remove(pa);
        }


        public void incorporateStationToCard(Card c, Station s)
        {
            int line = c.getLine();
            if(line != s.getLineNumber())
            {
                return;
            }
            int startStation = c.getStartStation();
            int endStation = c.getEndStation();
            if(line == 1)
            {
                
            }else if(line == 2)
            {

            }else if(line == 3)
            {

            }
        }


        public void initializeAllStations(String directoryPath)
        {

            string[] files = System.IO.Directory.GetFiles(directoryPath, "*ProfileHandler.cs", System.IO.SearchOption.TopDirectoryOnly);
            foreach (string file in files)
            {
                Station newStation = addStation(file);

                int currentLineNumber = newStation.getLineNumber();
                int stationNumber = newStation.getStationNumber();
                if (currentLineNumber == 1)
                {
                    line1StationList.Add(newStation);
                } else if (currentLineNumber == 2){
                    line2StationList.Add(newStation);
                } else {
                    line3StationList.Add(newStation);
                } 
            }

        }


        public void updateAllStations(String directoryPath)   //each timer tick update all stations and see what parts are now held within
        {
            string[] files = System.IO.Directory.GetFiles(directoryPath, "*ProfileHandler.cs", System.IO.SearchOption.TopDirectoryOnly);
            foreach (string file in files)
            {
                Station newStation = addStation(file);


            }
        }

        public void updateStation(Station station)
        {
            int lineNum = station.getLineNumber();
            if(lineNum == 1)
            {
                int index = getStationIndex(station.getStationNumber(), 1);
                

            }else if(lineNum == 2)
            {

            }else if(lineNum == 3)
            {

            }
        }




        public int getStationIndex(int station, int line)
        {

            List<List<Station>> selectableStations = new List<List<Station>>();
            selectableStations.Add(line1StationList);
            selectableStations.Add(line2StationList);
            selectableStations.Add(line3StationList);
            List<Station> termStation = selectableStations[line - 1];
            Station requiredStation = null;

            foreach (Station number in termStation)
            {
                int stationNum = number.getStationNumber();
                if (stationNum == station)
                {
                    requiredStation = number;
                }
            }
            return termStation.IndexOf(requiredStation);
        }


        public Station getStation(int station, int line)
        {
            /*
            String lineSelector = "Line" + line + "CardList";
            List<Station> tempStation;
            if (line == 1)
            {
                tempStation = line1StationList;
            }
            else if (line == 2)
            {
                tempStation = line2StationList;
            }
            else
            {
                tempStation = line3StationList;

            }
            */
            List<List<Station>> selectableStations = new List<List<Station>>();
            selectableStations.Add(line1StationList);
            selectableStations.Add(line2StationList);
            selectableStations.Add(line3StationList);
            List<Station> termStation = selectableStations[line - 1];
            Station requiredStation = null;




            foreach (Station number in termStation)
            {
                int stationNum = number.getStationNumber();
                if (stationNum == station)
                {
                    requiredStation = number;
                }
            }
            return requiredStation;
        }
        public Station addStation(String filename)
        {

            int counter = 0;
            string line;



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

            Station station = new Station(Int32.Parse(stationNumber), Int32.Parse(lineNumber), Int32.Parse(totalCounter), Int32.Parse(cycleTime), Int32.Parse(partNumber));

            return station;

        }

        public Card fillACard()
        {
            return null;
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
