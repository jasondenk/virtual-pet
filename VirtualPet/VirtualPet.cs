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
            bowels += 10;
            preyDrive -= 15;
        }
        //Give Water
        public void Water()
        {
            Console.WriteLine("\n******\n" + "You watered " + name + ".");
            hydration += 35;
            nutrition -= 5;
            bowels += 10;
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
        //if Levels get too high/low
        public void Levels()
        {
            Program main = new Program();
            //Energy gets too high/low              
            if (Energy >= 100)
            {
                Energy = 100;
                Console.WriteLine("\n!!!ENERGY LEVEL=100!!!\n" + Name + " just tore your house apart and is laughing at you.  " + Name + " wants to play.");
            }
            if (Energy <= 0)
            {
                Energy = 0;
                Console.WriteLine("\n!!!ENERGY LEVEL=0!!!\n" + Name + " died of exhaustion.  " + Name + " needed to rest.");
                main.Death();
            }
            //Wolf gets hungry or is overfed
            if (Nutrition <= 0)
            {
                Nutrition = 0;
                Console.WriteLine("\n!!!NUTRITION LEVEL=0!!!\nYou starved " + Name + "! So " + Name + " got hungry and ate the closest piece of meat, which was you.  Sweet dreams Wolf chow...");
                main.Death();
            }
            if (Nutrition >= 100)
            {
                Nutrition = 100;
                Console.WriteLine("\n!!!NUTRITION LEVEL=100!!!\n" + Name + " is well fed and getting fat...");
            }
            //Wolf gets thirsty or is hydrated
            if (Hydration <= 0)
            {
                Hydration = 0;
                Console.WriteLine("\n!!!HYDRATION LEVEL=0!!!\n" + Name + " got thirsty and drank all your blood to survive.");
                main.Death();
            }
            if (Hydration >= 100)
            {
                Hydration = 100;
                Console.WriteLine("\n!!!HYDRATION LEVEL=100!!!\n" + Name + " is hydrated.");
            }
            //Wolf goes primal
            if (PreyDrive >= 100)
            {
                PreyDrive = 100;
                Console.WriteLine("\n!!!PREY DRIVE LEVEL=100!!!\n" + Name + " got primal and you became its prey.  Wolves do wolve things...");
                main.Death();
            }
            if (PreyDrive <= 0)
            {
                PreyDrive = 100;
                Console.WriteLine("\n!!!PREY DRIVE LEVEL=0!!!\n" + Name + " was domesticated by you Wolf Whisperer.  For now...");
            }
            //Wolf drops a load
            if (Bowels >= 100)
            {
                Bowels = 50;
                Console.WriteLine("\n!!!Bowels=100!!!\n     (   )\n  ()(\n   ) _)\n    ( \\_\n  _(_\\ \\)__\n (____\\___)) " + Name + " marked territory all over your living quarters...");
            }
            if (Bowels <= 0)
            {
                Bowels = 0;
            }
        }
        
    }
}
