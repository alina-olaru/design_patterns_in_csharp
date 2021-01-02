using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command_Pattern
{
    class AddCommand : OrderCommand
    {
        public override void Execute(List<MenuItem> order, MenuItem newItem)
        {
            order.Add(newItem);
        }
    }

    class DeleteCommand : OrderCommand
    {
        public override void Execute(List<MenuItem> order, MenuItem newItem)
        {
            order.Remove(order.Where(item => item.Name == newItem.Name).FirstOrDefault());
        }
    }

    class UpdateCommand : OrderCommand
    {
        public override void Execute(List<MenuItem> order, MenuItem newItem)
        {
            var itemToUpdate = order.Where(item => item.Name == newItem.Name).FirstOrDefault();
            itemToUpdate.Price = newItem.Price;
            itemToUpdate.Amount = newItem.Amount;
        }
    }

    class MakeSureCommand : OrderCommand
    {
        public override void Execute(List<MenuItem> order, MenuItem newItem)
        {
            Console.WriteLine("Your last item from current order is {0}", newItem);
        }
    }

}
