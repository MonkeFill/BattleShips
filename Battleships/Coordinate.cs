using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships
{
    internal class Coordinate
    {
        private int _PositionX;
        private int _PositionY;
        private bool _Hit;

        public int PositionX { get => _PositionX; set => _PositionX = value; }
        public int PositionY { get => _PositionY; set => _PositionY = value; }
        public bool Hit { get => _Hit; set => _Hit = value; }

        public Coordinate(int positionX, int positionY, bool hit)
        {
            _PositionX = positionX;
            _PositionY = positionY;
            _Hit = hit;
        }

        public void CheckIfHit(int TargetPositionX, int TargetPositionY)
        {
            if (TargetPositionX == _PositionX)
            {
                if (TargetPositionY == _PositionY)
                {
                    _Hit = true;
                }
            }
        }
    }
}
