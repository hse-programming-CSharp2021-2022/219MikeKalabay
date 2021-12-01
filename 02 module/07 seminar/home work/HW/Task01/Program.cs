using System;

namespace Task01
{
    class Creature
    {
        private string name;

        private double speed;

        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }

        public double Speed
        {
            set
            {
                speed = value;
            }
            get
            {
                return speed;
            }
        }

        virtual public string Run()
        {
            return "I am running with a speed of " + speed + ".";
        }

        public Creature(string n, double s)
        {
            name = n;
            speed = s;
        }

        public override string ToString()
        {
            return Run() + " My name is " + name + ".";
        }
    }

    class Dwarf : Creature
    {
        private int strength;

        public int Strength
        {
            set
            {
                strength = value;
            }
            get
            {
                return strength;
            }
        }

        public Dwarf(string n, double s, int st) : base(n, s)
        {
            if (st < 1 || st > 20)
            {
                Random rand = new Random();
                strength = rand.Next(1, 21);
            }
        }

        public override string Run()
        {
            return "I am running with a speed of " + Speed + ". My strength is " + strength;
        }

        public void MakeNewStaff()
        {
            Console.WriteLine("I've created a new staff!");
        }
    }

    class Elf : Creature
    {
        private int age;

        public int Age
        {
            set
            {
                age = value;
            }
            get
            {
                return age;
            }
        }

        public Elf(string n, double s) : base(n, s)
        {
            Random rand = new Random();
            age = rand.Next(100, 201);
            if (age >= 154)
            {
                Speed += 1;
            }
        }

        public override string Run()
        {
            return "I am running with a speed of " + Speed + ". My age is " + age;
        }
    }

    class Program
    {
        static string GetName()
        {
            Random rand = new Random();
            string res = "";
            res += (char)('A' + rand.Next(0, 'Z' - 'A' + 1));
            for (int i = 0; i < 2 + rand.Next(0, 6); ++i)
            {
                if (rand.Next(0, 2) == 0)
                {
                    res += (char)('a' + rand.Next(0, 'z' - 'a' + 1));
                }
                else
                {
                    res += (char)('A' + rand.Next(0, 'Z' - 'A' + 1));
                }
            }
            return res;
        }

        static void Main(string[] args)
        {
            do 
            {
                int n;
                while (!int.TryParse(Console.ReadLine(), out n) || n > 100 || n < 1)
                {
                    continue;
                }
                Creature[] a = new Creature[n];
                for (int i = 0; i < n; ++i)
                {
                    Random rand = new Random();
                    int now = rand.Next(1, 101);
                    if (now <= 20)
                    {
                        a[i] = new Creature(GetName(), 10 + rand.NextDouble() * 8);
                    }
                    else if (now <= 60)
                    {
                        a[i] = new Dwarf(GetName(), 10 + rand.NextDouble() * 8, rand.Next(-50, 51));
                    }
                    else
                    {
                        a[i] = new Elf(GetName(), 10 + rand.NextDouble() * 8);
                    }
                }
                for (int i = 0; i < n; ++i)
                {
                    if (a[i] is Elf)
                    {
                        Console.WriteLine("Elf: " + a[i].Name);
                        Console.WriteLine(a[i].Run());
                    }
                    else if (a[i] is Dwarf)
                    {
                        Console.WriteLine("Dwarf: " + a[i].Name);
                        Console.WriteLine(a[i].Run());
                        ((Dwarf)a[i]).MakeNewStaff();
                    }
                    else if (a[i] is Creature)
                    {
                        Console.WriteLine("Creature: " + a[i].Name);
                        Console.WriteLine(a[i].Run());
                    }
                }
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
