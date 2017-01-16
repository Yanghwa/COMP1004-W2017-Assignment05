using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp1004_w2017_lesson1_part2
{
    /// <summary>
    /// Driver class for our console application
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Person Tom = new Person("Tom", 30);

            Tom.SaysHello();

            Console.WriteLine();

            Person Jane = new Person("Jane", 30);

            Jane.SaysHello();
        }
    }
}
