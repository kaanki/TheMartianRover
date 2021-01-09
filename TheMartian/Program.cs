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
                    rover = cordinates.InitRover();
                }

                if (cordinates.RoverPosition(rover) ==null)
                {
                    continue;
                }

                while (movements == null)
                {
                    movements = cordinates.RoverMovement(rover);
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
