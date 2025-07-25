using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session3_oop
{
    internal class SeriesByTwo : ISeries
    {
        public int current { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Next()
        {
            current += 2;
        }

        public void Reset()
        {
            current = 0;
        }

    }
}
