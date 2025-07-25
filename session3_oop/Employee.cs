using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session3_oop
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age {  get; set; }
        public double salary {  get; set; }

        public override string ToString()
        {
            return $"id: {Id} , name:{Name},age:{Age}";
        }







    }
}
