using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorShip
{
    class Ship : BaseShip
    {
        public Color DopColor { private set; get; }
        public bool Tube { private set; get; }
        public bool Window { private set; get; }

        public Ship(int maxSpeed, float weight, Color mainColor, Color dopColor, bool tube, bool window) : base(maxSpeed, weight, mainColor)
        {
            DopColor = dopColor;
            Tube = tube;
            Window = window;
        }

        public override void DrawShip(Graphics g)
        {
            Pen pen = new Pen(MainColor);
            g.DrawLine(pen, _startPosX + 40, _startPosY - 20, _startPosX + 130, _startPosY - 20);
            g.DrawLine(pen, _startPosX + 60, _startPosY + 10, _startPosX + 110, _startPosY + 10);
            g.DrawLine(pen, _startPosX + 60, _startPosY + 10, _startPosX + 40, _startPosY - 20);
            g.DrawLine(pen, _startPosX + 130, _startPosY - 20, _startPosX + 110, _startPosY + 10);

            if (Tube)
            {
                g.DrawRectangle(pen, _startPosX + 60, _startPosY - 40, 50, 20);
                g.DrawRectangle(pen, _startPosX + 70, _startPosY - 55, 10, 15);
                g.DrawRectangle(pen, _startPosX + 90, _startPosY - 55, 10, 15);
            }

            g.DrawEllipse(pen, _startPosX + 80, _startPosY - 35, 10, 10);
            g.DrawEllipse(pen, _startPosX + 60, _startPosY - 35, 10, 10);
            g.DrawEllipse(pen, _startPosX + 100, _startPosY - 35, 10, 10);
            g.DrawEllipse(pen, _startPosX + 50, _startPosY - 15, 10, 10);
            g.DrawEllipse(pen, _startPosX + 70, _startPosY - 15, 10, 10);
            g.DrawEllipse(pen, _startPosX + 90, _startPosY - 15, 10, 10);
            g.DrawEllipse(pen, _startPosX + 110, _startPosY - 15, 10, 10);

            if (Window)
            {
                Brush brush = new SolidBrush(DopColor);
                g.FillEllipse(brush, _startPosX + 80, _startPosY - 35, 10, 10);
                g.FillEllipse(brush, _startPosX + 60, _startPosY - 35, 10, 10);
                g.FillEllipse(brush, _startPosX + 100, _startPosY - 35, 10, 10);
                g.FillEllipse(brush, _startPosX + 50, _startPosY - 15, 10, 10);
                g.FillEllipse(brush, _startPosX + 70, _startPosY - 15, 10, 10);
                g.FillEllipse(brush, _startPosX + 90, _startPosY - 15, 10, 10);
                g.FillEllipse(brush, _startPosX + 110, _startPosY - 15, 10, 10);
            }

            if (Tube)
            {
                Brush brushSmoke = new SolidBrush(MainColor);
                g.FillEllipse(brushSmoke, _startPosX + 50, _startPosY - 65, 15, 10);
                g.FillEllipse(brushSmoke, _startPosX + 55, _startPosY - 60, 15, 10);
                g.FillEllipse(brushSmoke, _startPosX + 70, _startPosY - 65, 15, 10);
                g.FillEllipse(brushSmoke, _startPosX + 75, _startPosY - 60, 15, 10);
            }
        }

        public void SetDopColor(Color color)
        {
            DopColor = color;
        }
    }
}