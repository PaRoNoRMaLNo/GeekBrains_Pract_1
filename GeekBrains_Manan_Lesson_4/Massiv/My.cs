using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massiv
{
    public class My //Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу библиотеки
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

        public My(int Count, int StartValue, int Step)//Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом.
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
        public void Write()
        {
            Console.WriteLine("\n Элементы массива");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(mas[i]);
            }
            
        }
    }
}
