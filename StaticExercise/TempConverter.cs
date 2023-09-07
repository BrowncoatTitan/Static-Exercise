using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FarenheitToCelsius(double temp)
        {
         double newTemp = (temp - 32) * 5 / 9;
            return newTemp;
        }
        public static double CelsiusToFarenheit(double temp)
        {
            double newTemp = (temp * 9 / 5) + 32;
            return newTemp;
        }
    }
}
