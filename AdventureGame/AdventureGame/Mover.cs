using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    abstract class Mover
    {
        private Point location;
        public Point Location { get; }

        public bool Nearby(Point locationToCheck, int distance)
        {
            return false;
        }

        public Point Move(Direction direction, Rectangle boundaries)
        {
            Point test = new Point();
            test.X = 7;
            test.Y = 6;

            return test;
        }
    }
}
