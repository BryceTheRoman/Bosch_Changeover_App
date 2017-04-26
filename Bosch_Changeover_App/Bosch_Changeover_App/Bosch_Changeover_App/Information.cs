using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Bosch_Changeover_App
{


    public class Information
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

            // string directoryPath = "@blah blah blah Bosch Directory Location";

            offLine1CardList.Add(new Card(597, 74, -1, -1, 1234567899, false, 50, 3, 1));
            line1CardList.Add(new Card(74000, 320, 02, 18, 1234567890, true, 50, 3, 1));
            offLine1CardList.Add(new Card(595, 324, -1, -1, 1234567889, false, 50, 3, 1));
            line1CardList.Add(new Card(74001, 320, 02, 18, 1234567880, true, 50, 3, 1));

            offLine2CardList.Add(new Card(5937, 4324, -1, -1, 1234567899, false, 50, 3, 2));
            line2CardList.Add(new Card(74050, 620, 02, 18, 1234567880, true, 50, 3, 2));
            offLine2CardList.Add(new Card(999, 329, -1, -1, 1234567889, false, 50, 3, 2));
            line2CardList.Add(new Card(74009, 326, 02, 18, 1234567890, true, 50, 3, 2));
            offLine2CardList.Add(new Card(896, 328, -1, -1, 1234567897, false, 50, 3, 2));
            line2CardList.Add(new Card(74008, 320, 02, 18, 1234567780, true, 50, 3, 2));
            offLine2CardList.Add(new Card(320, 324, -1, -1, 1234557789, false, 50, 3, 2));
            offLine2CardList.Add(new Card(635, 222, -1, -1, 1244567789, false, 50, 3, 2));
            offLine2CardList.Add(new Card(780, 123, -1, -1, 1334567789, false, 50, 3, 2));
            offLine2CardList.Add(new Card(952, 624, -1, -1, 1244355789, false, 50, 3, 2));
            offLine2CardList.Add(new Card(1003, 527, -1, -1, 1222257789, false, 50, 3, 2));

            offLine3CardList.Add(new Card(590, 324, -1, -1, 1234567899, false, 50, 3, 3));
            line3CardList.Add(new Card(74002, 320, 02, 18, 1234567890, true, 50, 3, 3));
            form.add_lines(line1CardList, offLine1CardList, line2CardList, offLine2CardList, line3CardList, offLine3CardList);

        }

        private void updateCardLists()
        {
            for (int i = 0; i < this.line1CardList.Count; i++)
            {
                this.line1CardList[i].updateCard(TIMER_INTERVAL / 1000);
            }
            for (int i = 0; i < this.offLine1CardList.Count; i++)
            {
                this.offLine1CardList[i].updateCard(TIMER_INTERVAL / 1000);
            }

            for (int i = 0; i < this.line2CardList.Count; i++)
            {
                this.line2CardList[i].updateCard(TIMER_INTERVAL / 1000);
            }
            for (int i = 0; i < this.offLine2CardList.Count; i++)
            {
                this.offLine2CardList[i].updateCard(TIMER_INTERVAL / 1000);
            }

            for (int i = 0; i < this.line3CardList.Count; i++)
            {
                this.line3CardList[i].updateCard(TIMER_INTERVAL / 1000);
            }
            for (int i = 0; i < this.offLine3CardList.Count; i++)
            {
                this.offLine3CardList[i].updateCard(TIMER_INTERVAL / 1000);
            }




        }


        //timer that controls all updates for the program!
        void timerEvent(Object sender, EventArgs e)
        {
            form.update_currentTime();
            for (int i = 0; i < alarms.Count; i++)
            {
                alarms[i].countDown();
            }
            //read information from files
            updateCardLists();

            //update array lists
            //send updated information to form1
            form.update_lines(line1CardList, offLine1CardList, line2CardList, offLine2CardList, line3CardList, offLine3CardList);

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
            if (line != s.getLineNumber())
            {
                return;
            }
            int startStation = c.getStartStation();
            int endStation = c.getEndStation();
            if (line == 1)
            {

            }
            else if (line == 2)
            {

            }
            else if (line == 3)
            {

            }
        }


        public void initializeAllStations(string directoryPath)
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
                }
                else if (currentLineNumber == 2)
                {
                    line2StationList.Add(newStation);
                }
                else
                {
                    line3StationList.Add(newStation);
                }
            }

        }


        public void updateAllStations(string directoryPath)   //each timer tick update all stations and see what parts are now held within
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
            if (lineNum == 1)
            {
                int index = getStationIndex(station.getStationNumber(), 1);


            }
            else if (lineNum == 2)
            {

            }
            else if (lineNum == 3)
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
        public Station addStation(string filename)
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

        public int lineCycleTime(List<Station> line)
        {
            return 1;
        }

        public void distinctPartNum(List<Station> line)
        {
            List<int> parts = new List<int>();
            int cycleTimeForLine = line[1].getCycleTime();
            int lineNumbForPart = line[1].getLineNumber();

            List<int[]> possibleStations = new List<int[]>();
            possibleStations.Add(LINE1_STATIONS);
            possibleStations.Add(LINE2_STATIONS);
            possibleStations.Add(LINE3_STATIONS);

            foreach (Station station in line)
            {
                int name = station.getCurrentPart();
                if (parts.Contains(name) == false)
                {
                    parts.Add(name);
                }
            }

            int number = parts.Count;



            foreach (int partnum in parts)
            {
                Card card = new Card(0, 0, 0, 0, partnum, false, 0, 0, 0);
                card.setCycleTime(cycleTimeForLine);
                card.setLine(lineNumbForPart);
                if (card.getStartStation() > 0 && card.checkOnline() == false)
                {
                    card.isOnlineSwitch();
                }


                // card.setStations();
                foreach (Station station in line)
                {
                    int[] tempPoss = possibleStations[lineNumbForPart - 1];
                    int lookingPart = station.getCurrentPart();
                    //if (tempPoss.Contains(look))
                    int setStartStation;
                    int setEndStation;
                }



                //card.setEndStation();


                //tempCard.Add(card);




            }
        }

        /*        public Card fillAllCards(List<Station> line)
                {
                    int distinctCards = 0;
                    List<string> disCards;
                    for (int i = 0; i < line.Capacity; i++)
                    {
                        if (disCards.Contains(Int32.Parse(line[i].getCurrentPart())))
                        {

                        }
                    }

                }*/



        public Card fillACard()
        {




            Card createdCard = null;

            return createdCard;
        }

        public Card getCard(string partType, int line)
        {
            if (line == 1)
            {
                //look through line lists to get the part type card
                for (int i = 0; i < offLine1CardList.Count; i++)
                {
                    if (offLine1CardList[i].getPartType().ToString() == partType)
                    {
                        return offLine1CardList[i];
                    }
                }
            }

            else if (line == 2)
            {
                for (int i = 0; i < offLine2CardList.Count; i++)
                {
                    if (offLine2CardList[i].getPartType().ToString() == partType)
                    {
                        return offLine2CardList[i];
                    }
                }
            }
            else if (line == 3)
            {
                for (int i = 0; i < offLine3CardList.Count; i++)
                {
                    if (offLine3CardList[i].getPartType().ToString() == partType)
                    {
                        return offLine3CardList[i];
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

        public int calcTimeRemaining()
        {
            return -1;
        }

        public int calcTimeToFinish(Card part)
        {
            return 0;
        }


        public static void main(string[] args)
        {

        }
    }

}
