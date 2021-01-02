using System;
using System.Collections.Generic;
using System.Text;

// Receiver
namespace Command_Pattern
{
    class RestaurantOrder
    {
        public List<MenuItem> currentItems { get; set; }
        public RestaurantOrder()
        {
            this.currentItems = new List<MenuItem>();
        }

      
        public void ExecuteCommand(OrderCommand command, MenuItem item)
        {
            command.Execute(currentItems, item);
        }

        public void displayCurrentOrderedItems()
        {
            foreach(var orderedItem in currentItems)
            {
                orderedItem.Display();
            }
            Console.WriteLine("\n");
        }
    }
}
