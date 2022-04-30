using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Addition obj = new Addition();
            Console.WriteLine("Result:- " + obj.Sum(1, 4));
        }
    }
}
