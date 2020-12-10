using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EHandelV2.Products;


namespace EHandelV2.Products
{
    class Meny
    {
        public static Products.ProductManager ProductManager = new Products.ProductManager();
        public static ShoppingCart.Cart Cart = new ShoppingCart.Cart();


        public void ShowMeny()
        {
            Console.WriteLine("Tryck 1 för att komma till alla produkter");
            Console.WriteLine("Tryck 2 för att visa kategorier");
            Console.WriteLine("Tryck 3 för att söka efter produkt");
            Console.WriteLine("Tryck 4 för att logga in som Admin");
            string input1 = Console.ReadLine();

            switch (input1)
            {
                case "1":
                    ProductManager.ShowProducts();
                    break;

                case "2":
                    GetCategory();
                    break;
                case "3":
                    this.SearchProducts();
                    break;

                case "4":
                    this.LogIn();
                    break;
                default:
                    break;
            }
            
        }

        public void SearchProducts()
        {

        }

        public void GetCategory()
        {
            Console.WriteLine("Tryck 1 för skor");
            Console.WriteLine("Tryck 2 för Keps");
            Console.WriteLine("Tryck 3 för Strumpor");
            Console.WriteLine("Tryck 4 för Byxor");
            Console.WriteLine("Tryck 5 för Hoodie");
            Console.WriteLine("Tryck 6 för T-shirt");
            string input1 = Console.ReadLine();

            if (input1 == "1")
            {
                ProductManager.ShowProductByCategory(Type.Skor);

            }
            else if (input1 == "2")
            {
                ProductManager.ShowProductByCategory(Type.Keps);
            }
            else if (input1 == "3")
            {
                ProductManager.ShowProductByCategory(Type.Strumpor);
            }
            else if (input1 == "4")
            {
                ProductManager.ShowProductByCategory(Type.Byxor);
            }
            else if (input1 == "5")
            {
                ProductManager.ShowProductByCategory(Type.Hoodie);

            }
            else if (input1 == "6")
            {
                ProductManager.ShowProductByCategory(Type.TShirt);
            }

            Console.WriteLine();
            Program.Meny.ShowMeny();
        }

        public void LogIn()
        {
            string username = "admin";
            string password = "lösenord";
            while (username == "admin" && password == "lösenord")
            {

                Console.WriteLine("Skriv ditt användarnamn: (Korrekt användarnamn är 'admin')");
                string userInput = Console.ReadLine();
                Console.WriteLine("Skriv ditt lösenord: (Korrekt lösenord är 'lösenord')");
                string passInput = Console.ReadLine();


                if (userInput != username || passInput != password)
                {
                    Console.WriteLine("Fel användarnamn eller lösenord, vänligen försök igen.");
                    string pInput = Console.ReadLine();
                    passInput = pInput;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
