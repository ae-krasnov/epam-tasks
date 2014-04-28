using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent
{
    class Task1
    {
        public delegate int StringCompare(string a, string b);//делегат для метода, сравнивающего длину строк
        public delegate bool reOrder(string a, string b);//делегат для метода сравнивающего по алфавиту

        public static string [] BubbleSort(string [] strArr, StringCompare myComparator, reOrder needReOrder) 
        {
            string tmp;

            for (int i = 0; i < strArr.Length-1; i++)
            {
                for (int j = 0; j < strArr.Length-i-1; j++)
                {
                    if(myComparator!=null && needReOrder!=null)
                    {
                        if (myComparator(strArr[j], strArr[j + 1]) == 1)//если у строк разная длина
                        {
                            tmp = strArr[j];
                            strArr[j] = strArr[j + 1];
                            strArr[j + 1] = tmp;
                        }
                        else
                        {
                            if (myComparator(strArr[j], strArr[j + 1]) == 0 && needReOrder(strArr[j], strArr[j + 1]))//если у строк одинаковая длина и они не в алфавитном порядке
                            {
                                tmp = strArr[j];
                                strArr[j] = strArr[j + 1];
                                strArr[j + 1] = tmp;
                            }
                        }
                    }
                }
            }

            return strArr;
        }
    }
}
