using System;

namespace Bosch_Changeover_App
{


    public interface AbstractInformation
    {

        //    protected Queue<Cards> queue;
        //    protected String directoryLocation;

        int calcTimeToFinish(Card part);

        //utilizes the cycle time to approximate time before the last of the part
        //type exits the line


        int calcTimeRemaining(Card part);

        //utilizes the cycle time to approximate time before the part type
        //enters the line


        int calcPartsRemaining(Card part);

        //takes part information from ehijunka completed (total counter) and
        //subtracts from the Access database total parts approximation


        String calcRealWorldApproximation(int time);

        //takes the estimated time variable (Remaining or Finish) and adds it 
        //to the current real world time to approximate the goal time


        String calcNumberofSpanningStations(Card part);

        //checks for how far the part number spans the designated number 
        //of stations in a given line
    }

}