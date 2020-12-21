using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework13
{
    delegate int IntOperation(int i, int j);

    public class Class1
    {
        public delegate void ShowDeleg();

        public static int Pow(int number1, int number2)
        {
            return number1 * number2;
        }
    }
}
