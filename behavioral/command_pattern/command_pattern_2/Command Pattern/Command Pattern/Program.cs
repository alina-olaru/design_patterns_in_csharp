using System;
using System.Collections.Generic;

namespace Command_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {

            LightsReceiver lr = new LightsReceiver();
            AirConditionReceiver airReceiver = new AirConditionReceiver();
            TVReceiver tr = new TVReceiver();
            FridgeReceiver fr = new FridgeReceiver();
            List<HomeElectronics> homeElec = new List<HomeElectronics>();
            homeElec.Add(lr);
            homeElec.Add(airReceiver);
            homeElec.Add(fr);
            homeElec.Add(tr);



            OFFCommand offAll = new OFFCommand(homeElec);
            Invoker inv = new Invoker(offAll);
            inv.Execute();

            ONCommand ONALL = new ONCommand(homeElec);
            inv = new Invoker(ONALL);
            inv.Execute();


        }
    }
}
