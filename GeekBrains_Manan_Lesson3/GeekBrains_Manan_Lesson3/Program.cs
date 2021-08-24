using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrains_Manan_Lesson3
{
    //Маннанов а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
             //б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса.
             //в) Добавить диалог с использованием switch демонстрирующий работу класса.
    class Complex
    {

        #region Public Methods

        public static Complex operator +(Complex complex1, Complex complex2)//Сложение
        {
            return new Complex { Re = complex1.Re + complex2.Re, Im = complex1.Im + complex2.Im };
        }
        public static Complex operator -(Complex complex1, Complex complex2)//Вычитание
        {
            return new Complex { Re = complex1.Re - complex2.Re, Im = complex1.Im - complex2.Im };
        }
        public static Complex operator *(Complex complex1, Complex complex2)//Умножение
        {
            return new Complex { Re = complex1.Re * complex2.Re, Im = complex1.Im * complex2.Im };
        }
        public static Complex operator /(Complex complex1, Complex complex2)//Деление
        {
            return new Complex { Re = complex1.Re / complex2.Re, Im = complex1.Im / complex2.Im };
        }
        public override string ToString()
        {
            return $"{_re} {_im}i";
        }

        #endregion

        #region Constructors

        public Complex() { }

        public Complex(double re, double im)
        {
            _re = re;
            this._im = im;
        }

        #endregion

        #region Fields

        private double _re;
        private double _im;

        #endregion

        #region Properties

        public double Re
        {
            get { return _re; }
            set { _re = value; }
        }

        public double Im
        {
            get { return _im; }
            set { _im = value; }
        }

        #endregion
    }

    struct Complex_str
    {
        /// <summary>
        /// Действительная часть комплексного числа
        /// </summary>
        public double re;

        /// <summary>
        /// Мнимая часть комплексного числа
        /// </summary>
        public double im;

        public Complex_str(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        /// <summary>
        /// Сложение комплексных чисел
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public Complex_str Plus(Complex_str x)
        {
            Complex_str y;
            y.re = re + x.re;
            y.im = im + x.im;

            return y;
        }

        public static Complex_str Plus(Complex_str x, Complex_str y)
        {
            Complex_str z;
            z.re = y.re + x.re;
            z.im = y.im + x.im;

            return z;
        }
        public static Complex_str Substr(Complex_str x, Complex_str y) // Метод вычитания комплексных чисел
        {
            Complex_str z;
            z.re = y.re + x.re;
            z.im = y.im + x.im;

            return z;
        }
        public override string ToString()
        {
            base.ToString();
            return $"{re} + {im}i";
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex_str complex_Str1 = new Complex_str(4, 1);
            Complex_str complex_Str2 = new Complex_str(7, 2);
            Console.WriteLine($"Работа с комплексными числами (структура){complex_Str1} и {complex_Str2}");
            Console.WriteLine($"Результат вычитания комплексных чисел (структура) {Complex_str.Substr(complex_Str1, complex_Str2)}");

            Complex complex1 = new Complex(5, -2);
            Complex complex2 = new Complex(-1, 3);

            Console.WriteLine($"Работа с комплексными числами (класс){complex1} и {complex2}");
            char a = ' ';
            while (a != '0')
            {
                Console.Write("Введите символ для демонстрации работы с комплексными числами (+,-,*,/), для выхода 0: ");
                a = Convert.ToChar(Console.ReadLine());
                switch (a)
                {
                    case '+':
                        Console.WriteLine($"Результат сложения комплексных чисел {complex1 + complex2}");
                        break;
                    case '-':
                        Console.WriteLine($"Результат вычитания комплексных чисел {complex1 - complex2}");
                        break;
                    case '*':
                        Console.WriteLine($"Результат умножения комплексных чисел {complex1 * complex2}");
                        break;
                    case '/':
                        Console.WriteLine($"Результат деления комплексных чисел {complex1 / complex2}");
                        break;
                    case '0':
                        return;
                    default:
                        Console.WriteLine("Вы ввели неверный символ!");
                        break;
                }
            }
        }
    }
}
