using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shukla_Project1._2
{
     public class ProductBase
    {
        private string Name;
        private float weight;
        private string Description;
        public int QuantityInStock;
        private float price;

        public  ProductType type;
       

        public ProductBase()
        {



        }

        public ProductBase(string name,float price, ProductType type,float weight,int quantity,string description)
        {
            this.Name = name;
            this.price = price;
            this.type = type;
            this.weight = weight;
            this.QuantityInStock = quantity;
            this.Description = description;

        }

        public void  DisplayToConsole()
        {
          
            Console.WriteLine("\nName:" + Name);
            Console.WriteLine("Price:" + price);
            Console.WriteLine("Type:" + type.GetType());
            Console.WriteLine("Weight:" + weight);
            Console.WriteLine("Quantity in Stock:" + GetQuantity());
            Console.WriteLine("Description:" + Description ) ;
            Console.WriteLine("\n");
            

        }


        public string GetName()
        {
            return Name;

        }

        public float GetPrice()
        {

            return price;

        }

        public new string GetType()
        {

            return type.GetType();
        }

        public int GetQuantity()
        {
            return QuantityInStock;


        }
        public void SetQuantity(int quantity)
        {
             QuantityInStock = quantity;


        }
        public float GetWeight()
        {

            return weight;

        }

        
    }
}
