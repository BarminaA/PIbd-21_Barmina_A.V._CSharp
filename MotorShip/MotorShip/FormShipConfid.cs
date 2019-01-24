using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorShip
{
    public partial class FormShipConfid : Form
    {
        ITransport ship = null;
        private event shipDelegate eventAddShip;

        public FormShipConfid()
        {
            InitializeComponent();
            Black.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;
            panelGray.MouseDown += panelColor_MouseDown;
            Green.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            White.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelOrange.MouseDown += panelColor_MouseDown;
            buttonMark.Click += (object sender, EventArgs e) => { Close(); };
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (ship != null)
            {
                ship.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawShip();
            }
        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (ship != null)
            {
                if (ship is Ship)
                {
                    (ship as Ship).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawShip();
                }
            }
        }

        private void DrawShip()
        {
            if (ship != null)
            {
                Bitmap bmp = new Bitmap(ShipBox.Width, ShipBox.Height);
                Graphics gr = Graphics.FromImage(bmp);
                ship.SetPosition(-20, 65, ShipBox.Width, ShipBox.Height);
                ship.DrawShip(gr);
                ShipBox.Image = bmp;
            }
        }

        public void AddEvent(shipDelegate ev)
        {
            if (eventAddShip == null)
            {
                eventAddShip = new shipDelegate(ev);
            }
            else
            {
                eventAddShip += ev;
            }
        }

        private void BaseShip_MouseDown(object sender, MouseEventArgs e)
        {
            BaseShip.DoDragDrop(BaseShip.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void MotorShip_MouseDown(object sender, MouseEventArgs e)
        {
            MotorShip.DoDragDrop(MotorShip.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void panelShip_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void panelShip_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Корабль":
                    ship = new BaseShip(100, 500, Color.White);
                    break;
                case "Теплоход":
                    ship = new Ship(100, 500, Color.White, Color.Black, true, true);
                    break;
            }
            DrawShip();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            eventAddShip?.Invoke(ship);
            Close();
        }
    }
}
