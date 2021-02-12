using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shukla_Project1._2
{
    public class ProductType
    {
        private String Name;


        public  ProductType(string name)
        {
            this.Name = name;
        }
        //public enum TypesofProducts
        //{
        //    Cameras,
        //    Printers,
        //    Wifi_Devices
        //}



        public new string GetType()
        {
            //    ProductType b = new ProductType("Camera");

            //    string bc = b.ToString();
            //    return bc;
            return Name;


        }



    }
}
