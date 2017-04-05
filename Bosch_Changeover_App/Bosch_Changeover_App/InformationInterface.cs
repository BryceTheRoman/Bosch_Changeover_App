using System;

public interface AbstractInformation
{
    public AbstractInformation()
    {
    }
        protected Queue<Cards> queue;
        protected String directoryLocation;
	
    abstract int calcTimeToFinish(String x)
    {
        //utilizes the cycle time to approximate time before the last of the part
        //type exits the line
    }

    abstract int calcTimeRemaining(String x)
    {
        //utilizes the cycle time to approximate time before the part type
        //enters the line
    }

    abstract int calcPartsRemaining(String x)
    {
        //takes part information from ehijunka completed (total counter) and
        //subtracts from the Access database total parts approximation
    }

    abstract String calcRealWorldApproximation(int time)
    {
        //takes the estimated time variable (Remaining or Finish) and adds it 
        //to the current real world time to approximate the goal time
    } 

    abstract String calcNumberofSpanningStations()
    {
        //checks for how far the part number spans the designated number 
        //of stations in a given line
    }
    }