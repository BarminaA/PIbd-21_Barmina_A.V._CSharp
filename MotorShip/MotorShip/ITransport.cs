using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorShip
{
    public interface ITransport
    {
        void SetPosition(int x, int y, int width, int height);
        void MoveShip(Direction direction);
        void DrawShip(Graphics g);
        void SetMainColor(Color color);
    }
}
