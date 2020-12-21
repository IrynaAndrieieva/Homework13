namespace Homework13
{
    using System;

    delegate int IntOperation(int numberOne, int numberTwo);

    public class Class1
    {       
        public static int Pow(int number1, int number2)
        {
            return number1 * number2;
        }
    }
}
