using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int input;
            
            //instatiate
            VirtualPet wolf = new VirtualPet();

            //User sets some initial conditions
            Console.WriteLine("Type the name of your wolf and press enter, to allow me to name your wolf, just press enter: ");
            string name = Console.ReadLine();
            if (name!="")
            {
                wolf.Name = name;
            }         
                        
            
            //start owning pet
            do
            {
                Start:;
                //show status
                wolf.ShowInfo();
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1) Feed " +wolf.Name);
                Console.WriteLine("2) Water " + wolf.Name+"(gives water to "+wolf.Name+").");
                Console.WriteLine("3) Play with " + wolf.Name);
                Console.WriteLine("4) Sing " + wolf.Name + " a lullaby.");
                Console.WriteLine("5) Let " + wolf.Name + " outside to mark territory.");
                Console.WriteLine("6) Quit");
                Console.WriteLine("7) Restart");
                input = int.Parse(Console.ReadLine());
                //checks for Restart
                if (input==7)
                {
                    Console.Clear();
                    Main(args);
                    Environment.Exit(0);
                }
                //checks for valid input
                if (input!=1&input!=2 & input !=3 & input !=4 & input !=5 & input !=6)
                {
                    Console.WriteLine("\nPlease type a valid response.\n");
                    goto Start;
                }
                wolf.Tick();
                //update values based off of action
                switch (input)
                {
                    case 1:
                        wolf.Feed();
                        break;
                    case 2:
                        wolf.Water();
                        break;
                    case 3:
                        wolf.Play();
                        break;
                    case 4:
                        wolf.Sleep();
                        break;
                    case 5:
                        wolf.Release();
                        break;
                }
                                
                if (wolf.Energy >= 100)
                {
                    Console.WriteLine(wolf.Name + " just tore your house apart and is laughing at you.  " + wolf.Name + " wants to play.");
                    wolf.Energy = 100;
                }
                if(wolf.Hunger>=100)
                {
                    Console.WriteLine("\n"+wolf.Name + " got hungry and ate the closest piece of meat, which was you.  Sweet dreams Wolf chow...");
                    wolf.Hunger = 0;
                    goto PersonalDeath;
                }                                

            }
            while (input != 6);

            PersonalDeath:
            {
                Console.WriteLine("\n" + "You were not successful owning this wolf.  It ate you.  Type Y and enter to try again, type anything else to exit.");
                if(Console.ReadLine().ToLower()=="y")
                {
                    Console.Clear();
                    Main(args);
                    Environment.Exit(0);
                }                
            }

            
        }
    }
}
