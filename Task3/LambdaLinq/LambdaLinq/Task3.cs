using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LambdaLinq
{
    public static class Task3
    {
        delegate void FindPositiveByDelegate(int[] arr);

        static Stopwatch watch = new Stopwatch();

        public static long MillisecondForFindPositive = 0;
        public static long MillisecondForFindPositiveByDelegeta = 0;
        public static long MillisecondForFindPositiveByAnonumMethod = 0;
        public static long MillisecondForFindPositiveByLambda = 0;
        public static long MillisecondForFindPositiveByLinq = 0;

        public static void Find(int[] arr)
        {

            watch.Start();
            for (int i = 0; i < 100; i++)
            {
                FindPositive(arr);
            }
            watch.Stop();
            MillisecondForFindPositive = watch.ElapsedMilliseconds;

            watch.Restart();
            for (int i = 0; i < 100; i++)
            {
                FindPositiveByDelegate findDelegate = FindPositiveByDelegata;
                findDelegate(arr);
            }
            watch.Stop();
            MillisecondForFindPositiveByDelegeta = watch.ElapsedMilliseconds;

            watch.Restart();
            for (int j = 0; j < 100; j++)
            {
                FindPositiveByDelegate findByAnonumMethod = delegate(int[] MyArr)
                {
                    Console.WriteLine("Поиск через анонимный метод");
                    for (int i = 0; i < MyArr.Length; i++)
                    {
                        
                        if (MyArr[i] >= 0)
                            Console.WriteLine(MyArr[i]);
                    }
                };
                findByAnonumMethod(arr);
            }
            watch.Stop();
            MillisecondForFindPositiveByAnonumMethod = watch.ElapsedMilliseconds;

            watch.Restart();
            FindPositiveByDelegate findByLambda = ((int[] MyArr) =>
            {
                Console.WriteLine("Поиск через лямбда-выражение");
                for (int i = 0; i < MyArr.Length; i++)
                {

                    if (MyArr[i] >= 0)
                        Console.WriteLine(MyArr[i]);
                }
            });
            for (int j = 0; j < 100; j++)
            {
                findByLambda(arr); 
            }
            watch.Stop();
            MillisecondForFindPositiveByLambda = watch.ElapsedMilliseconds;

            watch.Restart();
            for (int i = 0; i < 100; i++)
            {
                FindByLinq(arr); 
            }
            watch.Stop();
            MillisecondForFindPositiveByLinq = watch.ElapsedMilliseconds;

            Console.WriteLine("Время на прямой поиск: {0}",MillisecondForFindPositive);
            Console.WriteLine("Время на поиск через делегат: {0}", MillisecondForFindPositiveByDelegeta);
            Console.WriteLine("Время на поиск через анонимный метод: {0}", MillisecondForFindPositiveByAnonumMethod);
            Console.WriteLine("Время на поиск через лямбда-выражение: {0}", MillisecondForFindPositiveByLambda);
            Console.WriteLine("Время на поиск через Linq: {0}", MillisecondForFindPositiveByLinq);
        }

        static void FindPositive(int [] arr)
        {
            Console.WriteLine("Поиск напрямую");
            for (int i = 0; i < arr.Length; i++)
            {
                
                if (arr[i] >= 0)
                    Console.WriteLine(arr[i]);
            }
        }

        static void FindPositiveByDelegata(int[] arr)
        {
            Console.WriteLine("Поиск через делегат");
            for (int i = 0; i < arr.Length; i++)
            {
                
                if (arr[i] >= 0)
                    Console.WriteLine(arr[i]);
            }
        }

        static void FindByLinq(int[] arr)
        {
            Console.WriteLine("Поиск через Linq");

            var found = from elem in arr
                        where elem >= 0
                        select elem;
            foreach (var num in found)
            {
                Console.WriteLine(num);
            }
        }
    }

}
