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
        List<PartAlarm> alarmsNotQueued;

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

        string userEmail = "bosch.changeover@gmail.com";
        bool sendDefault = true;
        bool desktopAlarmDefault = true;
        int test = 0;


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
            this.alarmsNotQueued = new List<PartAlarm>();

            this.line1StationList = new List<Station>();
            this.line2StationList = new List<Station>();
            this.line3StationList = new List<Station>();

            // string directoryPath = "@blah blah blah Bosch Directory Location";
            
            offLine1CardList.Add(new Card(597, 10, -1, -1, 11178990, false, 20, 3, 1));
            line1CardList.Add(new Card(4, 320, 02, 18, 1234567890, true, 32, 3, 1));
            offLine1CardList.Add(new Card(595, 324, -1, -1, 1234567889, false, 26, 3, 1));
            line1CardList.Add(new Card(74001, 320, Math.Abs(LINE1_STATIONS[2]), Math.Abs(LINE1_STATIONS[3]) , 1234567880, true, 16, 3, 1));
            offLine1CardList.Add(new Card(595, 324, -1, -1, 1836567889, false, 101, 3, 1));
            offLine1CardList.Add(new Card(595, 334, -1, -1, 1234501989, false, 35, 3, 1));
            offLine1CardList.Add(new Card(595, 354, -1, -1, 1234395889, false, 204, 3, 1));
            offLine1CardList.Add(new Card(595, 362, -1, -1, 1234567204, false, 11, 3, 1));
            offLine1CardList.Add(new Card(595, 389, -1, -1, 1234567172, false, 16, 3, 1));
            offLine1CardList.Add(new Card(595, 405, -1, -1, 1234538289, false, 34, 3, 1));

            offLine2CardList.Add(new Card(5937, 4, -1, -1, 9933333333, false, 10, 3, 2));
            line2CardList.Add(new Card(740050, 74, 02, 18, 1234567880, true, 23, 3, 2));
            offLine2CardList.Add(new Card(999, 329, -1, -1, 1222222222, false, 12, 3, 2));
            line2CardList.Add(new Card(74009, 326, 17, 16, 1234567890, true, 14, 3, 2));
            offLine2CardList.Add(new Card(896, 330, -1, -1, 1333333333, false, 13, 3, 2));
            line2CardList.Add(new Card(74008, 320, 12, 14, 1234567780, true, 36, 3, 2));
            offLine2CardList.Add(new Card(320, 350, -1, -1, 1444444444, false, 24, 3, 2));
            offLine2CardList.Add(new Card(635, 376, -1, -1, 1555555555, false, 52, 3, 2));
            offLine2CardList.Add(new Card(780, 2, -1, -1, 1666666666, false, 27, 3, 2));
            offLine2CardList.Add(new Card(952, 624, -1, -1, 1777777777, false, 32, 3, 2));
            offLine2CardList.Add(new Card(1003, 527, -1, -1, 1888888888, false, 44, 3, 2));

            offLine3CardList.Add(new Card(590, 22, -1, -1, 1234567899, false, 12, 3, 3));
            line3CardList.Add(new Card(74002, 320, 02, 18, 1234567890, true, 50, 3, 3));
            offLine3CardList.Add(new Card(830, 10, -1, -1, 1234567869, false, 11, 3, 3));
            offLine3CardList.Add(new Card(860, 20, -1, -1, 1234564899, false, 8, 3, 3));
            offLine3CardList.Add(new Card(890, 27, -1, -1, 1234367899, false, 26, 3, 3));
            offLine3CardList.Add(new Card(990, 38, -1, -1, 1234557899, false, 45, 3, 3));
            offLine3CardList.Add(new Card(1070, 42, -1, -1, 1233567899, false, 72, 3, 3));
            offLine3CardList.Add(new Card(1101, 56, -1, -1, 1232201899, false, 34, 3, 3));
            offLine3CardList.Add(new Card(1235, 63, -1, -1, 1235877899, false, 52, 3, 3));
            offLine3CardList.Add(new Card(1700, 102, -1, -1, 1231037899, false, 101, 3, 3));
            offLine3CardList.Add(new Card(1800, 200, -1, -1, 1232877899, false, 123, 3, 3));
            offLine3CardList.Add(new Card(2105, 359, -1, -1, 1232599099, false, 142, 3, 3));
            offLine3CardList.Add(new Card(3000, 720, -1, -1, 1234728499, false, 162, 3, 3));
            form.add_lines(line1CardList, offLine1CardList, line2CardList, offLine2CardList, line3CardList, offLine3CardList);

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

            if (test == 9)
            {
                offLine2CardList.Add(new Card(3000, 720, -1, -1, 1111111111, false, 162, 3, 2));
            }


            //update array lists
            //send updated information to form1
            form.update_lines(line1CardList, offLine1CardList, line2CardList, offLine2CardList, line3CardList, offLine3CardList);

            updateAlarmsNotQueued();

            test++;
        }



        private void updateCardLists()
        {
            for (int i = 0; i < this.line1CardList.Count; i++)
            {
                this.line1CardList[i].updateCard(TIMER_INTERVAL / 1000);
                int timeOff = this.line1CardList[i].getTimeToFinish();
                if(timeOff <= 0)
                {
                    this.line1CardList.RemoveAt(i);
                }
                
            }
            for (int i = 0; i < this.offLine1CardList.Count; i++)
            {
                this.offLine1CardList[i].updateCard(TIMER_INTERVAL / 1000);
                int timeRem = this.offLine1CardList[i].getTimeRemaining();
                if (timeRem <= 0)
                {
                    Card lastCard = this.line1CardList[line1CardList.Count() - 1];
                    int lastStat = lastCard.getEndStation();
                    Card card = this.offLine1CardList[i];
                    this.offLine1CardList.RemoveAt(i);
                    card.isOnlineSwitch();
                    this.line1CardList.Add(card);



                    for (int j = 0; j < LINE1_STATIONS.Length; j++)
                    {
                        if (Math.Abs(LINE1_STATIONS[j]) == Math.Abs(lastStat))
                        {
                            card.setStations(Math.Abs(LINE1_STATIONS[j + 1]));
                            card.setEndStation(Math.Abs(LINE1_STATIONS[j + 2]));
                        }
                    }
                }
            }

            for (int i = 0; i < this.line2CardList.Count; i++)
            {
                this.line2CardList[i].updateCard(TIMER_INTERVAL / 1000);
                int timeOff = this.line2CardList[i].getTimeToFinish();
                if (timeOff <= 0)
                {
                    this.line2CardList.RemoveAt(i);
                }
            }
            for (int i = 0; i < this.offLine2CardList.Count; i++)
            {
                this.offLine2CardList[i].updateCard(TIMER_INTERVAL / 1000);
                int timeRem = this.offLine2CardList[i].getTimeRemaining();

                if (timeRem <= 0)
                {
                    Card lastCard = this.line2CardList[line2CardList.Count() - 1];
                    int lastStat = lastCard.getEndStation();
                    Card card = this.offLine2CardList[i];
                    this.offLine2CardList.RemoveAt(i);
                    card.isOnlineSwitch();
                    this.line2CardList.Add(card);


                 
                   for (int j = 0; j < LINE2_STATIONS.Length; j++)
                    {
                        if (Math.Abs(LINE2_STATIONS[j]) == Math.Abs(lastStat))
                        {
                            card.setStations(Math.Abs(LINE2_STATIONS[j + 1]));
                            card.setEndStation(Math.Abs(LINE2_STATIONS[j + 2]));
                        }
                    }
                }
            }

            for (int i = 0; i < this.line3CardList.Count; i++)
            {
                this.line3CardList[i].updateCard(TIMER_INTERVAL / 1000);
                int timeOff = this.line3CardList[i].getTimeToFinish();
                if (timeOff <= 0)
                {
                    this.line3CardList.RemoveAt(i);
                }
            }
            for (int i = 0; i < this.offLine3CardList.Count; i++)
            {
                this.offLine3CardList[i].updateCard(TIMER_INTERVAL / 1000);
                int timeRem = this.offLine3CardList[i].getTimeRemaining();
                if (timeRem <= 0)
                {
                    Card lastCard = this.line3CardList[line3CardList.Count() - 1];
                    int lastStat = lastCard.getEndStation();
                    Card card = this.offLine3CardList[i];
                    this.offLine3CardList.RemoveAt(i);
                    card.isOnlineSwitch();
                    this.line3CardList.Add(card);



                    for (int j = 0; j < LINE3_STATIONS.Length; j++)
                    {
                        if (Math.Abs(LINE3_STATIONS[j]) == Math.Abs(lastStat))
                        {
                            card.setStations(Math.Abs(LINE3_STATIONS[j + 1]));
                            card.setEndStation(Math.Abs(LINE3_STATIONS[j + 2]));
                        }
                    }

                    /*
                    Random rnd = new Random();
                    int partNum = rnd.Next(1000000000, 2000000000);

                    Card newCard = new Card(offLine3CardList[offLine3CardList.Count - 1].getTimeToFinish() + 10, 
                        offLine3CardList[offLine3CardList.Count - 1].getTimeRemaining() + 10, -1,-1, partNum,false, 50, 3, 3);


                    offLine3CardList.Add(newCard);
                    */

                }

            }

        }





        private void updateAlarmsNotQueued()
        {
            List<int> index = new List<int>();
            List<Card> cards = new List<Card>();
            foreach (PartAlarm pa in this.alarmsNotQueued)
            {
                Card inLine1 = getCard(pa.getPartType(), 1);
                Card inLine2 = getCard(pa.getPartType(), 2);
                Card inLine3 = getCard(pa.getPartType(), 3);

                if(pa.doesCardMatch(inLine1))
                {
                    index.Add(this.alarmsNotQueued.IndexOf(pa));
                    cards.Add(inLine1);
                }
                else if(pa.doesCardMatch(inLine2))
                {
                    index.Add(this.alarmsNotQueued.IndexOf(pa));
                    cards.Add(inLine2);
                }
                else if(pa.doesCardMatch(inLine3))
                {
                    index.Add(this.alarmsNotQueued.IndexOf(pa));
                    cards.Add(inLine3);
                }
            }

            foreach(int i in index)
            {
                form.personalAlarmIsInQueue(alarmsNotQueued[i], cards[i]);
            }
        }

        public void addAlarm(PartAlarm pa)
        {
            this.alarms.Add(pa);
        }

        public void addAlarmNotQueued(PartAlarm pa)
        {
            this.alarmsNotQueued.Add(pa);
        }

        public void removeAlarm(PartAlarm pa)
        {
            this.alarms.Remove(pa);
        }

        public void removeUnqueuedAlarm(PartAlarm pa)
        {
            this.alarmsNotQueued.Remove(pa);
        }

        public bool isUnqueued(PartAlarm pa)
        {
            return this.alarmsNotQueued.Contains(pa);
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
                    int currentEndStation;



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
                    if (offLine1CardList[i].getPartType().ToString("0000000000") == partType)
                    {
                        return offLine1CardList[i];
                    }
                }
            }

            else if (line == 2)
            {
                for (int i = 0; i < offLine2CardList.Count; i++)
                {
                    if (offLine2CardList[i].getPartType().ToString("0000000000") == partType)
                    {
                        return offLine2CardList[i];
                    }
                }
            }
            else if (line == 3)
            {
                for (int i = 0; i < offLine3CardList.Count; i++)
                {
                    if (offLine3CardList[i].getPartType().ToString("0000000000") == partType)
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


        public string getUserEmail()
        {
            return userEmail;
        }

        public void setUserEmail(string email)
        {
            userEmail = email;
        }

        public void setSendDefault(bool byDefault)
        {
            this.sendDefault = byDefault;
        }

        public bool getSendDefault()
        {
            return this.sendDefault;
        }

        public void setDesktopAlarmDefault(bool byDefault)
        {
            this.desktopAlarmDefault = byDefault;
        }

        public bool getDesktopAlarmDefault()
        {
            return this.desktopAlarmDefault;
        }

        public static void main(string[] args)
        {

        }
    }

}
