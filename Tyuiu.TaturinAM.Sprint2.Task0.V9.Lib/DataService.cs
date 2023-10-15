﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.TaturinAM.Sprint2.Task0.V9.Lib
{
    public class DataService : ISprint2Task0V9
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] array = new bool[6];

            array[0] = x == y + 679;
            array[1] = x != y + 1000;
            array[2] = x < y + 1000;
            array[3] = x > y ;
            array[4] = x <= y + 1000;
            array[5] = x >= y +1000;

            return array;
        }
    }
}
