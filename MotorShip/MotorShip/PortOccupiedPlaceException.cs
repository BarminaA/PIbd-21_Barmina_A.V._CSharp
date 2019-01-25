using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorShip
{
    class PortOccupiedPlaceException : Exception
    {
        public PortOccupiedPlaceException(int i) : base("На месте " + i + " уже стоит корабль") { }
    }
}
