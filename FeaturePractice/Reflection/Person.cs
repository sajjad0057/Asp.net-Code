using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public class Person
    {
        public string Name { get; set; }
        private int _Age { get; set; }

        public Person(int age)
        {
            _Age = age;
        }

    }
}
