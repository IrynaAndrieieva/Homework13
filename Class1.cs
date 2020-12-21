namespace Homework13
{
    using System;

    delegate decimal IntOperation(decimal numberOne, decimal numberTwo);

    public class Class1
    {       
        public static decimal Pow(decimal numberOne, decimal numberTwo)
        {
            return numberOne * numberTwo;
        }
    }
}
