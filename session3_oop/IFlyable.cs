using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session3_oop
{
    internal interface IFlyable
    {
        int speed { get; set; }

        void Forward()
        {
            Console.WriteLine("can imoveable forward");
        }
        void Backward()
        {
            Console.WriteLine("can imoveable Backward");
        }
        void left()
        {
            Console.WriteLine("can imoveable left");

        }
        void right()
        {
            Console.WriteLine("can imoveable right");
        }




    }
}
