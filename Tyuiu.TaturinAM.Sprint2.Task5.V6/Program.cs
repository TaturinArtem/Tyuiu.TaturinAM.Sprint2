﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TaturinAM.Sprint2.Task5.V6.Lib;
namespace Tyuiu.TaturinAM.Sprint2.Task5.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Татурин А. М. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Татурин Артем Максимович | СМАРТб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет        *");
            Console.WriteLine("* требуемое значение и возвращает результат.                              *");
            Console.WriteLine("* Условие: Мастям игральных карт условно присвоены следующие порядковые   *");
            Console.WriteLine("* номера: масти «пики» — 1, масти «трефы» — 2, масти «бубны» — 3, масти   *");
            Console.WriteLine("* «червы» — 4, а достоинству карт: «валету» — 11, «даме» — 12,            *");
            Console.WriteLine("* «королю» — 13, «тузу» — 14 (порядковые номера карт остальных достоинств *");
            Console.WriteLine("* соответствуют их названиям: «шестерка», «девятка» и т. п.). По заданным *");
            Console.WriteLine("* номеру масти m (1 <= m <= 4) и номеру достоинства карты k (6 <= k <= 14)*");
            Console.WriteLine("* определить полное название (масть и достоинство) соответствующей карты в*");
            Console.WriteLine("* виде «Дама пик», Шестерка бубен» и т. п.                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите достоинство карты: ");
            int value1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите масть карты: ");
            int value2 = Convert.ToInt32(Console.ReadLine());

            string res;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            res = ds.FindCardNameAndValue(value1, value2);

            Console.WriteLine("Это карта: " + res);

            Console.ReadKey();
        }
    }
}
