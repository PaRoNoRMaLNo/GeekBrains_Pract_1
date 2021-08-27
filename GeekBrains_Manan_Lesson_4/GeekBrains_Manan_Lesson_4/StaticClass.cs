using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrains_Manan_Lesson_4
{
    //Маннанов
    //    2. Реализуйте задачу 1 в виде статического класса StaticClass;
    //    а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
    //    б) Добавьте статический метод для считывания массива из текстового файла.Метод должен возвращать массив целых чисел;
    //    в)* Добавьте обработку ситуации отсутствия файла на диске.
    class StaticClass
    {
        

        int[] mas;//а) Дописать класс для работы с одномерным массивом.
        public int Sum //Создать свойство Sum, которое возвращает сумму элементов массива,
        {
            get
            {
                return mas.Sum();
            }
        }

        public int MaxCount // свойство MaxCount, возвращающее количество максимальных элементов.
        {
            get
            {
                int max = mas.Max();
                return mas.Count((x) => x == max);
            }
        }

        public StaticClass(int Count, int StartValue, int Step)//Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом.
        {
            mas = new int[Count];
            mas[0] = StartValue;
            for (int i = 1; i < Count; i++)
            {
                mas[i] = mas[i - 1] + Step;
            }
        }

        public int[] Inverse() //метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива(старый массив, остается без изменений), 
        {
            int[] mas_inverse = new int[mas.Length];
            for (int i = 0; i < mas.Length; i++)
            {
                mas_inverse[i] = mas[i] * (-1);
            }
            return mas_inverse;
        }
        public void Multi(int a)//метод Multi, умножающий каждый элемент массива на определённое число,
        {
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] *= a;
            }
        }
       
        public static short Check_del(short[] mas)
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
        public static List<short> ReadMasFromFile()
        {
            List<short> lines = new List<short>();
            try
            {
                using (StreamReader reader = new StreamReader("Massiv.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        lines.Add(Convert.ToInt16(line));
                    }
                }
            }
            catch (System.IO.FileNotFoundException) //в)*Добавьте обработку ситуации отсутствия файла на диске.
            {
                Console.WriteLine("Файл отстутсвует");
                return lines;
            }

            return lines;
        }
    }
}
