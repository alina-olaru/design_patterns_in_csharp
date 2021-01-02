using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern
{
    class LightsReceiver : HomeElectronics
    {
        public void turnOFF()
        {
            Console.WriteLine("Lights are OFF");
        }

        public void turnON()
        {
            Console.WriteLine("Lights are ON");
        }
    }
}
