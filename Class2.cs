namespace Homework13
{
    using System;

    delegate bool ResultDel(int intForRez);
    delegate void CalcDel();

    public class Class2 
    {        
        public static void Calc()
        {
            IntOperation intOperation = Class1.Pow;
            decimal result = intOperation.Invoke(3,5);             
        }

        public static bool Result(int intForRez)
        {
            IntOperation intOperation = Class1.Pow;
            decimal result = intOperation.Invoke(3, 5);
            decimal remainder = result % intForRez;
            return remainder == 0;
        }
    }
}
