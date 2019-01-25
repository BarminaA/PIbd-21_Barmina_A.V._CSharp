using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorShip
{
    class BaseShip : Vehicle
    {
        protected const int shipWidth = 100;
        private const int shipHeight = 80;

        public BaseShip(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        public BaseShip(string info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }

        public override void MoveShip(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - shipWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - shipHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        public override void DrawShip(Graphics g)
        {
            Pen pen = new Pen(MainColor);
            g.DrawLine(pen, _startPosX + 40, _startPosY - 20, _startPosX + 130, _startPosY - 20);
            g.DrawLine(pen, _startPosX + 60, _startPosY + 10, _startPosX + 110, _startPosY + 10);
            g.DrawLine(pen, _startPosX + 60, _startPosY + 10, _startPosX + 40, _startPosY - 20);
            g.DrawLine(pen, _startPosX + 130, _startPosY - 20, _startPosX + 110, _startPosY + 10);

            g.DrawRectangle(pen, _startPosX + 60, _startPosY - 40, 50, 20);
            g.DrawRectangle(pen, _startPosX + 70, _startPosY - 55, 10, 15);
            g.DrawRectangle(pen, _startPosX + 90, _startPosY - 55, 10, 15);

            g.DrawEllipse(pen, _startPosX + 80, _startPosY - 35, 10, 10);
            g.DrawEllipse(pen, _startPosX + 60, _startPosY - 35, 10, 10);
            g.DrawEllipse(pen, _startPosX + 100, _startPosY - 35, 10, 10);
            g.DrawEllipse(pen, _startPosX + 50, _startPosY - 15, 10, 10);
            g.DrawEllipse(pen, _startPosX + 70, _startPosY - 15, 10, 10);
            g.DrawEllipse(pen, _startPosX + 90, _startPosY - 15, 10, 10);
            g.DrawEllipse(pen, _startPosX + 110, _startPosY - 15, 10, 10);
        }

        public override string ToString()
        {
            return MaxSpeed + ";" + Weight + ";" + MainColor.Name;
        }
    }
}
