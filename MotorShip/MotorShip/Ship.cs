using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorShip
{
    class Ship
    {
        private float _startPosX;
        private float _startPosY;
        private int _pictureWidth;
        private int _pictureHeight;
        private const int shipWidth = 100;
        private const int shipHeight = 80;
        public int MaxSpeed { private set; get; }
        public float Weight { private set; get; }
        public Color MainColor { private set; get; }
        public Color DopColor { private set; get; }

        public Ship(int maxSpeed, float weight, Color mainColor, Color dopColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;

        }

        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }

        public void MoveShip(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight; switch (direction)
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

        public void DrawShip(Graphics g)
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

            Brush brush = new SolidBrush(DopColor);
            g.FillEllipse(brush, _startPosX + 80, _startPosY - 35, 10, 10);
            g.FillEllipse(brush, _startPosX + 60, _startPosY - 35, 10, 10);
            g.FillEllipse(brush, _startPosX + 100, _startPosY - 35, 10, 10);
            g.FillEllipse(brush, _startPosX + 50, _startPosY - 15, 10, 10);
            g.FillEllipse(brush, _startPosX + 70, _startPosY - 15, 10, 10);
            g.FillEllipse(brush, _startPosX + 90, _startPosY - 15, 10, 10);
            g.FillEllipse(brush, _startPosX + 110, _startPosY - 15, 10, 10);

            Brush brushSmoke = new SolidBrush(MainColor);
            g.FillEllipse(brushSmoke, _startPosX + 50, _startPosY - 65, 15, 10);
            g.FillEllipse(brushSmoke, _startPosX + 55, _startPosY - 60, 15, 10);
            g.FillEllipse(brushSmoke, _startPosX + 70, _startPosY - 65, 15, 10);
            g.FillEllipse(brushSmoke, _startPosX + 75, _startPosY - 60, 15, 10);
        }
    }
}