using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern
{
    public abstract class OrderCommand
    {
        public abstract void Execute(List<MenuItem> order, MenuItem newItem);
    }
}
