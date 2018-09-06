using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Ghoul : Enemy
    {
        public Ghoul(Game game, Point location)
            : base(game, location, 10)
        { }

        public override void Move(Random random)
        {
            if (Dead)
                return;
            else
            {
                int i = random.Next(3);
                Direction direction;
                switch (i)
                {
                    case 1:
                        break;
                    case int n when n > 1:
                        direction = FindPlayerDirection(game.PlayerLocation);
                        break;
                    default:
                        break;
                }
                if (NearPlayer())
                {
                    game.HitPlayer(4, random);
                }
            }
        }
    }
}
