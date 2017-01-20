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
                //checks for Restart, restarts if wanted
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
                  
                //Energy gets too high/low              
                if (wolf.Energy >= 100)
                {
                    wolf.Energy = 100;
                    Console.WriteLine("\n!!!ENERGY LEVEL=100!!!\n"+wolf.Name + " just tore your house apart and is laughing at you.  " + wolf.Name + " wants to play.");                    
                }
                if (wolf.Energy <= 0)
                {
                    wolf.Energy = 0;
                    Console.WriteLine("\n!!!ENERGY LEVEL=0!!!\n" + wolf.Name + " died of exhaustion.  " + wolf.Name + " needed to rest.");
                    goto Death;
                }
                //Wolf gets hungry
                if (wolf.Nutrition<=0)
                {
                    wolf.Nutrition = 100;
                    Console.WriteLine("\n!!!HUNGER LEVEL=100!!!\nYou starved "+wolf.Name + "! So "+wolf.Name+" got hungry and ate the closest piece of meat, which was you.  Sweet dreams Wolf chow...");
                    goto Death;
                }
                if (wolf.Nutrition >=100)
                {
                    wolf.Nutrition = 0;
                    Console.WriteLine("\n!!!HUNGER LEVEL=0!!!\n" + wolf.Name + " is well fed and getting fat...");                    
                }
                //Wolf gets thirsty
                if(wolf.Hydration<=0)
                {
                    wolf.Hydration = 0;
                    Console.WriteLine("\n!!!HYDRATION LEVEL=0!!!\n" + wolf.Name + " got thirsty and drank all your blood to survive.");
                    goto Death;
                }
                if (wolf.Hydration >= 100)
                {
                    wolf.Hydration = 100;
                    Console.WriteLine("\n!!!HYDRATION LEVEL=100!!!\n" + wolf.Name + " is hydrated.");
                }
                //Wolf goes primal
                if (wolf.PreyDrive>=100)
                {
                    wolf.PreyDrive = 100;
                    Console.WriteLine("\n!!!PREY DRIVE LEVEL=100!!!\n" + wolf.Name + " got primal and you became its prey.  Wolves do wolve things...");
                    goto Death;
                }
                if (wolf.PreyDrive <= 0)
                {
                    wolf.PreyDrive = 100;
                    Console.WriteLine("\n!!!PREY DRIVE LEVEL=0!!!\n" + wolf.Name + " was domesticated by you Wolf Whisperer.  For now...");
                }
                //Wolf drops a load
                if (wolf.Bowels>=100)
                {
                    wolf.Bowels = 50;
                    Console.WriteLine("\n!!!Bowels=100!!!\n" + wolf.Name + " marked their territory all over your living quarters...");                    
                }
                if(wolf.Bowels<=0)
                {
                    wolf.Bowels = 0;
                }
                Console.WriteLine("\nType any key to continue.");
                Console.ReadKey();
            }
            while (input != 6);
            Environment.Exit(0);

            Death:
            {
                Console.WriteLine("\n" + "You were not successful owning this wolf.  \nType Y and press enter to try again. \nType anything else to exit.");
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
