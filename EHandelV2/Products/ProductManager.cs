using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHandelV2.Products
{
    public class ProductManager
    {
        public Dictionary<int, Product> Products;

        public ProductManager()
        {
            this.Products = new Dictionary<int, Product>();
            this.Products.Add(1, new Product(1, "Skor", "Storlek 45, Färg svart, märke Nike", 2000, "skor"));
            this.Products.Add(2, new Product(2, "Skor", "Storlek 38, Färg brun, märke Gucci", 15000, "skor"));
            this.Products.Add(3, new Product(3, "Keps", "Storlek Medium, Färg Blå, Märke Puma", 500, "keps"));
            this.Products.Add(4, new Product(4, "Strumpor", "Storlek 38, Färg grön, Märke HM", 99, "strumpor"));
            this.Products.Add(5, new Product(5, "Byxor", "Storlek XXXXL, Färg Lila, Märke Big Momma Pantys", 29, "byxor"));
            this.Products.Add(6, new Product(6, "Byxor", "Storlek M, Färg Svart, Märke Zeynabs EgnaByxor", 250, "byxor"));
            this.Products.Add(7, new Product(7, "Hoodie", "Storlek M,Färg Brun Märke YadsProgrammeringsHoodie", 50, "hoodie"));
            this.Products.Add(8, new Product(8, "Hoodie", "Storlek M,Färg vit, Märke DanielsFashionHoodie", 150, "hoodie"));
            this.Products.Add(9, new Product(9, "T-shirt", "Storlek L, Färg Guld, Märke FelipesKläder", 20000, "t-shirt"));
            this.Products.Add(10, new Product(10, "T-shirt", "Storlek L, Färg gul, Märke Zeynabs EgnaKläder", 1, "t-shirt"));

            
        }

        public void ShowProducts()
        {
            foreach(Product product in this.Products.Values)
            {
                Console.WriteLine("ID: " + product.ID + ", Name: " + product.Name + ", Description: " + product.Description + ", Price: " + product.Price); ;
            }

            Console.WriteLine();
            Program.Meny.ShowMeny();
        }

        /*public void GetCategory()
        {
            Console.WriteLine("Tryck 1 för skor");
            Console.WriteLine("Tryck 2 för Keps");
            Console.WriteLine("Tryck 3 för Strumpor");
            Console.WriteLine("Tryck 4 för Byxor");
            Console.WriteLine("Tryck 5 för Hoodie");
            Console.WriteLine("Tryck 6 för T-shirt");
           string input1 = Console.ReadLine();
            if(input1 == "1")
            {
                ShowProductById1(1);
                ShowProductById1(2);

            }
            else if(input1 == "2")
            {
                ShowProductById1(3);
            }
            else if (input1 == "3")
            {
                ShowProductById1(4);
            }
            else if (input1 == "4")
            {
                ShowProductById1(5);
                ShowProductById1(6);
            }
            else if (input1 == "5")
            {
                
                ShowProductById1(7);
                ShowProductById1(8);

            }
            else if (input1 == "6")
            {
                ShowProductById1(9);
                ShowProductById1(10);

            }



        }*/

        public void ShowProductByCategory(Type category)
        {
            foreach(Product product in this.Products.Values)
            {
                if(product.Category == category)
                {
                    Console.WriteLine("ID: " + product.ID + ", Name: " + product.Name + ", Description: " + product.Description + ", Price: " + product.Price); ;
                }
            }
        }

        public string ShowProductById(int id)
        {
            string productString = string.Empty;

            Product product;
            if(this.Products.TryGetValue(id, out product))
            {
                Console.WriteLine("ID: " + product.ID + ", Name: " + product.Name + ", Description: " + product.Description + ", Price: " + product.Price); ;
            }
            else
            {
                Console.WriteLine("Invalid product ID");
            }

            return productString;
        }

        public bool TryGetProduct(int id, out Product product)
        {
            product = null;

            if(this.Products.TryGetValue(id, out product))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AddProduct(int id, string name, string description, int price, string category)
        {
            if(this.Products.ContainsKey(id))
            {
                Console.WriteLine("ÍD already exists");
                return;
            }

            Product product = new Product(id, name, description, price, category);
            this.Products.Add(id, product);
            Console.WriteLine("Product Added");
        }

        public void RemoveProduct(int id)
        {
            if (!this.Products.ContainsKey(id))
            {
                Console.WriteLine("ÍD does not exists");
                return;
            }

            this.Products.Remove(id);
            Console.WriteLine("Item removed");
        }
       

    }
}
