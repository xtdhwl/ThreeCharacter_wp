using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeCharaset
{
    class Log
    {
        public static void i(string value)
        {
           
            Debug.WriteLine(value);
        }

        public static void i(string format, params object[] arg)
        {
            Debug.WriteLine(format, arg);
        }

        public static void e(string value)
        {
            Debug.WriteLine(value);
        }

        public static void e(string format, params object[] arg)
        {
            Debug.WriteLine(format, arg);
        }
    }
}
