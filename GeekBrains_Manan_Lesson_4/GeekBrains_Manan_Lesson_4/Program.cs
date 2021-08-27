using System;
using System.Collections.Generic;
namespace GeekBrains_Manan_Lesson_4
{
    //Маннанов
    //1. Дан целочисленный массив из 20 элементов.Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно.
    //    Заполнить случайными числами.Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3.
    //    В данной задаче под парой подразумевается два подряд идущих элемента массива.
    class Program
    {
        static short Check_del(short[] mas)
        {
            short count = 0;
            for (int i = 0; i < mas.Length - 1; i++)
            {
                if (mas[i] % 3 == 0 || mas[i + 1] % 3 == 0)
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            short[] mas = new short[20];
            Random random = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = (short)random.Next(-10000, 10001);
                Console.WriteLine($"{mas[i]}");
            }
            Console.WriteLine("Количество пар: " + Check_del(mas));

           
            
            Console.WriteLine("\nЧисла из файла");// б) Добавьте статический метод для считывания массива из текстового файла.Метод должен возвращать массив целых чисел;
            List<short> list = StaticClass.ReadMasFromFile();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }


            //б)** Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу библиотеки
            Massiv.My massiv = new Massiv.My(10, 1, 3);
            massiv.Write();
            Console.WriteLine("Количество макс элементов = " + massiv.MaxCount);
            Console.WriteLine("Сумма элементов = " + massiv.Sum);
            Console.Read();
        }
    }
}
