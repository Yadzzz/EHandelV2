using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EHandelV2.Products;


namespace EHandelV2.Products
{
    public class Meny
    {
        public bool LoggedIn = false;
        public string username = "admin";
        public string password = "lösenord";

        public void ShowMeny()
        {
            Console.WriteLine("Tryck 1 för att komma till alla produkter");
            Console.WriteLine("Tryck 2 för att visa kategorier");
            Console.WriteLine("Tryck 3 för att söka efter produkt");
            Console.WriteLine("Tryck 4 för att visa varukorg");

            if (this.LoggedIn)
            {
                Console.WriteLine("Tryck 5 för att komma till admin funktioner.");
            }
            else
            {
                Console.WriteLine("Tryck 5 för att logga in som Admin");
            }

            string input1 = Console.ReadLine();

            switch (input1)
            {
                case "1":
                    Program.ProductManager.ShowProducts();
                    break;

                case "2":
                   this.GetCategory();
                    break;
                case "3":
                    this.SearchProducts();
                    break;

                case "4":
                    Program.Cart.ShowCart();
                    break;
                    

                case "5":
                    if(this.LoggedIn)
                    {

                    }
                    else
                    {
                        this.LogIn();
                    }
                    break;
                default:
                    break;
            }
        }

        public void AddToCart()
        {
            Console.WriteLine("Skriv in ID på produkten du vill lägga till i varukorgen");
            string id = Console.ReadLine();

            Product product;
            if (Program.ProductManager.TryGetProduct(Convert.ToInt32(id), out product))
            {
                Program.Cart.AddProduct(product.ID);
                Console.WriteLine("Produkt " + product.ID + " är inlagd i varukorgen");
            }

            Console.WriteLine();
            Console.WriteLine("Skriv 1 om du vill lägga till produkter till varukorgen annars skriv 2 för att återgå till menyn");
            string input = Console.ReadLine();

            if (input == "1")
            {
                this.AddToCart();
            }
            else if (input == "¨2")
            {
                return;
            }
            else
            {
                return;
            }
        }

        public void SearchProducts()
        {
            Console.WriteLine("Skriv produkt Id på produkten du vill söka på");
            string id = Console.ReadLine();

            Product product;
            if(Program.ProductManager.TryGetProduct(Convert.ToInt32(id), out product))
            {
                Console.WriteLine("ID: " + product.ID + ", Name: " + product.Name + ", Description: " + product.Description + ", Price: " + product.Price); ;
            }

            Console.WriteLine();
            Console.WriteLine("Skriv 1 om du vill lägga till produkter till varukorgen annars skriv 2 för att återgå till menyn");
            string input = Console.ReadLine();

            if (input == "1")
            {
                this.AddToCart();
            }
            else if (input == "¨2")
            {
                return;
            }
            else
            {
                return;
            }
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
                Program.ProductManager.ShowProductByCategory(Type.Skor);

            }
            else if (input1 == "2")
            {
                Program.ProductManager.ShowProductByCategory(Type.Keps);
            }
            else if (input1 == "3")
            {
                Program.ProductManager.ShowProductByCategory(Type.Strumpor);
            }
            else if (input1 == "4")
            {
                Program.ProductManager.ShowProductByCategory(Type.Byxor);
            }
            else if (input1 == "5")
            {
                Program.ProductManager.ShowProductByCategory(Type.Hoodie);
            }
            else if (input1 == "6")
            {
                Program.ProductManager.ShowProductByCategory(Type.TShirt);
            }

            Console.WriteLine();
            Console.WriteLine("Skriv 1 om du vill lägga till produkter till varukorgen annars skriv 2 för att återgå till menyn");
            string input = Console.ReadLine();

            if (input == "1")
            {
                this.AddToCart();
            }
            else if (input == "¨2")
            {
                return;
            }
            else
            {
                return;
            }
        }

        public void LogIn()
        {
            if(this.LoggedIn)
            {
                Console.WriteLine("Du är redan inloggad");
                return;
            }

            while (!this.LoggedIn)
            {

                Console.WriteLine("Skriv ditt användarnamn: (Korrekt användarnamn är 'admin')");
                string userInput = Console.ReadLine();
                Console.WriteLine("Skriv ditt lösenord: (Korrekt lösenord är 'lösenord')");
                string passInput = Console.ReadLine();
                Console.WriteLine();

                if(this.username.ToLower() == userInput.ToLower() && this.password.ToLower() == passInput.ToLower())
                {
                    this.LoggedIn = true;
                    Console.WriteLine("Du är nu inloggad.");
                    break;
                }

                Console.WriteLine();
                Console.WriteLine("Fel username och password, skriv 1 för att försöka igen annars skriv 2 för att återgå till menyn");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    continue;
                }
                else if (input == "¨2")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }
    }
}
