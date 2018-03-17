using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findRange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 1 до 100: ");
            double userNumber = Convert.ToDouble(Console.ReadLine());

            if ((userNumber >= 0) && (userNumber <= 14))
            {
                Console.WriteLine("Число находится в диапазоне [0-14]");
            }
            else if ((userNumber >= 15) && (userNumber <= 35))
            {
                Console.WriteLine("Число находится в диапазоне [15-35]");
            }
            else if ((userNumber >= 36) && (userNumber <= 50)) 
            {
                Console.WriteLine("Число находится в диапазоне [36-50]");
            }
            else if ((userNumber >= 51) && (userNumber <= 100))
            {
                Console.WriteLine("Число находится в диапазоне [50-100]");
            }
            else
            {
                Console.WriteLine("Число не входит ни в один из имеющихся диапазонов.");
            }

            Console.ReadKey();
        }
    }
}
