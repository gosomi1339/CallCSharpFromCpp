using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClassLibrary
{
    public class Class1
    {
        public static int SetIntValue(int x)
        {
            return x + 1;
        }

        public static double SetObject(object o)
        {
            if (o is int)
            {
                return (int)o + 1;
            } else if (o is double)
            {
                return (double)o + 2.2;
            } else
            {
                return 3.3;
            }
        }
    }
}
