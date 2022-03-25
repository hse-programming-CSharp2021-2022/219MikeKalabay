using System;

namespace Task01
{
    struct Person : IComparable<Person>
    {
        string name;

        string lastname;

        int age;

        public Person(string name, string lastname, string age)
        {
            this.name = name;
            this.lastname = lastname;
            if (int.Parse(age) < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            this.age = int.Parse(age);
        }

        public int CompareTo(Person other)
        {
            if (age < other.age)
            {
                return -1;
            }
            return 1;
        }

        public override string ToString()
        {
            return name + " " + lastname + " " + age;
        }
    }

    class Program
    {
        public static string Gen(int n)
        {
            Random rand = new Random();
            string now = "";
            for (int i = 0; i < n; ++i)
            {
                now += (char)('a' + rand.Next(0, 26));
            }
            return now;
        }

        static void Main(string[] args)
        {
            int n = 10;
            Person[] characters = new Person[n];
            Random rand = new Random();
            for (int i = 0; i < n; ++i)
            {
                characters[i] = new Person(Gen(rand.Next(1, 7)), Gen(rand.Next(1, 7)), rand.Next(1, 101).ToString());
                Console.WriteLine(characters[i]);
            }
            Array.Sort(characters);
            Console.WriteLine();
            for (int i = 0; i < n; ++i)
            {
                Console.WriteLine(characters[i]);
            }
        }
    }
}