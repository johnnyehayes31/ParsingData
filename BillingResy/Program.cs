using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingResy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bill Calculator");
            string entree = "17.99";
            Console.WriteLine($"How much was the entree?" +" "+(entree));
            int.TryParse(entree, out int num1);  
            

            string text1 = "1.45";
            Console.WriteLine($"How much was the drink?" + " " + (text1));
            int.TryParse(text1, out int num2);

            string dessert = "4.99";
            Console.WriteLine($"How much was the drink?" + " " + (dessert));
            int.TryParse(dessert, out int num3);


            double sum = 0;
            sum = 17.99 + 1.45 + 4.99;

            Console.WriteLine($"The total for all 3 items is: " +"$" + (sum));



        }
    }


}
