using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorShip
{
    class PortNotFoundException : Exception
    {
        public PortNotFoundException(int i) : base("Не найден корабль по месту " + i) { }
    }
}
