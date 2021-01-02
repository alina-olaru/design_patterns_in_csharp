using System;
using System.Collections.Generic;
using System.Text;

namespace strategy_design_pattern
{
    class PayByCash : IPayStrategy
    {
        public void collectDetails()
        {
            Console.Write("You chose to pay cash at delivery!");
        }

        public bool pay(int amount)
        {
            Console.Write("You chose to pay cash at delivery!. Please pay {} cash now", amount);

            return true;
        }
    }
}
