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
            Console.WriteLine("Vill du fortsätta handla skriv 1");
            Console.WriteLine("Vill du gå till betalning skriv 2");
            if (Products.Count > 0)
            {
                Console.WriteLine("Rensa produkt från varukorg skriv 3");
                Console.WriteLine("Rensa varukorg skriv 4");
            }
            string input = Console.ReadLine();

            if (input == "1") 
            {
                return;
            }
            else if (input == "2") 
            {
                betalning();
                Console.WriteLine();
                return;
            }
            else if (input == "3") 
            {
                Console.WriteLine("Välj produkten som du vill ta bort");
                int input2 = Convert.ToInt32(Console.ReadLine());
                RemoveProduct(input2);
                Console.WriteLine("Produkten är borttagen");
                
            }
            else if(input == "4") 
            {
                Products.Clear();
            
            }
            ShowCart();



        }

        public void betalning() 
        {
            Console.WriteLine("Skriv ditt namn:");
            name = Console.ReadLine();
            Console.WriteLine("Skriv din adress:");
            adress = Console.ReadLine();
            Console.Clear();

            int totalPrice = 0;

            Console.WriteLine("-- KVITTO --");
            Console.WriteLine(" ");

            foreach (Product ProductCart in this.Products.Values)
            {
                Console.WriteLine("Name: " + ProductCart.Name);
                Console.WriteLine("ID: " + ProductCart.ID);
                Console.WriteLine("Price: " + ProductCart.Price);
                Console.WriteLine();

                totalPrice += ProductCart.Price;
            }
            Products.Clear();
            Console.WriteLine("Total Price: " + totalPrice.ToString());
            Console.WriteLine();
            ShowReceipt();




              



        }

        public void AddCustomerInfo()
        {
            Console.WriteLine("Skriv ditt namn:");
            name = Console.ReadLine();
            Console.WriteLine("Skriv din adress:");
            adress = Console.ReadLine();
            Console.Clear();
            int totalPrice = 0;

            foreach (Product ProductCart in this.Products.Values)
            {
                
                Console.WriteLine("Name: " + ProductCart.Name);
                Console.WriteLine("ID: " + ProductCart.ID);
                Console.WriteLine("Price: " + ProductCart.Price);
                Console.WriteLine();

                totalPrice += ProductCart.Price;
            }
            Products.Clear();
            Console.WriteLine("Total Price: " + totalPrice.ToString());
            ShowReceipt();

        }

        public void ShowReceipt()
        {
            Console.WriteLine("Tack för din beställning " + name);
            Console.WriteLine("Din order levereras till " + adress);
            Console.WriteLine("Välkommen åter!");
        }
    }
}
