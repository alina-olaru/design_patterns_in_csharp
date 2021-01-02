using System;
using System.Collections.Generic;
using System.Text;

namespace strategy_design_pattern
{
    class Order
    {
        private int totalAmountMoney = 0;
        private Boolean isClosed = false;

        public void processOrder(IPayStrategy strategy)
        {
            strategy.collectDetails();

        }

        public bool isOrderClosed()
        {
            return isClosed;
        }
        public int getTotalAmountMoney()
        {
            return totalAmountMoney;
        }

        public void addToTotal(int currentCost)
        {
            totalAmountMoney += currentCost;
        }
        public void setIsCosed(bool isOrderClosed)
        {
            isClosed = isOrderClosed;
        }

    }
}
