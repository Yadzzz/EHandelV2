using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EHandelV2.Products;

namespace EHandelV2.ShoppingCart
{
    class Cart
    {
        public Dictionary<int, Product> Products;
        public string name, adress;


        public Cart()
        {
            Products = new Dictionary<int, Product>();
        }

        public void AddProduct(int id)
        {
            Product product1;
            if (Program.ProductManager.TryGetProduct(id, out product1))
            {
                Products.Add(id, product1);
            }
        }

        public void RemoveProduct(int id)
        {
            if(Products.ContainsKey(id))
            {
                Products.Remove(id);
            }
        }



 
        public void ShowCart()
        {
            int totalPrice = 0;

            foreach (Product ProductCart in this.Products.Values)
            {
                Console.WriteLine("Name: " + ProductCart.Name);
                Console.WriteLine("ID: " + ProductCart.ID);
                Console.WriteLine("Price: " + ProductCart.Price);
                Console.WriteLine();

                totalPrice += ProductCart.Price;
            }

            Console.WriteLine("Total Price: " + totalPrice.ToString());
        }

        public void AddCustomerInfo()
        {
            Console.WriteLine("Skriv ditt namn:");
            name = Console.ReadLine();
            Console.WriteLine("Skriv din adress:");
            adress = Console.ReadLine();

        }

        public void ShowReceipt()
        {
            ShowCart();
            
            Console.WriteLine(name);
            Console.WriteLine(adress);

        }
    }
}
