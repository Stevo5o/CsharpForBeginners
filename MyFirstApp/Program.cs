using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

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

            /* Excercise 4 */
            //string weather = "rainy";

            //if (weather == "rainy")
            //{
            //    Console.WriteLine("Don't play outside, it's rainy.");
            //}
            //else if (weather == "sunny")
            //{
            //    Console.WriteLine("You can play outside, it's sunny");
            //}
            //else
            //{
            //    Console.WriteLine("Weather cannot be determined, try again");
            //}
            //Console.Read();

            /* Excercise 5 */
            //string weather = "cloudy";

            //switch (weather)
            //{
            //    case "rainy":
            //        Console.WriteLine("Don't play outside, it's rainy");
            //        break;
            //    case "sunny":
            //        Console.WriteLine("You can play outside, it's sunny.");
            //        break;
            //    case "cloudy":
            //        Debug.WriteLine("Play but take your umbrella with you, it's cloudy.");
            //        break;
            //    default:
            //        Console.WriteLine("Weather cannot be determined");
            //        break;                                      
            //}
            //Console.Read(); 

            /* Excercise 6 */
            //int lottery = 451876;

            //switch (lottery)
            //{
            //    case 461876:
            //        Console.WriteLine("You won a mobile set.");
            //        break;
            //    case 452167:
            //        Console.WriteLine("You won an Xbox.");
            //        break;
            //    case 742167:
            //        Debug.WriteLine("Sorry you won nothing.");
            //        break;
            //    case 741963:
            //        Debug.WriteLine("You won a cinema ticket");
            //        break;
            //    default:
            //        Console.WriteLine("Sorry you won nothing.");
            //        break;
            //}

            /* Excercise 7 */
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Welcome to C#");
            }
            Console.Read();
        }
    }
}
