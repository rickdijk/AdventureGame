using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Bat : Enemy
    {
        public Bat(Game game, Point location)
            : base(game, location, 6)
        { }

        public override void Move(Random random)
        {
            // Your code will go here
            if (Dead)
                return;
            else
            {
                int i = random.Next(2);
                Direction direction;
                switch (i)
                {
                    case 1:
                        direction = (Direction)random.Next(4);
                        base.location = base.Move(direction, game.Boundaries);
                        break;
                    case 2:
                        direction = FindPlayerDirection(game.PlayerLocation);
                        break;
                    default:
                        break;
                }
                if (NearPlayer())
                {
                    game.HitPlayer(2, random);
                }
            }
        }
    }
}
