using System;
using System.Text;
using System.Collections.Generic;

namespace Task01
{
    abstract class Person
    {
        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        private string pocket;

        public string Pocket
        {
            get
            {
                return pocket;
            }
            set
            {
                pocket = value;
            }
        }

        public abstract void Receive(string present);

        public Person(string personName)
        {
            name = personName;
        }

        public override string ToString()
        {
            return "Person name = " + name;
        }
    }

    class SnowMaiden : Person
    {
        public SnowMaiden(string personName) : base(personName) { }

        public string[] CreatePresents(int amount)
        {
            Random rand = new Random();
            string[] res = new string[amount];
            for (int i = 0; i < amount; ++i)
            {
                StringBuilder now = new StringBuilder();
                for (int j = 0; j < 3; ++j)
                {
                    now.Append((char)rand.Next(0, 128));
                }
                for (int j = 1; j >= 0; --j)
                {
                    now.Append(now[j]);
                }
                res[i] = now.ToString();
            }
            return res;
        }

        public override void Receive(string present)
        {
            if (Pocket != null)
            {
                throw new ArgumentException("pocket не пустое");
            }
            Pocket = present;
        }
    }

    class Santa : Person
    {
        private List<string> sack;

        public List<string> Sack
        {
            get
            {
                return sack;
            }
            set
            {
                sack = value;
            }
        }

        public Santa(string personName) : base(personName) 
        {
            sack = new List<string>();
        }

        public void Request(SnowMaiden snowMaiden, int amount)
        {
            string[] presents = snowMaiden.CreatePresents(amount);
            for (int i = 0; i < presents.Length; ++i)
            {
                sack.Add(presents[i]);
            }
        }

        public void Give(Person person)
        {
            if (sack.Count == 0)
            {
                throw new Exception("sack пустое");
            }
            Random rand = new Random();
            int index = rand.Next(0, sack.Count);
            person.Receive(sack[index]);
            sack.RemoveAt(index);
        }

        public override void Receive(string present)
        {
            if (Pocket != null)
            {
                throw new ArgumentException("pocket не пустое");
            }
            Pocket = present;
        }
    }

    class Child : Person
    {
        private string additionalPocket;

        public Child(string personName) : base(personName) { }

        public override void Receive(string present)
        {
            if (Pocket != null && additionalPocket != null)
            {
                throw new ArgumentException("pocket и additionalPocket не пустое");
            }
            if (Pocket == null)
            {
                Pocket = present;
            }
            else
            {
                additionalPocket = present;
            }
        }
    }

    class Program
    {
        static bool CheckSanta(List<Person> persons)
        {
            for (int i = 0; i < persons.Count; ++i)
            {
                if (persons[i].ToString() == "Person name = Santa")
                {
                    return true;
                }
            }
            return false;
        }

        static bool CheckOnlySanta(List<Person> persons)
        {
            return persons.Count == 1 && persons[0].ToString() == "Person name = Santa";
        }

        static bool CheckSnowMaiden(List<Person> persons)
        {
            for (int i = 0; i < persons.Count; ++i)
            {
                if (persons[i].ToString() == "Person name = SnowMaiden")
                {
                    return true;
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            do
            {
                Santa santa = new Santa("Santa");
                SnowMaiden snowMaiden = new SnowMaiden("SnowMaiden");
                List<Person> persons = new List<Person>();
                persons.Add(santa);
                persons.Add(snowMaiden);
                for (int i = 0; i < 10; ++i)
                {
                    persons.Add(new Child("Child " + i));
                }
                Random rand = new Random();
                while (CheckSnowMaiden(persons))
                {
                    int count = rand.Next(1, 5);
                    santa.Request(snowMaiden, count);
                    for (int q = 0; q < count; ++q)
                    {
                        if (rand.Next(1, 101) <= 10)
                        {
                            try
                            {
                                Console.WriteLine(persons[0].ToString());
                                persons[0].Receive(santa.Sack[q]);
                            }
                            catch
                            {
                                persons.RemoveAt(0);
                            }
                        }
                        else
                        {
                            int x = rand.Next(1, persons.Count);
                            try
                            {
                                Console.WriteLine(persons[x].ToString());
                                persons[x].Receive(santa.Sack[q]);
                            }
                            catch
                            {
                                persons.RemoveAt(x);
                            }
                        }
                        if (CheckOnlySanta(persons) || !CheckSanta(persons))
                        {
                            break;
                        }
                    }
                    if (CheckOnlySanta(persons) || !CheckSanta(persons))
                    {
                        break;
                    }
                }
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}