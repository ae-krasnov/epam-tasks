using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Event
{
    public class Person
    {
        public delegate void MyHandler(object sender, Person per, MyEventArgs e);

        public event MyHandler Hello;//событие-приход на работу
        public event MyHandler GoodBy;//событие-уход с работы

        public string Name { get; set; }

        private static List<Person> office = new List<Person>();//список всех сотрудников в оффисе

        public Person(string name) 
        {
            Name = name;
            Hello += Hi;//привязываем методы обработчики
            GoodBy += By;
            office.Add(this);//добавляем сотрудника в список
        }

        void Hi(object sender, Person per, MyEventArgs e)
        {
            if (sender is Person)
            {
                Person p = (Person)sender;
                if (e.Time < 12)
                    Console.WriteLine("Доброе утро, {0}-сказал {1}", p.Name, per.Name);
                else
                {
                    if (e.Time >= 12 && e.Time <= 17)
                        Console.WriteLine("Добрый день, {0}-сказал {1}", p.Name, per.Name);
                    else
                        Console.WriteLine("Добрый вечер, {0}-сказал {1}", p.Name, per.Name);
                }
            }
        }

        void By(object sender, Person per, MyEventArgs e)
        {
            if (sender is Person)
            {
                Person p = (Person)sender;
                Console.WriteLine("До свидание, {0}-сказал {1}", p.Name, per.Name);
            }
        }

        public void goToWork(MyEventArgs e) //пришел на работы
        {
            foreach (Person p in office)//проходим по списку и вызываем событие приветствие
            {
                if(p!=this)
                    Hello(this, p, e);  
            }

        }
        public void goToHome(MyEventArgs e)//ушел с работы
        {
            foreach (Person p in office)//проходим по списку и прощаемся с ушедшим
            {
                if(p!=this)
                    GoodBy(this, p, e); 
            }
            office.Remove(this);//удаляем из общего списка тех, кто на работе
        }
        
    }
}
