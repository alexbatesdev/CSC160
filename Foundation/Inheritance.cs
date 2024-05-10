using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation
{
    internal class Inheritance
    {
        public static void Execute()
        {
            Animal animal = new Animal();
            animal.Name = "Cat";
            Animal animal2 = new Animal("Dog", true, 10);
            Animal animal3 = new Animal() { Name = "Lion" };

            Mammal human = new Mammal("Larry", false, 80, false, true);
            human.speak();
            
            Animal humanAgain = new Mammal("Allegro", false, 25, false, true);
            humanAgain.speak();
        }
    }

    class Mammal: Animal
    {
        public bool isCarnivore { get; set; }
        
        public bool livesOnLand { get; set; }

        public Mammal(string name, bool isNocturnal, int lifespan, bool isCarnivore, bool livesOnLand) : base(name, isNocturnal, lifespan)
        {
            this.isCarnivore = isCarnivore;
            this.livesOnLand = livesOnLand;
        }

        public void speak()
        {
            Console.WriteLine(Name + " speaks (Mammal Class)");
        }
    }

    class Animal
    {
        private int lifespan;

        public string Name { get; set; }
        public bool isNocturnal { get; }

        public Animal(string name, bool isNocturnal, int lifespan)
        {
            this.Name = name;
            this.isNocturnal = isNocturnal;
            this.lifespan = lifespan;
        }

        public Animal() { }

        public void speak() 
        {
            Console.WriteLine(Name + " speaks (Animal Class)");
        }


    }
}
