using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMartian
{
    public class Cordinates
    {
        public Rover InitRover()
        {
            Console.WriteLine("Please enter the upper right coordinates in the format X Y");
            var initCoordinates = Console.ReadLine().Trim().Split(' ');

            if (initCoordinates.Length != 2)
            {
                return null;
            }

            if (!int.TryParse(initCoordinates[0], out int x) ||
                !int.TryParse(initCoordinates[1], out int y))
            {

                return null;
            }

            return new Rover(x, y);
        }

        public Rover RoverPosition(Rover rover)
        {
            Console.WriteLine("Please enter your rovers intial position");
            var intialPos = Console.ReadLine().Trim().Split(' ');

            if (intialPos.Length != 3)
            {
                return null;
            }

            if (!int.TryParse(intialPos[0], out int rovX) ||
               !int.TryParse(intialPos[1], out int rovY) ||
               !char.TryParse(intialPos[2], out char dir))
            {
                return null;
            }

            if (!rover.DirArray.Contains(char.ToUpperInvariant(dir)))
            {
                return null;
            }

            rover.InitialPosition(rovX, rovY, dir);
            return rover;
        }

        public string RoverMovement(Rover rover)
        {
            Console.WriteLine("Please enter your rovers movements");
            var movements = Console.ReadLine().Trim();

            if (movements.ToUpperInvariant().IndexOfAny(rover.CmdArray) != 0)
            {
                return null;
            }

            return movements;
        }

    }
}
