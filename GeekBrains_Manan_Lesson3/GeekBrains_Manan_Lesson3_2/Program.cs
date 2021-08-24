using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrains_Manan_Lesson3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Маннанов  С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse.
            int n = 1;
            int sum = 0;
            string numbers = "";
            Console.WriteLine("С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке).");
            while (n != 0)
            {
                sum += !int.TryParse(Console.ReadLine(), out n) ? 0 : (n % 2 == 1 && n > 0) ? n : 0;
                numbers += (n % 2 == 1 && n > 0) ? n + " " : "";
            }
            Console.WriteLine(numbers + " сумма = " + sum);
            Console.ReadLine();

        }
    }
}
