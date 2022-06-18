using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvent_Practice
{
    public class PrintUsingDelegate
    {
        public delegate void PrintDelegate(object message);

        public static void Calculate(int x, int y, PrintDelegate printer)
        {
            int result = x + y;
            printer(result);
        }
    }
}
