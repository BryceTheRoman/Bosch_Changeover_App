using System;

namespace Bosch_Changeover_App
{


    public class Information : AbstractInformation
    {

        public Information(Form1 form)
        {

        }

        public Card getCard(String partType)
        {
            return new Card(0,0,0,0,0,true,0,0,0);
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
            return 0;
        }

        public int calcTimeToFinish(Card part)
        {
            return 0;
        }
    }
}
