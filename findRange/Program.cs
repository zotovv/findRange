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
            int userNumber = Int32.Parse(Console.ReadLine());

            if (userNumber < 15 && userNumber > -1)
            {
                Console.WriteLine("Число находится в диапазоне 0-14.");
            }
            else if (userNumber > 14 && userNumber < 36)
            {
                Console.WriteLine("Число находится в диапазоне 15-35.");
            }
            else if (userNumber > 35 && userNumber < 51)
            {
                Console.WriteLine("Число находится в диапазоне 36-50.");
            }
            else if (userNumber > 50 && userNumber < 101)
            {
                Console.WriteLine("Число находится в диапазоне 50-100.");
            }
            else
            {
                Console.WriteLine("Число не входит ни в один из имеющихся диапазонов.");
            }

            Console.ReadKey();
        }
    }
}
