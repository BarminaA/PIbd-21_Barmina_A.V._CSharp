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
    public partial class FormShip : Form
    {
        private ITransport ship;

        public FormShip()
        {
            InitializeComponent();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxShip.Width, pictureBoxShip.Height);
            Graphics gr = Graphics.FromImage(bmp);
            ship.DrawShip(gr);
            pictureBoxShip.Image = bmp;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            ship = new BaseShip(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Black);
            ship.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxShip.Width, pictureBoxShip.Height);
            Draw();
        }

        private void buttonCreateShip_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            ship = new Ship(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Black, Color.Blue, true, true);
            ship.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxShip.Width, pictureBoxShip.Height);
            Draw();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    ship.MoveShip(Direction.Up);
                    break;
                case "buttonDown":
                    ship.MoveShip(Direction.Down);
                    break;
                case "buttonLeft":
                    ship.MoveShip(Direction.Left);
                    break;
                case "buttonRight":
                    ship.MoveShip(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}
