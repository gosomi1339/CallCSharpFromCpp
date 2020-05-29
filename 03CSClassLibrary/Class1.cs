using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

        //public static double SetObject([MarshalAs(UnmanagedType.AsAny)] object o)
        unsafe public static double SetObject(int t, void* o)
        {

            switch (t) {
                case 0:
                    int x = Marshal.ReadInt32((IntPtr)o);
                    return x + 1;
                case 1:
                    double[] managedArray = new double[1];

                    Marshal.Copy((IntPtr)o, managedArray, 0, managedArray.Length);
                    return managedArray[0] + 2.2;
                default:
                    string s = Marshal.PtrToStringAuto((IntPtr)o);
                    Console.WriteLine(s);
                    return 3.3;
            }

            //int* xptr = (int*)o;
            //int x = *xptr;

            //return x+ 1;

            //if (o is int)
            //{
            //    return (int)o + 1;
            //} else if (o is double)
            //{
            //    return (double)o + 2.2;
            //} else
            //{
            //    return 3.3;
            //}
        }
    }
}
