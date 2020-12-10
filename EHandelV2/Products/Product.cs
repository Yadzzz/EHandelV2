using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHandelV2.Products
{
    public class Product
    {
        public int ID;
        public string Name;
        public string Description;
        public int Price;
        public Type Category;

        public Product(int id, string name, string description, int price, string category)
        {
            ID = id;
            Name = name;
            Description = description;
            Price = price;
            
            switch(category.ToLower())
            {
                case "skor":
                    this.Category = Type.Skor;
                    break;
                case "strumpor":
                    this.Category = Type.Strumpor;
                    break;
                case "keps":
                    this.Category = Type.Keps;
                    break;
                case "byxor":
                    this.Category = Type.Byxor;
                    break;
                case "hoodie":
                    this.Category = Type.Hoodie;
                    break;
                case "t-shirt":
                    this.Category = Type.TShirt;
                    break;
                case "tshirt":
                    this.Category = Type.TShirt;
                    break;
            }
        }
    }
}
