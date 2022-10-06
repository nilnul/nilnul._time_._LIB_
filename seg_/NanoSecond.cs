using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.time
{
    public partial class NanoSecond
    {
        const int NANO_IN_ONE = 1000000000;
        static public double ToSeconds(double nanoSeconds) {

            return nanoSeconds / NANO_IN_ONE;
        
        }
    }
}
