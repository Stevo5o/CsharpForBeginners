using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Excercise 0 */
            //Console.WriteLine("Welcome to C#");
            //Console.Read();

            //int num1 = 10;
            //int num2 = 5;

            //int sum = num1 + num2;
            //int sub = num1 - num2;
            //int multi = num1 * num2;
            //int division = num1 / num2;
            //int mod = num1 % num2;

            //Console.WriteLine(
            //    "Addition: " +
            //    sum +
            //    "\nSubtraction: " +
            //    sub +
            //    "\nMultiplication: " +
            //    multi +
            //    "\nDivision " +
            //    division +
            //    "\nModulus: " +
            //    mod
            //    );
            //Console.Read();

            /* Excercise 1 */
            //int num1 = 10;
            //int num2 = 20;

            //if (num1 == num2)
            //{
            //    Console.WriteLine("num1 is equal to Num2");
            //}
            //if (num1 != num2)
            //{
            //    Console.WriteLine("Num1 is not equal to Num2");
            //}
            //if(num1 > num2)
            //{
            //    Console.WriteLine("Num1 is greater than Num2");
            //}
            //if (num1 < num2)
            //{
            //    Console.WriteLine("Num1 is smaller than Num2");
            //}
            //if (num1 <= num2)
            //{
            //    Console.WriteLine("Num1 is smaller than or equal to Num2");
            //}
            //Console.Read();

            /* Excercise 2 */
            //int num1 = 20;
            //int num2 = 20;
            //int num3 = 5;

            //if((num1 == num2) && (num1 > num3) && num2 > num3)
            //{
            //    int result = num1 * num2 * num3;
            //    Console.WriteLine(result);
            //}
            //else
            //{
            //    int result = num1 + num2 + num3;
            //    Console.WriteLine(result);
            //}
            //Console.Read();

            /* Excercise 3 */
            string weather = "sunny";

            if (weather == "rainy")
            {
                Console.WriteLine("Don't play outside, it's rainy.");
            }
            if (weather == "sunny")
            {
                Console.WriteLine("You can play outside, it's sunny");
            }
            Console.Read();
        }
    }
}
