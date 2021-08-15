using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manan_geekBreans_lesson_1
{
    class Program
    {
        static void Task_1_and_2()
        {
            //Маннанов
            //1.Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).
            //В результате вся информация выводится в одну строчку:
            //а) используя склеивание;
            //б) используя форматированный вывод;
            //в) используя вывод со знаком $.

            string FirstName;
            string LastName;
            uint Age;
            uint Height;
            uint Weight;
            Console.WriteLine("1. Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:");

            Console.Write("Имя: ");
            FirstName = Console.ReadLine();
            Console.Write("Фамилия: ");
            LastName = Console.ReadLine();
            Console.Write("Возраст: ");
            Age = uint.Parse(Console.ReadLine());
            Console.Write("Рост: ");
            Height = uint.Parse(Console.ReadLine());
            Console.Write("Вес: ");
            Weight = uint.Parse(Console.ReadLine());

            Console.WriteLine("Имя: " + FirstName + " Фамилия: " + LastName + " Возраст: " + Age + " Рост: " + Height + " Вес: " + Weight + "    а) используя склеивание;");
            Console.WriteLine("Имя: {0} Фамилия: {1} Возраст: {2} Рост: {3} Вес: {4}    б) используя форматированный вывод;", FirstName, LastName, Age, Height, Weight);
            Console.WriteLine($"Имя: {FirstName} Фамилия: {LastName} Возраст: {Age} Рост: {Height} Вес: {Weight}    в) используя вывод со знаком $.");

            //2.Ввести вес и рост человека. Рассчитать и вывести индекс массы тела(ИМТ) по формуле I = m / (h * h); где m — масса тела в килограммах, h — рост в метрах.

            Console.WriteLine("2. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.");
            Console.WriteLine($"Индекс массы тела (ИМТ) = {(double)(Weight / ((Height/100.0) * (Height/100.0)))}");

            Console.Read();
        }

        static void Task_3()
        {
            //а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)
            //Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
            //б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.


            int x1, y1, x2, y2;
            float r;
            Console.WriteLine("3. Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле");
            Console.Write("x1 = ");
            x1 = int.Parse(Console.ReadLine());
            Console.Write("y1 = ");
            y1 = int.Parse(Console.ReadLine());
            Console.Write("x2 = ");
            x2 = int.Parse(Console.ReadLine());
            Console.Write("y2 = ");
            y2 = int.Parse(Console.ReadLine());

            r = (float)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine("r = {0:f2}", r);

            Console.Read();
        }

        static void Task_4()
        {

            //4.Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.
            //а) с использованием третьей переменной;
            //б) *без использования третьей переменной.

            int a, b, c;
            Console.WriteLine("Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.");
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("с использованием третьей переменной");
            c = a;
            a = b;
            b = c;
            Console.WriteLine($"a = {a} : b = {b}");

            Console.WriteLine("*без использования третьей переменной.");
            a = a + b;
            b = b - a;
            b = -b;
            a = a - b;
            Console.WriteLine($"a = {a} : b = {b}");

            Console.Read();
        }

        static void MetodForTask5(string Text, int x, int y) //*Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).
        {
           
            Console.SetCursorPosition(x, y);
            Console.WriteLine(Text);
        }

        static void Task_5()
        {

            //а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            
            string FirstName, LastName,City;
            Console.Write("Имя: ");
            FirstName = Console.ReadLine();
            Console.Write("Фамилия: ");
            LastName = Console.ReadLine();
            Console.Write("Город проживания: ");
            City = Console.ReadLine();

            Console.WriteLine($"Имя: {FirstName} Фамлия: {LastName} Город: {City}");

            //б) Сделать задание, только вывод организовать в центре экрана.

            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            Console.WriteLine($"Имя: {FirstName} Фамлия: {LastName} Город: {City}");


            //в) *Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).
            string Text;
            int x, y;
            Console.Write("Текст: ");
            Text = Console.ReadLine();
            Console.WriteLine("Введите координаты вывода позиции текста");
            Console.Write("x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("y: ");
            y = int.Parse(Console.ReadLine());

            MetodForTask5(Text, x, y);
            Console.Read();
        }
        static void Main(string[] args)
        {
            int i = 1;
            while (i != 0)
            {
                Console.WriteLine("Здравствуйте. Для выбора задания введите номер задания");
                Console.WriteLine("От 1 до 5");
                Console.WriteLine("Для выхода наберите 0");
                i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 0:
                        return;
                    case 1:
                        Task_1_and_2();
                        break;
                    case 2:
                        Task_1_and_2();
                        break;
                    case 3:
                        Task_3();
                        break;
                    case 4:
                        Task_4();
                        break;
                    case 5:
                        Task_5();
                        break;
                    default:
                        Console.WriteLine("Нет такого");
                        break;
                }
                Console.Clear();
                Console.ReadLine();
            }
        }
    }
}
