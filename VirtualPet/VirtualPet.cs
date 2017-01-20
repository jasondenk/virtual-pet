using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class VirtualPet
    {
        //fields
        private int energy;
        private int hunger;
        private int thirst;
        private int bowels;
        private int preyDrive;
        private string name;

        //properties
        //Establishes Name
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        //Updates Energy Level
        public int Energy
        {
            get { return this.energy; }
            set { this.energy = value; }
        }
        //Update need to release bowels
        public int PreyDrive
        {
            get { return this.preyDrive; }
            set { this.preyDrive = value; }
        }

        //constructor
        public VirtualPet()
        {
            this.name = "Loki";
            this.energy = 50;
            this.hunger = 50;
            this.thirst = 50;
            this.preyDrive = 50;
            this.bowels = 50;
        }

        //methods
        //Feed
        public void Feed()
        {
            Console.WriteLine("You fed " + name + ".");
            hunger += 15;
            energy += 5;
            bowels += 7;
            preyDrive -= 10;
        }
        //Give Water
        public void Water()
        {
            Console.WriteLine("You watered " + name + ".");
            thirst += 15;
            bowels += 7;
            preyDrive += 5;            
        }
        //Exercise 
        public void Play()
        {
            Console.WriteLine("You exercised " + name + ".");
            energy -= 15;
            preyDrive -= 10;
            hunger -= 10;
            thirst -= 10;
        }
        //Release Bowels
        public void Release()
        {
            Console.WriteLine(name + "marked territory.");
            bowels -= 30;
            preyDrive += 5;            
        }
        //Sleep
        public void Sleep()
        {
            Console.WriteLine(name + "slept.");
            energy += 30;
            preyDrive += 10;
            hunger -= 5;
            thirst -= 10;
        }
        //Tick
        public void Tick()
        {
            hunger += 3;
            thirst += 3;
            preyDrive += 10;
        }
        //Show info on console
        public void ShowInfo()
        {
            Console.WriteLine(name + "the Wolf");
            Console.WriteLine("Energy: " + energy);
            Console.WriteLine("Hunger: " + hunger);
            Console.WriteLine("Thirst: " + thirst);
            Console.WriteLine("Bowels: " + bowels);
            Console.WriteLine("Prey Drive: " + preyDrive);
        }
    }
}
