using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern
{
    class AirConditionReceiver : HomeElectronics
    {
        public void turnOFF()
        {
            Console.WriteLine("Air Condition is OFF");
        }

        public void turnON()
        {
            Console.WriteLine("Air Condition is ON");
        }
    }

}
