using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorShip
{
    class PortAlreadyHaveException : Exception
    {
        public PortAlreadyHaveException() : base("В порту уже есть такой корабль")
        { }
    }
}
