using System;

namespace OOP_Lab3._3
{
    public class Parent
    {
        protected string name;//ім'я
        protected int rik;//рік народження

        public Parent()
        {
        }

        public Parent(string name, int rik)
        {
            this.name = name;
            this.rik = rik;
        }
        public void Print()
        {
            Console.WriteLine("{0} народився у {1} році", name, rik);
        }
        public int Metod1(int potochniy)
        {
            return potochniy - rik;
        }
    }

    public class Child : Parent
    {
        int sumb;//Сума балів, отриманих на іспиті

        public Child(string name, int rik, int sumb) : base(name, rik)
        {
            this.sumb = sumb;
        }

        public new void Print()
        {
            base.Print();
            Console.WriteLine("Набрав {0} балів", sumb);
        }
        public bool Metod2(int prohb)//prohb - прохідний бал
        {
            if (prohb <= sumb)
            {
                return true;
            }
            else return false;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Random rnd = new Random();
            int potochrik = 2023;
            int prohbal = 8;
            for(int i = 0; i < 4; i++)
            {
                try
                {
                    int a = rnd.Next(1, 3);
                    if (a == 1)
                    {
                        Console.WriteLine("1");
                        Console.Write("Ім'я: ");
                        string name = Console.ReadLine();
                        Console.Write("Рік народження: ");
                        int rik = Int32.Parse(Console.ReadLine());
                        Console.WriteLine();
                        if (rik <= potochrik)
                        {
                            Parent pa = new Parent(name, rik);
                            pa.Print();
                            int vik = pa.Metod1(potochrik);
                            Console.WriteLine("{0} - {1} років", name, vik);
                        }
                        else
                        {
                            Console.WriteLine("Помилка. Введено некоректну дату");
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("2");
                        Console.Write("Ім'я: ");
                        string name = Console.ReadLine();
                        Console.Write("Рік народження: ");
                        int rik = Int32.Parse(Console.ReadLine());
                        Console.Write("Кількість балів: ");
                        int sumb = Int32.Parse(Console.ReadLine());
                        Console.WriteLine();
                        if (rik <= potochrik)
                        {
                            Child ch = new Child(name, rik, sumb);
                            ch.Print();
                            int vik = ch.Metod1(potochrik);
                            Console.WriteLine("{0} - {1} років", name, vik);
                            Console.Write("Прохідний бал {0}: ", prohbal);
                            bool result = ch.Metod2(prohbal);
                            if (result == true)
                            {
                                Console.WriteLine("ПРОЙШОВ");
                            }
                            else { Console.WriteLine("НЕ ПРОЙШОВ"); }
                        }
                        else { Console.WriteLine("Помилка. Введено некоректну дату"); }
                        Console.WriteLine();
                    }
                }
                catch { Console.WriteLine("Помилка"); }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
