using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Event
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            MyEventArgs morning = new MyEventArgs();
            morning.Time = 9;
            Console.WriteLine("[На работу пришел Джон]");
            Person jhon = new Person("Джон");
            jhon.goToWork(morning);

            morning.Time = 10;
            Console.WriteLine("[На работу пришел Хъюго]");
            Person hugo = new Person("Хъюго");
            hugo.goToWork(morning);

            MyEventArgs day = new MyEventArgs();
            day.Time = 13;
            Console.WriteLine("[На работу пришел Билл]");
            Person bill = new Person("Билл");
            bill.goToWork(day);

            day.Time = 15;
            Console.WriteLine("[С работы ушел Джон]");
            jhon.goToHome(day);

            MyEventArgs evening = new MyEventArgs();
            evening.Time = 18;
            Console.WriteLine("[С работы ушел Хъюго]");
            hugo.goToHome(evening);

            evening.Time = 19;
            Console.WriteLine("[С работы ушел Билл]");
            bill.goToHome(evening);
            
            Console.ReadLine();
        }

    }
}
