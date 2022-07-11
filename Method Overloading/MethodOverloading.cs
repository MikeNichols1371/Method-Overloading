using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    internal class MethodOverloading
    {
        public static int Add(int a, int b)
            { return a + b; }   
        public static decimal Add(decimal c, decimal d)
            { return c + d; }
        public static string Add(int e, int f, bool isTrue)
        {
            var sum = e + f;
            if (isTrue == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (isTrue == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if (isTrue == true && sum < 1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return sum.ToString();          
            } 
        }  
    }
}
