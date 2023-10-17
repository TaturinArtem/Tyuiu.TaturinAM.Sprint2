using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.TaturinAM.Sprint2.Task5.V6.Lib
{
    public class DataService : ISprint2Task5V6
    {
        public string FindCardNameAndValue(int value1, int value2)
        {
            string res;
            string res1;
            {
                switch (value1)
                {
                    case 6:
                        res = "Шестерка ";
                        break;
                    case 7:
                        res = "Семерка ";
                        break;
                    case 8:
                        res = "Восьмерка ";
                        break;
                    case 9:
                        res = "Девятка ";
                        break;
                    case 10:
                        res = "Десятка ";
                        break;
                    case 11:
                        res = "Валет ";
                        break;
                    case 12:
                        res = "Дама ";
                        break;
                    case 13:
                        res = "Король ";
                        break;
                    case 14:
                        res = "Туз ";
                        break;
                    default:
                        Console.WriteLine("Некорректный номер достоинства карты.");
                        res = "";
                        return res;
                }
                switch (value2)
                {
                    case 1:
                        res1 = "пик";
                        break;
                    case 2:
                        res1 = "треф";
                        break;
                    case 3:
                        res1 = "бубен";
                        break;
                    case 4:
                        res1 = "черв";
                        break;
                    default:

                        Console.WriteLine("Некорректный номер масти.");
                        res1 = "";
                        return res1;
                }
            }
            return res + res1;
        }
    }
}
