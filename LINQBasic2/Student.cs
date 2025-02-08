using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQBasic2
{
    internal class Student
    {
        public required string Name { get; set; }
        public required string Address { get; set; }
        public required int Age { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Address: {Address}, Age: {Age}";
        }
    }

}
