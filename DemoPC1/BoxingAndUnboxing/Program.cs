using System;
using System.Collections.Generic;
using System.Text;

namespace BoxingAndUnboxing
{
    class Product
    {
        static void Main(string[] args)
        {
            Object objProductID;
            Object objProductName;
            Object objPrice;
            Object objQuantity;

            Console.Write("Enter the id of product: ");
            objProductID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the name of product: ");
            objProductName = Console.ReadLine();

            Console.Write("Enter the Price of product: ");
            objPrice = Console.ReadLine();

            Console.Write("Enter Quantity: ");
            objQuantity = Console.ReadLine();


            int ProductID = (int)objProductID;
            string ProductName = (string)objProductName;
            double Price = (double)objPrice;
            int Quantity = (int)objQuantity;
            double amtPayable = (int)objQuantity * Price;

            Console.WriteLine("\nProduct Details:");
            Console.WriteLine("Product ID : " + ProductID);
            Console.WriteLine("Product Name : " + ProductName);
            Console.WriteLine("Price : $" + Price);
            Console.WriteLine("Quantity :" + Quantity);
            Console.WriteLine("Amt Pyable {=:F2}: ", amtPayable);
        }
    }
}
