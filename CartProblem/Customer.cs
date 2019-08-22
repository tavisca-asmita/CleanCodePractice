using System;
using System.Collections;

namespace CartProblem
{
    class Customer
    {
        public static void Main(string[] args)
        {
            Shopping shopping = new Shopping();
            shopping.AddItem("Milk", 1);
            shopping.AddItem("Eggs", 2);
            Console.WriteLine(shopping.CalculateTotalAmount());            
        }
    }
}
