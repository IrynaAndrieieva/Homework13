namespace Homework13
{
    using System;

    delegate double DecimaOperation(double numberOne, double numberTwo);

    public class Class1
    {       
        public static double Pow(double numberOne, double numberTwo)
        {
            return numberOne * numberTwo;
        }
    }
}
