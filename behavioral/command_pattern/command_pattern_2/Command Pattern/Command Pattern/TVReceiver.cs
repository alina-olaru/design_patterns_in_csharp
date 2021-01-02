using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern
{
    class TVReceiver : HomeElectronics
    {
        public void turnOFF()
        {
            Console.WriteLine("TV is OFF");
        }

        public void turnON()
        {
            Console.WriteLine("TV is ON");
        }
    }
}
