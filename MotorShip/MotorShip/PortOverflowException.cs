using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorShip
{
    class PortOverflowException : Exception
    {
        public PortOverflowException() : base("В порту нет свободных мест") { }
    }
}
