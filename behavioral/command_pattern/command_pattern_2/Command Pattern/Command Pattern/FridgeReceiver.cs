using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern
{
    class FridgeReceiver : HomeElectronics
    {
        public void turnOFF()
        {
            Console.WriteLine("Fridge is OFF");
        }

        public void turnON()
        {
            Console.WriteLine("Fridge is ON");
        }
    }
}
