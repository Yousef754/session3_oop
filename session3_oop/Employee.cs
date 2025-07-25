using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session3_oop
{
    internal class Employee : ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double salary { get; set; }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"id: {Id} , name:{Name},age:{Age}";
        }



        public object clone()
        {
            return new Employee();
            {
                Id = this.Id;
            }
            ;



        }
    }
}
