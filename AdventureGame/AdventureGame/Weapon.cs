using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    abstract class Weapon : Mover
    {
        private string name;
        public string Name { get; internal set; }

        public bool PickedUp;

        public Weapon()
        {

        }

    }
}
