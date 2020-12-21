namespace Homework13
{
    using System;

    delegate bool ResultDel(double doublelForRez);
    delegate double CalcDel();

    public class Class2
    {
        public static double Calc()
        {
            DecimaOperation doubleOperation = Class1.Pow;
            return doubleOperation.Invoke(10, 35);
        }

        public static bool Result(double doublelForRez)
        {
            CalcDel сalcDel = Calc;
            double result = сalcDel.Invoke();
            double remainder = result % doublelForRez;
            return remainder == 0;
        }
    }
}
