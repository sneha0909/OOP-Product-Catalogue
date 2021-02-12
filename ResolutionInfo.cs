using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shukla_Project1._2
{
    public class ResolutionInfo
    {
       private int PixelsCount;
       private string Resolution;


        public ResolutionInfo(int pixelsCount, string resolution)
        {
            this.PixelsCount = pixelsCount;
            this.Resolution  = resolution;

        }
        public string GetInfoofResolution()
        {
            return Resolution;

        }
        public int GetInfoofPixel()
        {
            return PixelsCount;

        }

    }
}
