using System;

namespace CAL
{
    class Program
    {
        static void Main(string[] args)
        {
            CAL obj1 = new CAL();


            int num1 = Convert.ToInt32(Console.ReadLine());

            int num2 = Convert.ToInt32(Console.ReadLine());

            obj1.Addition(num1, num2);
            obj1.Sub(num1, num2);
            
        }
    }
}