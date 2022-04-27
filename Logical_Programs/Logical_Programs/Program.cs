using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    public class Program
    {
        private static object flibSeries;

        static void Main(string[] args)
        {
            //Perfect Number
            PerfectNumbercs PerfectNum = new PerfectNumbercs();
            PerfectNum.CheckPerfectNumber();
        }
    }
}