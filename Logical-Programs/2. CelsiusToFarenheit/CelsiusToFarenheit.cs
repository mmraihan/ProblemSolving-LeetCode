using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._CelsiusToFarenheit
{
   public  class CelsiusToFarenheit
    {
        public  double ConvertCelToFaren(double celsius)
        {
            double Fahrenheit = (celsius * 9 / 5) + 32;
            return Fahrenheit;
        }
        
    }
}
