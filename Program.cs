using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Static_Methods_and_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Static method is about the class itself, no need to create objects to get to the class itself.
            //C# already has many premade classes like the Math Class that we can call upon whenever without having to make objects

            Console.WriteLine(Math.Sqrt(144));

            //UserFullTools tools = new UserFullTools(); if you make the class static as well, u will only access it with direct methods,
            //no more objects, just like u cant make an object of the Math Class

            UseFullTools.sayHi("Mercy");// no need to make objects of the say Hi class since we have a statict method in there

            //freese console
            Console.ReadLine();
        }
    }
}
