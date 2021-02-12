using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shukla_Project1._2
{
    public class Router:ProductBase
    {

        private string Frequency;
        private string Standarts;
        private int LanPortsCount;
        private string SecurityProtocols;
        private string Color;

       

        public Router()
        {



        }

        public Router(string name,float price,ProductType type,float weight,int quantity,string description,string frequency,string standarts,int lanPortsCount, string securityProtocols,string color) : base(name, price, type, weight, quantity, description)
        {
            this.Frequency = frequency;
            this.Standarts = standarts;
            this.LanPortsCount = lanPortsCount;
            this.SecurityProtocols = securityProtocols;
            this.Color = color;
          



        }

        public new void DisplayToConsole()
        {
          
            Console.WriteLine("Frequency:" + Frequency);
            Console.WriteLine("Standarts:" + Standarts);
            Console.WriteLine("LanPortsCount:" + LanPortsCount);
            Console.WriteLine("SecurityProtocols:" + SecurityProtocols);
            Console.WriteLine("Color:" + Color);
        }





    }
}
