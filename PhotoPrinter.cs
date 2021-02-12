using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shukla_Project1._2
{
    public class PhotoPrinter:ProductBase
    {


        private string PrintFormat;
        private int PrintingTime;
        private string Cartridge;

        public ResolutionInfo resolution;



        public PhotoPrinter()
        {



        }

        public PhotoPrinter(string name,float price,ProductType type,float weight,int quantity,string description,string printFormat,int printingTime,string cartridge,ResolutionInfo resolution) : base(name, price, type, weight, quantity, description)
        {

            this.PrintFormat = printFormat;
            this.PrintingTime = printingTime;
            this.Cartridge = cartridge;


        }


        public new void DisplayToConsole()
        {
           
            Console.WriteLine("PrintFormat:" + PrintFormat);
            Console.WriteLine("PrintingTime:" + PrintingTime);
            Console.WriteLine("Cartridge:" + Cartridge);
            

        }













    }
}
