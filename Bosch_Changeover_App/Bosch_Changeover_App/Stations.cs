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
        return 0;
    }
    public void setStationNumber(int setter)
    {
        this.stationNumber = setter;
    }
    public int getLineNumber()
    {
        return 0;
    }
    public void setLineNumber(int setter)
    {
        this.lineNumber = setter;
    }
    public int getTotalCreated()
    {
        return 0;
    }
    public int setTotalCreated(int setter)
    {
        this.totalCreated = setter;
        return 0;
    }
    public int getCycleTime()
    {
        return 0;
    }
    public void setCycleTime(int setter)
    {
        this.cycleTime = setter;
    }
    public int getCurrentPart()
    {
        return 0;
    }
    public void setCurrentPart(int setter)
    {
        this.currentPart = setter;
    }




}