using System;

namespace Command_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("*******************************************");
            Director d = new Director();
            d.SetCurrentCommand(1);
            d.setMenuItem(new MenuItem("fish salad", 3, 67.66));
            d.ExecuteCommand();
            d.ShowCurrentOrderedItems();
            Console.WriteLine("*******************************************");

            d.SetCurrentCommand(1);
            d.setMenuItem(new MenuItem("dark cofee with coconut milk", 2, 40.55));
            d.ExecuteCommand();
            d.ShowCurrentOrderedItems();
            Console.WriteLine("*******************************************");

            d.SetCurrentCommand(1);
            d.setMenuItem(new MenuItem("fruit salad", 1, 30));
            d.ExecuteCommand();
            d.ShowCurrentOrderedItems();
            Console.WriteLine("*******************************************");

            d.SetCurrentCommand(1);
            d.setMenuItem(new MenuItem("popcorn", 1, 11.30));
            d.ExecuteCommand();
            d.ShowCurrentOrderedItems();
            Console.WriteLine("*******************************************");

            d.SetCurrentCommand(2);
            d.setMenuItem(new MenuItem("fish salad", 3, 67.66));
            d.ExecuteCommand();
            d.ShowCurrentOrderedItems();
            Console.WriteLine("*******************************************");

            d.SetCurrentCommand(3);
            d.setMenuItem(new MenuItem("popcorn", 3, 33.90));
            d.ExecuteCommand();
            d.ShowCurrentOrderedItems();
            Console.WriteLine("*******************************************");

        }
    }
}
