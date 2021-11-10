using System;

namespace Task02
{
    abstract class Animal
    {
        protected string Name { get; set; }
        protected int Age { get; set; }
        public abstract string AnimalSound();
        public abstract string AnimalInfo();
    }
    class Dog : Animal
    {
        public Dog(string name, int age, string dogBreed, bool isTrained)
        { Name = name; Age = age; DogBreed = dogBreed; IsTrained = isTrained; }
        private string DogBreed { get; }
        private bool IsTrained { get; }
        public override string AnimalSound()
        {
            return "Gav Gav Gav";
        }
        public override string AnimalInfo()
        {
            string ans = "";
            ans += "name - " + Name + '\n';
            ans += "age - " + Age + '\n';
            ans += "dog breed - " + DogBreed + '\n';
            ans += "is trained - " + IsTrained;
            return ans;
        }
    }
    class Cow : Animal
    {
        public Cow(string name, int age, int cntMilk)
        { Name = name; Age = age; CntMilk = cntMilk; }
        private int CntMilk { get; }
        public override string AnimalSound()
        {
            return "Moo Moo Moo";
        }
        public override string AnimalInfo()
        {
            string ans = "";
            ans += "name - " + Name + '\n';
            ans += "age - " + Age + '\n';
            ans += "cnt milk - " + CntMilk;
            return ans;
        }
    }
    class Program
    {
        static void Main()
        {
            Dog dog = new Dog("Godel", 71, "human", false);
            Cow cow = new Cow("Murka", 21, 179);
            Console.WriteLine(dog.AnimalSound());
            Console.WriteLine(dog.AnimalInfo());
            Console.WriteLine("-------------------");
            Console.WriteLine(cow.AnimalSound());
            Console.WriteLine(cow.AnimalInfo());
        }
    }
}