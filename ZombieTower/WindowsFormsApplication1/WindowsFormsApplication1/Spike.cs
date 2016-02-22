using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Pit : Trap
    {
        private int VictimsToFill;
        private int currentVictims;
        private Boolean isFull;

        public void CheckIfPitIsFull()
        {
            if (currentVictims >= VictimsToFill)
            {
                isFull = true;
            }
            else
            {
                isFull = false;
            }


        }
    }
}
