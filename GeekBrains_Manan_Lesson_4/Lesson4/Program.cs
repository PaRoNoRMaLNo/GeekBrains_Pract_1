using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class Program
    {
        //Маннанов
        //4. Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив.Создайте структуру Account, содержащую Login и Password.
        struct Account
        {
            public string Login;
            public string Password;
        }
        static bool CheckAcc(string[,] acc,Account account)
        {
            for (int i = 0; i < acc.Length / 2; i++)
            {
                if (account.Login == acc[i, 0] && account.Password == acc[i, 1])
                    return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            string[,] acc = new string[System.IO.File.ReadAllLines("Accounts.txt").Length / 2,2];
            using (StreamReader reader = new StreamReader("Accounts.txt "))
            {
                string line;
                int count = 0;
                int row = 0;
                while ((line = reader.ReadLine()) != null)
                {

                    if (count % 2 == 0)
                    {
                        acc[row, 0] = line;
                        count++;
                    }
                    else
                    {
                        acc[row, 1] = line;
                        count++;
                        row++;
                    }
                    
                }
            }

            Account account = new Account();
            Console.Write("Введите Логин: ");
            account.Login = Console.ReadLine();
            Console.Write("Введите Пароль: ");
            account.Password = Console.ReadLine();
            if (CheckAcc(acc, account))
                Console.WriteLine("Вы зашли");
            else
                Console.WriteLine("Неправильные данные");
            Console.ReadKey();
        }
    }
}
