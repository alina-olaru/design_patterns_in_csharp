using System;
using System.Collections.Generic;
using System.Text;

namespace strategy_design_pattern
{
    public interface IPayStrategy
    {
        Boolean pay(int amount);
        void collectDetails();
    }
}
