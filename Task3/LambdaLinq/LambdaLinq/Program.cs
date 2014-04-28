using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            int[] MyArr = new int[100];
            Random r = new Random();

            for (int i = 0; i < MyArr.Length; i++)
            {
                MyArr[i] = r.Next(10);
            }

            Console.WriteLine("Сумма элементов массива: {0}", Task1.SummArray(MyArr));

            Console.WriteLine("Проверка на число.\nВведите вашу строку:");
            string str=Console.ReadLine();

            Console.WriteLine("Вы ввели целое положительное число: {0}", Task2.IsPositiveNumber(str));

            for (int i = 0; i < MyArr.Length; i++)
            {
                if (r.Next() % 2 == 0)
                    MyArr[i] = MyArr[i] * (-1);
            }

            Task3.Find(MyArr);

            Console.ReadLine();
        }

    }
}
