using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session3_oop
{
    internal interface ISeries
    {
        int current { get; set; }

        void Next();
        void Reset();




    }
}
