using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMartian
{
    public  class Position
    {
        private int _X { get; set; }
        private int _Y { get; set; }
        private char _Direction { get; set; }

        public Position(int x, int y,char direction) 
        {
            _X = x;
            _Y = y;
            _Direction = direction;
        }

        public int GetX() { return _X; }
        public int GetY() { return _Y; }
        public string GetDirection() { return _Direction.ToString() ; }




    }
}
