using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session3_oop
{
    internal interface ImyType
    {
        //what can write inseide the interface
        // signature of properties
        // signature of methods
        //default implemented methods 

        // 2.signature of methods[name,parameter,return type]
        void MyFun();

        // 1.signature of properties
        
        double salary { get; set;} 
        // default implented methods [fully implemented methods]

        void print()
        {
            Console.WriteLine("");

        }




    }
}
