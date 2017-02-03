using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MethodOveriding
{
    class Program
    {
       public static  void Main(string[] args)
        {
            
            Animal animal = new Animal("Bobik",100);
            AskAnimalToSay(animal);

            Animal dog = new Dog("Rex",10);

            AskAnimalToSay(dog);

            Animal labrador = new Labrador("Botsman",20);
            AskAnimalToSay(labrador);
            Console.ReadKey();
            

        }

        private static void AskAnimalToSay(Animal animal)
        {
            Console.WriteLine(animal.ToString());
            Console.WriteLine($"Animal {animal.Name} give sound");
            animal.Say();
            Console.WriteLine(animal.ToString());
            Console.WriteLine();
        }

        public static void Run()
        {

        }
    }

    public class Labrador :Dog 
    {
        public Labrador(string name, int food): base("",0)
        {
            this.Food = food*2;
            this.Name = "King "+ name;
        }
        public override void Say()
        {
            Console.WriteLine("Hau! Hau!");
        }

    }
    public class Dog:Animal
    {
        public Dog(string name, int food) : base(name, food)
        {
            Console.WriteLine("We call constructor with 2 parameters in dog");
        }

        public override void Say()
        {
            Console.WriteLine("We call method say in Dog");
            base.Say();
            Console.WriteLine("Hau!");

        }
    }
    public class Animal
    {
        public int Food;
        public float Speed;
        public string Name;

        public Animal(string name, int Food, float Speed)
        {
           this.Food = Food;
           this.Speed = Speed;
            this.Name = name;
        }

        public Animal(string name, int food) : this(name, food, 0)
        {
            Console.WriteLine("We call constructor with 2 parameters in Animal");
        }

        public Animal(string name) : this(name,0 ) { }

        public Animal(): this("No Name") { }

        public override string ToString()
        {
            return $"{nameof(Food)}: {Food}, {nameof(Speed)}: {Speed}, {nameof(Name)}: {Name}";
        }

        public virtual void Say()
        {
            Food--;
            Console.WriteLine("We call method Say in Animal");
        }

    }
}
