using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3_Bhavani_UsingExceptionHandling
{
    public  class AirthematicOperation
    {
        public void DevisionOfTwoNumbers()
        {
            try
            {
                int a;
                int b;
                int c;
                Console.WriteLine("Enter a value:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter b value:");
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.WriteLine("the result is :" + c);
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("b must be non zero");
            }
        }
        public void SumOfThreeNumbers()
        {
            try
            {
                int a;
                int b;
                int c;
                Console.WriteLine("Enter a value:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter b value:");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter c value:");
                c = Convert.ToInt32(Console.ReadLine());

                int d  = a -b-c;
                Console.WriteLine("the result is :" + d);
            }
            catch (FormatException)
            {
                Console.WriteLine("b must be number");
            }
        }
        public void MultiplicationOfFourNumbers()
        {
            try
            {
                int a;
                int b;
                int c;
                int d;
                Console.WriteLine("Enter a value:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter b value:");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter c value:");
                c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter d value:");
                d = Convert.ToInt32(Console.ReadLine());
                int e = a * b * c * d;
                Console.WriteLine("the result is :" + e);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
