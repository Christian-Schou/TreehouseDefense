using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseDefense
{
    class Tower
    {
        private readonly MapLocation _location;

        public Tower(MapLocation location)
        {
            _location = location;
        }

        public void FireOnInvaders(Invader[] invaders)
        {
            for (int index = 0; index < invaders.Length; index++)
            {
                Invader invader = invaders[index];
                //Do stuff with invader
            }
        }

    }
}
