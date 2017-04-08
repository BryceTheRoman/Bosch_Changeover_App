using System;

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


    public Card(int timeToFinish, int timeRemaining, int startStation, int endStation, int partType, Boolean isOnline, int partsRemaining, int cycleTime)
    {
        this.timeToFinish = timeToFinish;
        this.timeRemaining = timeRemaining;
        this.startStation = startStation;
        this.endStation = endStation;
        this.partType = partType;
        this.isOnline = isOnline;
        this.partsRemaining = partsRemaining;
        this.cycleTime = cycleTime;
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

}