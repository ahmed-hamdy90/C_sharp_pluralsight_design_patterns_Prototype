using System;

namespace PrototypePattern
{
    /// <summary>
    /// The main Program class
    /// </summary>
    class Program
    {
        /// <summary>
        /// the main static method for program which run console app 
        /// </summary>
        /// <param name="args">given arguments for console app</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Original Order: ");
            FoodOrder savedOrder =
                new FoodOrder("Harrison", true, new string[]{"Pizza", "Coke"}, new OrderInfo(2345));
            savedOrder.Debug();
        }
    }
}
