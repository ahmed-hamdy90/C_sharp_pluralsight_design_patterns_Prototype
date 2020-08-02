using System;

namespace PrototypePattern
{
    /// <summary>
    /// FoodOrder class represent model class for ordering food order
    /// </summary>
    public class FoodOrder
    {
        /// <summary>
        /// name of customer who order
        /// </summary>
        public string CustomerName;

        /// <summary>
        /// flag determiner whether order will be delivery or not
        /// </summary>
        public bool IsDelivery;

        /// <summary>
        /// food contents into order
        /// </summary>
        public string[] OrderContents;

        /// <summary>
        /// details for food order
        /// </summary>
        public OrderInfo OrderInfo;

        /// <summary>
        /// FoodOrder constructor
        /// </summary>
        /// <param name="name">customer name value</param>
        /// <param name="delivery">flag define need to delivery order or not</param>
        /// <param name="contents">order food contents list</param>
        public FoodOrder(string name, bool delivery, string[] contents, OrderInfo info)
        {
            this.CustomerName = name;
            this.IsDelivery = delivery;
            this.OrderContents = contents;
            this.OrderInfo = info;
        }

        /// <summary>
        /// Print all food order details into console screen
        /// </summary>
        public void Debug()
        {
            Console.WriteLine("----------- Prototype Food Order -----------");
            Console.WriteLine("\nName: {0} \nDelivery: {1}", this.CustomerName, this.IsDelivery);
            Console.WriteLine($"Order Contents: {String.Join(", ", OrderContents)}");
            Console.WriteLine($"ID: {this.OrderInfo.Id}");
            Console.WriteLine("\n");
        }
    }
}