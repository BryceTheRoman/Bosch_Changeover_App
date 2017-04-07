using System;

public class Station
{

    int stationNumber;
    int lineNumber;
    int totalCreated;
    int cycleTime;
    int currentPart;

    public Station(int stationNumber, int lineNumber, int totalCreated, int cycleTime, int currentPart)
    {
        this.stationNumber = stationNumber;
        this.lineNumber = lineNumber;
        this.totalCreated = totalCreated;
        this.cycleTime = cycleTime;
        this.currentPart = currentPart;

    }

    public int getStationNumber()
    {
        return this.stationNumber;
    }
    public void setStationNumber(int setter)
    {
        this.stationNumber = setter;
    }
    public int getLineNumber()
    {
        return this.lineNumber;
    }
    public void setLineNumber(int setter)
    {
        this.lineNumber = setter;
    }
    public int getTotalCreated()
    {
        return this.totalCreated;
    }
    public void setTotalCreated(int setter)
    {
        this.totalCreated = setter;
    }
    public int getCycleTime()
    {
        return this.cycleTime;
    }

    public void setCycleTime(int setter)
    {
        this.cycleTime = setter;
    }
    public int getCurrentPart()
    {
        return this.currentPart;
    }
    public void setCurrentPart(int setter)
    {
        this.currentPart = setter;
    }




}