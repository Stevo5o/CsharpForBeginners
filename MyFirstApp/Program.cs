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
            Player p = new Player();
            p.name = "SteJ";
            p.age  = 38;
            p.country = "Ireland";
            
            Console.WriteLine(p.name + ", " + p.age + ", "+ p.country);         

            Console.Read();
        }
    }
}

