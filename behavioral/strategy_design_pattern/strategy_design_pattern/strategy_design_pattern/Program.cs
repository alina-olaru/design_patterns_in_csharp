using System;

namespace strategy_design_pattern
{
    class Program
    {
     
      

        static void Main(string[] args)
        {
            Order currentOrder = new Order();
            currentOrder.addToTotal(200);
            IPayStrategy strategy = null;

            while (!currentOrder.isOrderClosed())
            {
                if(strategy == null)
                {
                    Console.WriteLine("1 for payPal, 2 for cash");
                    var choice = Console.ReadLine();
                    if (choice.Equals("1"))
                    {
                        strategy = new PayByPaypal();
                    }
                    else
                    {
                        strategy = new PayByCash();
                    }
                    currentOrder.setIsCosed(true);
                }

               


            }
            currentOrder.processOrder(strategy);
            var total  = currentOrder.getTotalAmountMoney();
            Console.WriteLine(total);
        }
    }
}
