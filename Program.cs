using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework13
{
    public delegate void ShowDeleg();

    class Program
    {
        static void Main(string[] args)
        {
            ShowDeleg showDeleg = Show;
            Console.ReadLine();
        }

        public static void Show()
        {
            ResultDel resultDel = Class2.Result;
            resultDel.Invoke(5);
            Console.WriteLine($"{resultDel}");
        }

    }
}
