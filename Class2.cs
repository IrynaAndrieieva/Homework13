using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework13
{

    public class Class2 
    {
        private int result;

        public void Calc()
        {
            IntOperation intOperation = Class1.Pow;
            this.result = intOperation.Invoke(3,5);           
        }
      
        public bool Result(int intForRez)
        {
            decimal remainder = this.result % intForRez;
            return remainder == 0;
        }


    }
}
