using System;

namespace EHandelV2
{
    class Program
    {
        public static Products.ProductManager ProductManager = new Products.ProductManager();
        public static ShoppingCart.Cart Cart = new ShoppingCart.Cart();
        public static Products.Meny Meny = new Products.Meny();

        static void Main(string[] args)
        {
            while(true)
            {
                Meny.ShowMeny();
                Console.Clear();
            }
        }
    }
}
