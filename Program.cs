using System;

namespace Coffee
{
    class Program
    {
        static void Main(string[] args)
        {
            BlackCoffee black = new BlackCoffee();
            Cortado cort = new Cortado();
            Latte latte = new Latte();

            Console.WriteLine($"The price of the coffe: {black.Price()} kr. {black}");
            Console.WriteLine($"The price of the coffe: {cort.Price()} kr. {cort} It has {cort.mlMilk()}ml of milk");
            Console.WriteLine($"The price of the coffe: {latte.Price()} kr. {latte} It has {latte.mlMilk()}ml of milk");
        }
    }
}
