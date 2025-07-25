using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session3_oop
{
    internal class MyType:ImyType
    {

       public double salary
        {
            get=>throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public void MyFun()
        {
            throw new NotImplementedException();
            Console.WriteLine("hello world");
        }

    }
}
