using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shukla_Project1._2
{
    public class Camera: ProductBase
    {

        private int Sensitivity;
        private string Diaphragm;
        public ResolutionInfo resolution;

        public Camera()
        {
           


        }

        public Camera(string name,float price,ProductType type,float weight,int quantity,string description,int sensitivity,string diaphragm, ResolutionInfo resolution):base(name,price,type,weight,quantity,description)
        {
            this.Sensitivity = sensitivity;
            this.Diaphragm = diaphragm;


        }

        public new void DisplayToConsole()
        {
            Console.WriteLine("Diaghragm:" + Diaphragm);
            Console.WriteLine("Sensitivity:" + Sensitivity);
        }

      








    }


}
