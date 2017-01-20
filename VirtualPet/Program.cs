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
            string input;

            //instatiate
            VirtualPet wolf = new VirtualPet();

            //User sets some initial conditions
            Console.WriteLine("Type the name of your wolf and press enter: ");
            wolf.Name = Console.ReadLine();
            Console.WriteLine("On a scale of 0 to 100 (100 is highest energy), type the current energy level of"+wolf.Name+" and press enter: ");
            wolf.Energy = int.Parse(Console.ReadLine());
            Console.WriteLine("On a scale of 0 to 100 , type the current prey drive of\n" + wolf.Name + " (100 is kill mode) and press enter: ");
            wolf.PreyDrive = int.Parse(Console.ReadLine());
            //show status
            wolf.ShowInfo();
            //start owning pet
            do
            {
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("");
                input = Console.ReadLine().ToLower();
            }
            while (input != "q");
            
        }
    }
}
