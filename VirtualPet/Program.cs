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
            int inputInt;
            int i = 0;
            Program main = new Program();
            
            //instatiate
            VirtualPet wolf = new VirtualPet();

            //User gives name or is given default name
            Console.WriteLine("Type the name of your wolf and press enter, to allow me to name your wolf, just press enter: ");
            string name = Console.ReadLine();
            if (name!="")
            {
                wolf.Name = name;
            }        
            
            //start owning pet
            do
            {
                //goto Start if no valid input
                Start:;
                //Every turn updates some values, happens after every input, even if invalid input
                wolf.Tick();
                //show status
                wolf.ShowInfo();
                Console.WriteLine("What do you want to do?   (Type number and press enter)");
                Console.WriteLine("1) Feed " +wolf.Name);
                Console.WriteLine("2) Water " + wolf.Name+"(gives water to "+wolf.Name+").");
                Console.WriteLine("3) Play with " + wolf.Name);
                Console.WriteLine("4) Sing " + wolf.Name + " a lullaby.");
                Console.WriteLine("5) Let " + wolf.Name + " outside to mark territory.");
                Console.WriteLine("6) Quit");
                Console.WriteLine("7) Restart");
                string input = Console.ReadLine();                              
                //checks for Restart, restarts if wanted
                if (input=="7")
                {
                    main.Restart();
                }
                //checks for valid input, repeats options if not valid by goto Start
                if (input!="1"&input!="2" & input !="3" & input !="4" & input !="5" & input !="6")
                {
                    Console.WriteLine("\nPlease type a valid response.\n");
                    goto Start;
                }
                //changes string input to integer
                inputInt = int.Parse(input);
                //update values based off of selection by performing methods
                switch (inputInt)
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
                //checks levels after performing level updates
                wolf.Levels();                  
                
                //if 6)exit gets selected, it will state this, exit while loop and then hit the Environment.Exit(0) after the next if statement
                Console.WriteLine("\nType any key to continue.");
                Console.ReadKey();
                i++;
            }
            while (inputInt != 6 & i<20);
            
            //after 20 repitions, Congratulate wolf owner and quit or restart.
            if (i>=20)
            {
                Console.WriteLine("\nWolf master, you have demonstrated the ability to be a great leader.  The wild\nis calling you.");
                Console.WriteLine("Type 1 and enter to restart or type anything else + enter to leave civilization with " + wolf.Name + ".");
                if(Console.ReadLine()=="1")
                {
                    Console.Clear();
                    Main(args);
                    Environment.Exit(0);
                }
                else
                {
                    //ASCII art with messages
                    Console.WriteLine("\n\n\t\t\tOWOOOOOOOOOO!");
                    Console.WriteLine("                     .\n                    / V\n                  / `  /\n                 <<   |\n                 /    |\n               /      |\n             /        |\n           /    \\  \\ /\n          (      ) | |\n  ________ | _ / _ | |\n< __________\\______)\\__)");
                    Console.WriteLine("\nRUN FREE WILDTHING! \n\n Type any key to exit.");
                    Console.ReadKey();
                }
            }
            Environment.Exit(0);                                   
        }
        //If wolf dies or "eats" owner, this gets called.
        public void Death()
        {
            Console.WriteLine("\n" + "You were not successful owning this wolf.  \nType Y and press enter to try again. \nType anything else to exit.");
            if (Console.ReadLine().ToLower() == "y")
            {
                Restart();
            }
            else { Environment.Exit(0); }
        }
        //Restarts Virtual Pet Game
        public void Restart()
        {
            string[] args = { };
            Console.Clear();
            Main(args);
            Environment.Exit(0);
        }
    }
}
