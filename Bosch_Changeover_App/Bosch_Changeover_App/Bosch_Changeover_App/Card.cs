using System;

namespace Bosch_Changeover_App
{


    public class Card
    {
        int timeToFinish;
        int timeRemaining;
        int startStation;
        int endStation;
        int partType;
        Boolean isOnline;
        int partsRemaining;
        int cycleTime;
        int line;


        public Card(int timeToFinish, int timeRemaining, int startStation, int endStation, int partType, Boolean isOnline, int partsRemaining, int cycleTime, int line)
        {
            this.timeToFinish = timeToFinish;
            this.timeRemaining = timeRemaining;
            this.startStation = startStation;
            this.endStation = endStation;
            this.partType = partType;
            this.isOnline = isOnline;
            this.partsRemaining = partsRemaining;
            this.cycleTime = cycleTime;
            this.line = line;
        }

        public int getTimeToFinish()
        {
            return this.timeToFinish;
        }
        public void setTimeToFinish(int setter)
        {
            this.timeToFinish = setter;
        }
        public int getTimeRemaining()
        {
            return this.timeRemaining;
        }
        public void setTimeRemaining(int setter)
        {
            this.timeRemaining = setter;
        }
        public int getStartStation()
        {
            return this.startStation;
        }
        public void setStations(int setter)
        {
            this.startStation = setter;
        }
        public int getEndStation()
        {
            return this.endStation;
        }
        public void setEndStation(int setter)
        {
            this.endStation = setter;
        }
        public int getPartType()
        {
            return this.partType;
        }
        public void setPartType(int setter)
        {
            this.partType = setter;
        }
        public void isOnlineSwitch()
        {
            if (this.isOnline == true)
            {
                this.isOnline = false;
            }
            else
            {
                this.isOnline = true;
            }
        }

        public Boolean checkOnline()
        {
            return this.isOnline;
        }

        public int getPartsRemaining()
        {
            return this.partsRemaining;
        }
        
        public int getLine()
        {
            return this.line;
        }

        public void setPartsRemaining(int setter)
        {
            this.partsRemaining = setter;
        }

        public int getCycletime()
        {
            return this.cycleTime;
        }

        public void setCycleTime(int setter)
        {
            this.cycleTime = setter;
        }

        public void setLine(int line)
        {
            this.line = line;
        }

        public void updateCard(int timeInterval)
        {
            this.timeToFinish -= timeInterval;
            this.timeRemaining -= timeInterval;
        }
            
    }
}