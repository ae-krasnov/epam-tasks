using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            string[] strArray = { "bbabb", "baabb", "aa", "xxxxxxxxxxxxx" };

            Console.WriteLine("Before\n");
            foreach (string s in strArray)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("");

            Task1.StringCompare compareStr = compareTwoString;
            Task1.reOrder reOrderStr = needReOrder;

            string[] res = Task1.BubbleSort(strArray, compareStr, reOrderStr);
            Console.WriteLine("After\n");
            foreach (string s in res)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }

        static int compareTwoString(string a, string b)
        {
            if (a.Length < b.Length)
                return 1;
            else
            {
                if (a.Length > b.Length)
                    return -1;
                else
                    return 0;
            }
        }
        static bool needReOrder(string s1, string s2)
        {
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1.ToCharArray()[i] < s2.ToCharArray()[i])
                    return false;
                if (s1.ToCharArray()[i] > s2.ToCharArray()[i])
                    return true;
            }
            return false;
        }
    }
}
