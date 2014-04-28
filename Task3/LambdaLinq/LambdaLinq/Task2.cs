using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaLinq
{
    public static class Task2
    {
        public static bool IsPositiveNumber(this string str) 
        {
            bool IsNumber = true;
            for (int i = 0; i < str.Length; i++)
            {
                if (!(str[i] >= '0' && str[i] <= '9'))
                {
                    IsNumber = false;
                    break;
                }
            }
            return IsNumber;
        }
    }
}
