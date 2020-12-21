using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework13
{
    delegate bool ResultDel(int intForRez);

    public class Class2 
    {
        private static int result;

        public static void Calc()
        {
            IntOperation intOperation = Class1.Pow;
            result = intOperation.Invoke(3,5);           
        }

        public static bool Result(int intForRez)
        {
            decimal remainder = result % intForRez;
            return remainder == 0;
        }


    }
}
