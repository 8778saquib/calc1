using System;
namespace CAL
{
    public class CAL
    {
        public void Addition(int num1, int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine("Addition of {0} + {1} = {2}", num1, num2, sum);
        }

        public void Sub(int num1, int num2)
        {
            int diff = 0;
            if (num1 >= num2)
            {
                diff = num1 - num2;
            }
            else if (num1 <= num2)
            {
                diff = num2 - num1;
            }
            Console.WriteLine("Subtraction of {0} - {1} = {2}", num1, num2, diff);
        }
    }
}