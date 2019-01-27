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
        MultiLevelPort port;
        FormShipConfid form;
        private const int countLevel = 5;

        public FormPort()
        {
            InitializeComponent();
            port = new MultiLevelPort(countLevel, pictureBoxPort.Width, pictureBoxPort.Height);
            for (int i = 0; i < countLevel; i++)
            {
                listBoxLevels.Items.Add("Уровень " + (i + 1));
            }
            listBoxLevels.SelectedIndex = 0;
        }

        private void Draw()
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxPort.Width, pictureBoxPort.Height);
                Graphics gr = Graphics.FromImage(bmp);
                port[listBoxLevels.SelectedIndex].Draw(gr);
                pictureBoxPort.Image = bmp;
            }
        }

        private void buttonMoorBaseShip_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var ship = new BaseShip(100, 1000, dialog.Color);
                    int place = port[listBoxLevels.SelectedIndex] + ship;
                    if (place == -1)
                    {
                        MessageBox.Show("Нет свободных мест", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    Draw();
                }
            }
        }
        
        private void Unmoor_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                if (maskedTextBox.Text != "")
                {
                    var ship = port[listBoxLevels.SelectedIndex] - Convert.ToInt32(maskedTextBox.Text);
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

        private void listBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            form = new FormShipConfid();
            form.AddEvent(AddShip);
            form.Show();
        }

        private void AddShip(ITransport ship)
        {
            if (ship != null && listBoxLevels.SelectedIndex > -1)
            {
                int place = port[listBoxLevels.SelectedIndex] + ship;
                if (place > -1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Корабль не удалось пришвартовать");
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (port.SaveData(saveFileDialog.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно", "Результат",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "Результат", MessageBoxButtons.OK,
MessageBoxIcon.Error);
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (port.LoadData(openFileDialog1.FileName))
                {
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не загрузили", "Результат", MessageBoxButtons.OK,
MessageBoxIcon.Error);
                }
                Draw();
            }
        }
    }
}
