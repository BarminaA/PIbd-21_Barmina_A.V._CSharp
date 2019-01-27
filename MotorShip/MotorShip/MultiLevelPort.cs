using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorShip
{
    class MultiLevelPort
    {
        List<Port<ITransport>> portStages;
        private const int countPlaces = 20;
        private int pictureWidth;
        private int pictureHeight;

        public MultiLevelPort(int countStages, int pictureWidth, int pictureHeight)
        {
            portStages = new List<Port<ITransport>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
            for (int i = 0; i < countStages; ++i)
            {
                portStages.Add(new Port<ITransport>(countPlaces, pictureWidth, pictureHeight));
            }
        }

        public Port<ITransport> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < portStages.Count)
                {
                    return portStages[ind];
                }
                return null;
            }
        }

        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                WriteToFile("CountLeveles:" + portStages.Count + Environment.NewLine, fs);
                foreach (var level in portStages)
                {
                    WriteToFile("Level" + Environment.NewLine, fs);
                    foreach (ITransport ship in level)
                    {
                        if (ship.GetType().Name == "BaseShip")
                        {
                            WriteToFile(level.GetKey + ":BaseShip:", fs);
                        }
                        if (ship.GetType().Name == "Ship")
                        {
                            WriteToFile(level.GetKey + ":Ship:", fs);
                        }
                        WriteToFile(ship + Environment.NewLine, fs);
                    }
                }
            }
        }

        private void WriteToFile(string text, FileStream stream)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(text);
            stream.Write(info, 0, info.Length);
        }

        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            string bufferTextFromFile = "";
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                byte[] b = new byte[fs.Length];
                UTF8Encoding temp = new UTF8Encoding(true);
                while (fs.Read(b, 0, b.Length) > 0)
                {
                    bufferTextFromFile += temp.GetString(b);
                }
            }
            bufferTextFromFile = bufferTextFromFile.Replace("\r", "");
            var strs = bufferTextFromFile.Split('\n');
            if (strs[0].Contains("CountLeveles"))
            {
                int count = Convert.ToInt32(strs[0].Split(':')[1]);
                if (portStages != null)
                {
                    portStages.Clear();
                }
                portStages = new List<Port<ITransport>>(count);
            }
            else
            {
                throw new Exception("Неверный формат файла");
            }
            int counter = -1;
            int counterShip = 0;
            ITransport ship = null;
            for (int i = 1; i < strs.Length; ++i)
            {
                if (strs[i] == "Level")
                {
                    counter++;
                    counterShip = 0;
                    portStages.Add(new Port<ITransport>(countPlaces, pictureWidth, pictureHeight));
                    continue;
                }
                if (string.IsNullOrEmpty(strs[i]))
                {
                    continue;
                }
                if (strs[i].Split(':')[1] == "BaseShip")
                {
                    ship = new Ship(strs[i].Split(':')[2]);
                }
                else if (strs[i].Split(':')[1] == "Ship")
                {
                    ship = new Ship(strs[i].Split(':')[2]);
                }
                portStages[counter][counterShip++]= ship;
            }
        }

        public void Sort()
        {
            portStages.Sort();
        }
    }
}
