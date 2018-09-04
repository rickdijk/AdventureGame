using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Player : Mover
    {
        public IEnumerable<Weapon> Weapons;
        public int HitPoints;

        public Player(Game game, Point point)
        {

        }

        public void Attack(Direction direction, Random random)
        {

        }

        public Point Move(Direction direction)
        {
            Point test = new Point();
            test.X = 7;
            test.Y = 6;

            return test;    
        }

        public void Equip(string weaponName)
        {

        }

        public void Hit(int maxDamage, Random random)
        {

        }

        public void IncreaseHealth(int health, Random random)
        {
            throw new NotImplementedException();
        }
    }
}
