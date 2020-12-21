namespace Homework13
{
    using System;

    delegate int IntOperation(int numberOne, int numberTwo);

    public class Class1
    {       
        public static int Pow(int numberOne, int numberTwo)
        {
            return numberOne * numberTwo;
        }
    }
}
