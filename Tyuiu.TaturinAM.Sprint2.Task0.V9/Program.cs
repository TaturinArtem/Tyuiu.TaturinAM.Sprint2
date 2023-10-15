using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TaturinAM.Sprint2.Task0.V9.Lib;
namespace Tyuiu.TaturinAM.Sprint2.Task0.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 1054; int y = 375;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            Console.Title = "Спринт #2 | Выполнил: Татурин А. М. | СМАРТб-23-1";
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("- Спринт #2                                                               -");
            Console.WriteLine("- Тема: Операции сравнения                                                -");
            Console.WriteLine("- Задание #0                                                              -");
            Console.WriteLine("- Вариант #9                                                              -");
            Console.WriteLine("- Выполнил: Татурин Артем Максимович | СМАРТб-23-1                        -");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("- Условие: Написать программу из операций сравнений                       -");
            Console.WriteLine("- (==, !=, <, >, <=, >=, последовательность операций не должна нарушаться)-");
            Console.WriteLine("- и арифметических выражений, которая вернет логическую                   -");
            Console.WriteLine("- последовательность(массив): (True, True, True, True, True, False)       -");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("- Исходные данные:                                                        -");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("- x = 1054, y = 375                                                       -");
            Console.WriteLine("---------------------------------------------------------------------------");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}
