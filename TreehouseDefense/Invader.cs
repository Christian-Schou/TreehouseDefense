using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseDefense
{
    class Invader
    {
        private readonly Path _path;
        private int _pathStep = 0;

        public MapLocation Location => _path.GetLocationAt(_pathStep);

        public int Healt { get; private set; } = 2;

        //True if the Invader has reached the end of the path
        public bool HasScored { get { return _pathStep >= _path.Length; } }

        public bool IsNeutralized => Healt <= 0;

        public bool IsActive => !(IsNeutralized || HasScored);

        public Invader(Path path)
        {
            _path = path;
        }

        //Add 1 to the _pathStep field
        public void Move() => _pathStep += 1;

        //Functionality for decreasing healt of an Invader
        public void DecreaseHealt(int factor)
        {
            Healt -= factor;
        }
    }
}
