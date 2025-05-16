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

        public Ship(string Name, int Size, bool Sunk, char Orientation, Coordinate StartingPoint)
        {
            _Name = Name;
            _Size = Size;
            _Sunk = hit
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
                        ActiveY = StartingPoint.Y + Count;
                        break;
                    case 'S': // Down
                        ActiveY = StartingPoint.Y - Count;
                        break;
                    case 'E': // Right
                        ActiveX = StartingPoint.X + Count;
                        break;
                    case 'W': //Left
                        ActiveX = StartingPoint.X - Count;
                        break;
                    _ShipCoordinates[Count] = new Coordinate(ActiveX, ActiveY);
                }
            }
        }

        public void CheckIfSunk()
        {
            bool ShipSunk = true;
            for (int Count = 0; Count < _Size && ShipSunk != true; Count++)
            {
                ShipSunk = ShipCoordinates[Count].Hit;
            }
            if (ShipSunk == true)
            {
                _Sunk = true;
            }
        }
    }
}
