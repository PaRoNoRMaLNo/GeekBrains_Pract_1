using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manan_GeekBreans_lesson2
{
    class Program
    {
        //Маннанов А.К.

        //1. Написать метод, возвращающий минимальное из трёх чисел.

        static int Min_of_three(int a, int b, int c)
        {
            return (a < b && a < c) ? a : (b < a && b < c) ? b : c;
        }

        //2. Написать метод подсчета количества цифр числа.

        static int Count_number(int number)
        {
            int i = 1;
            while (number >= 10)
            {
                number /= 10;
                i++;
            }
            return i;
        }

        //3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.

        static void Sum_()
        {
            int sum = 0;
            int number = 1;
            while (number != 0)
            {
                Console.Write("Введите число (Для выхода 0): ");
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    if (number % 2 == 1 && number > 0)
                        sum += number;
                }
                else
                {
                    Console.WriteLine("Введите число!");
                    number = 1;
                }
            }
           Console.WriteLine("Сумма нечетных положительных чисел = " + sum);
        }

        //4. Реализовать метод проверки логина и пароля.На вход метода подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
        //   Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.С помощью цикла do while ограничить ввод пароля тремя попытками.

        static void Log_in()
        {
            int i = 0;
            do
            {
                Console.WriteLine("Введите логин и пароль");
                if (Acces_check(Console.ReadLine(), Console.ReadLine()))
                {
                    Console.WriteLine("Все ок");
                    return;
                }
                else
                {
                    Console.WriteLine("не верно");
                    i++;
                }
            } while (i < 3);
            Console.WriteLine("Попытки закончились");
        }
        static bool Acces_check(string login, string password)
        {
            return login == "root" & password == "GeekBrains";
        }

        //а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
        static void Massa()
        {
            int Height, Weight;
            double index;
            try
            {
                Console.Write("Рост: ");
                Height = int.Parse(Console.ReadLine());
                Console.Write("Вес: ");
                Weight = int.Parse(Console.ReadLine());
            }
            catch
            {
                throw new Exception("Не число");
            }
            index = (double)Weight / Math.Pow((double)Height / 100, 2);

            if (index < 18.5)
            {
                Console.WriteLine("Вам нужно набрать вес");
            }
            else if (index <= 25)
            {
                Console.WriteLine("Все норм :P");
            }
            else
            {
                Console.WriteLine("Похудейте пожалуйста =(");
            }

        }


        //7.
        //a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).

        static void Recurs(int a, int b)
        {
            if (a == b)
            {
                Console.WriteLine(a);
                return;
            }
            else
            {
                Console.WriteLine(a);
                Recurs(++a, b);
            }
        }



        static void Main(string[] args)
        {
            int k = 1;
            while (k != 0)
            {
                Console.WriteLine("Введите номер задачи от 1 до 6, для выхода введите 0");
                k = int.Parse(Console.ReadLine());
                switch (k)
                {
                    case 1:
                       Console.WriteLine("Минимальное = " + Min_of_three(15, 13, 6));
                        break;
                    case 2:
                        Console.WriteLine("Количество цифр числа 1321 = " +Count_number(1321));
                        break;
                    case 3:
                        Sum_();
                        break;
                    case 4:
                        Log_in();
                        break;
                    case 5:
                        Massa();
                        break;
                    case 6:
                        Recurs(1,15);
                        Console.WriteLine("Все числа от 1 до 15");
                        break;
                    default:
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
            Console.ReadKey();
        }
    }
}
