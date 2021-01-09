using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMartian
{
    class Program
    {
        static void Main(string[] args)
        {
            Rover rover = null;
            Cordinates cordinates = new Cordinates();
            bool exitApp = false;
            string movements = null;

            while (!exitApp)
            {
                while (rover == null)
                {
                    Console.WriteLine("Please enter the upper right coordinates in the format X Y");
                    rover = cordinates.InitRover(Console.ReadLine());
                }
                Console.WriteLine("Please enter your rovers intial position");
                if (cordinates.RoverPosition(rover,Console.ReadLine()) ==null)
                {
                    continue;
                }

                while (movements == null)
                {
                    Console.WriteLine("Please enter your rovers movements");
                    movements = cordinates.RoverMovement(rover,Console.ReadLine());
                }

                var results = rover.Move(movements);

                Console.WriteLine("The results of the rover are {0} {1} {2}", results.GetX(), results.GetY(), results.GetDirection());

                Console.WriteLine("Do you want to continue (Y / N)");
                var quit = Console.ReadLine().Trim();

                if (quit.ToUpperInvariant() == "N")
                {
                    exitApp = true;
                }

                movements = null;
            }
        }


    }
}
