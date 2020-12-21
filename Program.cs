namespace Homework13
{
    using System;

    public delegate void ShowDeleg();

    class Program
    {
        static void Main(string[] args)
        {
            //ShowDeleg showDeleg = Show;
            //showDeleg.ToString();

            Show();
            Console.ReadLine();
        }

        public static void Show()
        {
            ResultDel resultDel = Class2.Result;
            bool finaly = resultDel.Invoke(2.3);           
            Console.WriteLine($"Remainder of the division:{finaly}");
        }
    }
}
