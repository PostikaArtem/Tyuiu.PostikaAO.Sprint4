using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PostikaAO.Sprint4.Task6.V23.Lib;

namespace Tyuiu.PostikaAO.Sprint4.Task6.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Постика А. О. | ИИПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант 23                                                              *");
            Console.WriteLine("* Выполнил: Постика Артём Олегович | ИИПб-23-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [Microsoft, Google, Apple, Amazon,          *");
            Console.WriteLine("* Facebook, Tesla, Netflix] используя класс Array подсчитайте количество  *");
            Console.WriteLine("* элементов, длина которых равна 6.                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            var word = new string[] { "Microsoft", "Google", "Apple", "Amazon", "Facebook", "Tesla", "Netflix" };

            Console.WriteLine("Исходный массив: ");
            for(int i = 0; i <= word.Length - 1; i++)
            {
                Console.WriteLine(word[i]);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Количество элементов длинна которых = 6:");
            int nums = ds.Calculate(word);

            Console.WriteLine(nums);
            Console.ReadKey();

        }
    }
}
