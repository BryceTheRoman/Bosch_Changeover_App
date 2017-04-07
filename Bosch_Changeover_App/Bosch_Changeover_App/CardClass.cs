using System;

public class Card
{
    int timeToFinish;
    int timeRemaining;
    string stations;
    int partType;
    Boolean isOnline;
    int partsRemaining;
    int cycleTime;


    public Card(int timeToFinish, int timeRemaining, string stations, int partType, Boolean isOnline, int partsRemaining, int cycleTime)
    {
        this.timeToFinish = timeToFinish;
        this.timeRemaining = timeRemaining;
        this.stations = stations;
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
    public String getStations()
    {
        return this.stations;
    }
    public void setStations(String setter)
    {
        this.stations = setter;
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