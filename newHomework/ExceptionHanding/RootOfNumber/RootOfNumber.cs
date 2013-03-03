using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RootOfNumber
{
    class RootOfNumber
    {
        static void Main(string[] args)
        {

            try
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 0)
                {
                    throw new ArithmeticException("The number must be possitive!");
                }
                double root = Math.Sqrt(number);
                Console.WriteLine(root);
            }
            catch (FormatException formatException)
            {
                throw new FormatException("Invalid number! " + formatException.Message);
            }
            catch (OverflowException)
            {
                Console.WriteLine("The input number is too big or too small!");
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("The number must be possitive!");
            }
            finally
            {
                Console.WriteLine("Goodbye!");
            }
        }
    }
}
