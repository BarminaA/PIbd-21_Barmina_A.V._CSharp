using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorShip
{
    class Ship : BaseShip, IComparable<Ship>, IEquatable<Ship>
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

        public Ship(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 6)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Tube = Convert.ToBoolean(strs[5]);
                Window = Convert.ToBoolean(strs[6]);
            }
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

        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name + ";" + Tube + ";" + Window;
        }

        public int CompareTo(Ship other)
        {
            var res = (this is Ship).CompareTo(other is Ship);
            if (res != 0)
            {
                return res;
            }
            if (DopColor != other.DopColor)
            {
                DopColor.Name.CompareTo(other.DopColor.Name);
            }
            if (Tube != other.Tube)
            {
                return Tube.CompareTo(other.Tube);
            }
            if (Window != other.Window)
            {
                return Window.CompareTo(other.Window);
            }
            return 0;
        }

        public bool Equals(Ship other)
        {
            var res = (this as BaseShip).Equals(other as BaseShip);
            if (!res)
            {
                return res;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (Tube != other.Tube)
            {
                return false;
            }
            if (Window != other.Window)
            {
                return false;
            }
            return true;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Ship carObj = obj as Ship;
            if (carObj == null)
            {
                return false;
            }
            else
            {
                return Equals(carObj);
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}