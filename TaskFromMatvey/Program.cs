using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFromMatvey
{
    class Program
    {
        static void Main(string[] args)
        {
            // сделали массив и заложили в нем предложение

            string[] task = new string[5];

            task[0] = "Вы ввели нулевое слово";
            task[1] = "Матвей";
            task[2] = "самый";
            task[3] = "жесткий";
            task[4] = "пацан";

            //каждое слово = номер в одной ячейке

            Console.WriteLine("\"Матвей самый жесткий пацан.\""); // само предложение
            Console.WriteLine("Введите номер слова:");

            string a = Console.ReadLine(); // Ввод символа пользователем
            int b = Convert.ToInt32(a); // Конвертируем в int, т.к. в СИ, ввод = string

            if (b == 0)
                // номер слова а предложении = ячейка массива
                Console.WriteLine(task[0]);
            else if (b == 1)
                Console.WriteLine(task[1]);
            else if (b == 2)
                Console.WriteLine(task[2]);
            else if (b == 3)
                Console.WriteLine(task[3]);
            else if (b == 3)
                Console.WriteLine(task[4]);
            Console.ReadKey();                      // задержка
        }
    }
}
