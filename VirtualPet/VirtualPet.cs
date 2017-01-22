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
        private int nutrition;
        private int hydration;
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
        //Updates Hunger Level
        public int Nutrition
        {
            get { return this.nutrition; }
            set { this.nutrition = value; }
        }
        //Updates Thirst Level
        public int Hydration
        {
            get { return this.hydration; }
            set { this.hydration = value; }
        }
        //Updates Bowels Level
        public int Bowels
        {
            get { return this.bowels; }
            set { this.bowels = value; }
        }
        //Update PreyDrive
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
            this.nutrition = 50;
            this.hydration = 50;
            this.preyDrive = 50;
            this.bowels = 50;
        }

        //methods
        //Feed
        public void Feed()
        {
            Console.WriteLine("\n******\n"+"You fed " + name + ".");
            nutrition += 35;
            energy += 5;
            hydration -= 5;
            bowels += 7;
            preyDrive -= 15;
        }
        //Give Water
        public void Water()
        {
            Console.WriteLine("\n******\n" + "You watered " + name + ".");
            hydration += 35;
            nutrition -= 5;
            bowels += 7;
            preyDrive += 5;            
        }
        //Exercise 
        public void Play()
        {
            Console.WriteLine("\n******\n" + "You exercised " + name + ".");
            energy -= 25;
            preyDrive -= 15;
            nutrition -= 10;
            hydration -= 15;
        }
        //Release Bowels
        public void Release()
        {
            Console.WriteLine("\n******\n" + name + " marked territory.");
            bowels -= 30;            
        }
        //Sleep
        public void Sleep()
        {
            Console.WriteLine("\n******\n" + name + " slept.");
            energy += 20;
            preyDrive += 5;
            nutrition -= 5;
            hydration -= 10;
        }
        //Tick
        public void Tick()
        {
            nutrition -= 5;
            hydration -= 5;            
            preyDrive += 5;
            Random rand = new Random();
            int randomNum = rand.Next(100);
            //Pet gets random energy burst
            if (randomNum==66||randomNum==1||randomNum==99||randomNum==34||randomNum==6)
            {
                Console.WriteLine("\n!!!!!\nUh oh, " + Name + " got a burst of energy!!\n!!!!!\n");
                energy += 100;
            }
            //Pet goes primal randomly
            else if (randomNum==33||randomNum==35)
            {
                Console.WriteLine("\n!!!!!\nUh oh, " + Name + " went primal!!\n!!!!!\n");
                preyDrive += 100;
            }
        }
        //Show info on console
        public void ShowInfo()
        {
            Console.WriteLine("\nSTATUS:\n");
            Console.WriteLine("\n"+name + " the Wolf");
            Console.WriteLine("Energy: \t" + energy);
            Console.WriteLine("Nutrition: \t" + nutrition);
            Console.WriteLine("Hydration: \t" + hydration);
            Console.WriteLine("Bowels: \t" + bowels);
            Console.WriteLine("Prey Drive: \t" + preyDrive+"\n\n");
        }
    }
}
