using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern
{
    class ONCommand : ICommand
    {
        List<HomeElectronics> homeElectronics;

        public ONCommand(List<HomeElectronics> homeElectronics)
        {
            this.homeElectronics = homeElectronics;
        }

        public void Execute()
        {
           foreach(HomeElectronics currentHomeElectronic in homeElectronics)
            {
                currentHomeElectronic.turnON();
            }
        }
    }
}
