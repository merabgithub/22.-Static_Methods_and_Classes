using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Static_Methods_and_Classes
{
    static internal class UseFullTools //this make this class only accessible through methods, not through objects

    {
        public static void sayHi(String name)
        {
            Console.WriteLine("Hi " + name);
        }
    }
}
