using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session3_oop
{
    internal class seriesByThree : ISeries
    {
        public int current { get; set; }

        public void Next()
        {
            current += 3;
        }

        public void Reset()
        {
            current = 0;
        }
    }
}
