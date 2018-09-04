using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    abstract class Enemy : Mover
    {
        public int HitPoints;

        public void Move(Random random)
        {

        }

        public void Hit (int maxDamage, Random random)
        {

        }
    }
}
