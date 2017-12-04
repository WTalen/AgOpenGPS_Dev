using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgOpenGPS
{
    public class CSequence
    {
        private readonly FormGPS mf;

        //an array of events to take place
        public SeqEvent[] seqEnter;
        public SeqEvent[] seqExit;

        public struct SeqEvent
        {
            public int function; //event name
            public int action; //where in the turn procedure
            public bool isTrig;
            public double distance; //trigger distance to turn on

            public SeqEvent(int function, int action, bool isTrig, double distance)
            {
                this.function = function;
                this.action = action;
                this.isTrig = isTrig;
                this.distance = distance;
            }
        }

        //constructor
        public CSequence(FormGPS _f)
        {
            mf = _f;

            seqEnter = new SeqEvent[5];
            for (int i = 0; i < 5; i++)
            {
                seqEnter[i].function = 0;
                seqEnter[i].action = 0;
                seqEnter[i].isTrig = true;
                seqEnter[i].distance = 0;
            }

            seqExit = new SeqEvent[5];
            for (int i = 0; i < 5; i++)
            {
                seqExit[i].function = 0;
                seqExit[i].action = 0;
                seqExit[i].isTrig = true;
                seqExit[i].distance = 0;
            }
        }

        public void DisableSeqEvent(int index, bool isEnter)
        {
            if (isEnter)
            {
                seqExit[index].function = 0;
                seqExit[index].action = 0;
                seqExit[index].isTrig = true;
                seqExit[index].distance = 0;
            }
            else
            {
                seqExit[index].function = 0;
                seqExit[index].action = 0;
                seqExit[index].isTrig = true;
                seqExit[index].distance = 0;
            }
        }
    }
}
