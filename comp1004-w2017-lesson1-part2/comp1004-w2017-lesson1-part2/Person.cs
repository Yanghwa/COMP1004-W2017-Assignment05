using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp1004_w2017_lesson1_part2
{
    class Person
    {
        //PUBLIC PROPERTIES
        public string Name { get; set; }
        public int Age { get; set; }

        // CONSTRUCTOR
        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public void SaysHello()
        {
            Console.WriteLine("Hello " + this.Name);
        }
    }

}
