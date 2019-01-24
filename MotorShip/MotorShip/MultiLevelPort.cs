using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorShip
{
    class MultiLevelPort
    {
        List<Port<ITransport>> portStages;
        private const int countPlaces = 20;

        public MultiLevelPort(int countStages, int pictureWidth, int pictureHeight)
        {
            portStages = new List<Port<ITransport>>();
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
    }
}
