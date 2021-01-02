using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern
{
    public interface HomeElectronics
    {
        public abstract void turnON();
        public abstract void turnOFF();
    }
}
