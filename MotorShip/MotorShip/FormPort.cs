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
    public partial class FormPort : Form
    {
        Port<ITransport> port;
        public FormPort()
        {
            InitializeComponent();
            port = new Port<ITransport>(20, pictureBoxPort.Width, pictureBoxPort.Height);
            Draw();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxPort.Width, pictureBoxPort.Height);
            Graphics gr = Graphics.FromImage(bmp);
            port.Draw(gr);
            pictureBoxPort.Image = bmp;
        }

        private void buttonMoorBaseShip_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var ship = new BaseShip(100, 1000, dialog.Color);
                int place = port + ship;
                Draw();
            }
        }

        private void buttonMoorShip_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var ship = new Ship(100, 1000, dialog.Color, dialogDop.Color, true, true);
                    int place = port + ship;
                    Draw();
                }
            }
        }

        private void Unmoor_Click(object sender, EventArgs e)
        {
            if (maskedTextBox.Text != "")
            {
                var ship = port - Convert.ToInt32(maskedTextBox.Text);
                if (ship != null)
                {
                    Bitmap bmp = new Bitmap(pictureBoxUnmoor.Width, pictureBoxUnmoor.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    ship.SetPosition(-20, 65, pictureBoxUnmoor.Width, pictureBoxUnmoor.Height);
                    ship.DrawShip(gr);
                    pictureBoxUnmoor.Image = bmp;
                }
                else
                {
                    Bitmap bmp = new Bitmap(pictureBoxUnmoor.Width, pictureBoxUnmoor.Height);
                    pictureBoxUnmoor.Image = bmp;
                }
                Draw();
            }
        }
    }
}
