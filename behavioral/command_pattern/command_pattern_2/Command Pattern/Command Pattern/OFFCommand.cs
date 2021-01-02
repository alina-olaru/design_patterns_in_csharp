using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern
{
    class OFFCommand : ICommand
    {
        List<HomeElectronics> homeElectronics;

        public OFFCommand(List<HomeElectronics> homeElectronics)
        {
            this.homeElectronics = homeElectronics;
        }

        public void Execute()
        {
            foreach(HomeElectronics currentHomeElectronic in homeElectronics)
            {
                currentHomeElectronic.turnOFF();
            }
        }
    }
}
