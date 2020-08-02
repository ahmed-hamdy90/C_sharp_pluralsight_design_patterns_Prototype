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
            // the main food order
            // Console.WriteLine("Original Order: ");
            // FoodOrder savedOrder =
            //     new FoodOrder("Harrison", true, new string[]{"Pizza", "Coke"}, new OrderInfo(2345));
            // savedOrder.Debug();
            
            // Using Shallow copy way
            // // clone the main food order
            // Console.WriteLine("Cloned Object: ");
            // FoodOrder clonedOrder = (FoodOrder) savedOrder.ShallowCopy();
            // clonedOrder.Debug();
            //
            // // change the main food order then print both main order and cloned one too
            // Console.WriteLine("Order Changes: ");
            // savedOrder.CustomerName = "Jeff";
            // savedOrder.OrderInfo.Id = 5555;
            //
            // savedOrder.Debug();
            // clonedOrder.Debug();
            
            // Using Deep copy way
            // // clone the main food order
            // Console.WriteLine("Cloned Object: ");
            // FoodOrder clonedOrder = (FoodOrder) savedOrder.DeepCopy();
            // clonedOrder.Debug();
            //
            // // change the main food order then print both main order and cloned one too
            // Console.WriteLine("Order Changes: ");
            // savedOrder.CustomerName = "Jeff";
            // savedOrder.OrderInfo.Id = 5555;
            //
            // savedOrder.Debug();
            // clonedOrder.Debug();
            
            PrototypeManager manager = new PrototypeManager();
            manager["2/3/2020"] =
                new FoodOrder("Steve", false, new string[] {"Chicken Parm", "Root Beer"}, new OrderInfo(8912));
            
            Console.WriteLine("Manager clone: ");
            FoodOrder managerOrder = (FoodOrder) manager["2/3/2020"].DeepCopy();
            
            managerOrder.Debug();
        }
    }
}
