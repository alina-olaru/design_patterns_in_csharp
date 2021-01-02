using System;
using System.Collections.Generic;
using System.Text;

// invoker 
namespace Command_Pattern
{
    public class Director
    {
        private MenuItem _item;
        private OrderCommand _command;
        // Invoker keeps a reference to an instance of RestaurantOrder(Receiver)
        private RestaurantOrder _order;
        public Director()
        {
            _order = new RestaurantOrder();
        }
        public void SetCurrentCommand(int commandOption)
        {
            _command = new CommandFactory().GetCommand(commandOption);
            
        }
        public void setMenuItem(MenuItem newItem)
        {
            _item = newItem;
        }
        public void ExecuteCommand()
        {
            _order.ExecuteCommand(_command, _item);
        }
        public void ShowCurrentOrderedItems()
        {
            _order.displayCurrentOrderedItems();
        }
    }
    public class CommandFactory
    {
        public OrderCommand GetCommand(int commandOption)
        {
            switch (commandOption)
            {
                case 1:
                    return new AddCommand();
                case 2:
                    return new DeleteCommand();
                case 3: 
                    return new UpdateCommand();
                case 4:
                    return new MakeSureCommand();
                default:
                    return new AddCommand();
            }
        }

    }
}

