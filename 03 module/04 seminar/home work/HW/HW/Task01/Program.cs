using System;

namespace Task01
{
    public abstract class Creature
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public Creature(string name, string location)
        {
            Name = name;
            Location = location;
        }
        public abstract void RingIsFoundEventHandlerMethod(object sender, RingIsFoundEventArgs e);
    }

    public class RingIsFoundEventArgs : EventArgs
    {
        public string Message { get; set; }

        public RingIsFoundEventArgs(string s)
        {
            Message = s;
        }
    }

    public class Wizard : Creature
    {
        public delegate void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs a);

        public event RingIsFoundEventHandler RaiseRingIsFoundEvent;

        public Wizard(string s, string Location) : base(s, Location) 
        {
        }

        public void SomeThisIsChangedInTheAir()
        {
            Console.WriteLine(Name + " >> Кольцо " +
                "найдено у старого Бильбо! Призываю вас в Ривендейл! ");
            RaiseRingIsFoundEvent(this, new RingIsFoundEventArgs("Ривендейл"));
        }

        public override void RingIsFoundEventHandlerMethod(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine("ничего.");
        }
    }

    public class Hobbit : Creature
    {
        public Hobbit(string s, string Location) : base(s, Location)
        {
        }

        public void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine(Name + " >> Покидаю" +
                " Шир! Иду в " + e.Message);
        }

        public override void RingIsFoundEventHandlerMethod(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine("ничего.");
        }
    }

    public class Human : Creature
    {

        public Human(string s, string Location) : base(s, Location)
        {
        }

        public void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine(Name + " >> Волше" +
                "бник" + ((Wizard)sender).Name + " позвал. Моя цель " + e.Message);
        }

        public override void RingIsFoundEventHandlerMethod(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine("ничего.");
        }
    }

    public class Elf : Creature
    {
        public Elf(string s, string Location) : base(s, Location)
        {
        }

        public void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine(
                Name + " >> Звёзды светят не так ярко как обычно. " +
                "Цветы увядают. Листья предсказывают идти в " +
                e.Message);
        }

        public override void RingIsFoundEventHandlerMethod(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine("ничего.");
        }
    }

    public class Dwarf : Creature
    {

        public Dwarf(string s, string Location) : base(s, Location)
        {
        }

        public void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine($"{Name} >> Точим топоры, собираем припасы! Выдвигаемся в " + e.Message);
        }

        public override void RingIsFoundEventHandlerMethod(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine("ничего.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Wizard wizard = new Wizard("Гендальф", "что-то");
            Hobbit[] hobbits = new Hobbit[4];
            for (int i = 0; i < 4; i++)
            {
                hobbits[i] = new Hobbit("Хоббит " + i, "где-то");
                wizard.RaiseRingIsFoundEvent += hobbits[i].RingIsFoundEventHandler;
            }
            Human[] humans = { new Human("Боромир", "когда-то"), new Human("Арагорн", "когда-то") };
            Elf elf = new Elf("Леголас", "-то");
            Dwarf dwarf = new Dwarf("Гимли", "-то");
            wizard.RaiseRingIsFoundEvent += dwarf.RingIsFoundEventHandler;
            wizard.RaiseRingIsFoundEvent += elf.RingIsFoundEventHandler;
            foreach (Human h in humans)
            {
                wizard.RaiseRingIsFoundEvent += h.RingIsFoundEventHandler;
            }
            wizard.SomeThisIsChangedInTheAir();

        }
    }
}