using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships
{
    internal class Ship
    {
        private string _Name;
        private int _Size;
        private Coordinate[] _ShipCoordinates; 
        private bool _Sunk;

        public string Name { get => _Name; set => _Name = value; }
        public int Size { get => _Size; set => _Size = value; }
        public bool Sunk { get => _Sunk; set => _Sunk = value; }
        public Coordinate[] ShipCoordinates { get => _ShipCoordinates; set => _ShipCoordinates = value; }

        public Ship(string Name, int Size, char Orientation, Coordinate StartingPoint)
        {
            _Name = Name;
            _Size = Size;
            _Sunk = false;
            //Loop for each coordinate the ship will have
            for (int Count = 0; Count < _Size; Count++)
            {
                //Adding active X and Y coordinate variables for creating the shipes
                int ActiveX;
                int ActiveY;
                //A switch statement to determine which way the ship will be facing from its starting point
                
                switch (Orientation)
                {
                    case 'N': // Up
                        ActiveY = StartingPoint.PositionY + Count;
                        break;
                    case 'S': // Down
                        ActiveY = StartingPoint.PositionY - Count;
                        break;
                    case 'E': // Right
                        ActiveX = StartingPoint.PositionX + Count;
                        break;
                    case 'W': //Left
                        ActiveX = StartingPoint.PositionX - Count;
                        break;
                    _ShipCoordinates[Count] = new Coordinate(ActiveX, ActiveY);
                }
            }
        }

        public void CheckIfSunk()
        {
            for (int Count = 0; Count < _Size && _Sunk != false; Count++)
            {
                _Sunk = ShipCoordinates[Count].Hit;
            }
        }
    }
}
