using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class MultiLevelHangar
    {
        List<Hangar<IAircraft>> hangarStages;

        private const int countPlaces = 16;

        public MultiLevelHangar(int countStages, int pictureWidth, int pictureHeight)
        {
            hangarStages = new List<Hangar<IAircraft>>();
            for (int i = 0; i < countStages; ++i)
            {
                hangarStages.Add(new Hangar<IAircraft>(countPlaces, pictureWidth, pictureHeight));
            }
        }

        public Hangar<IAircraft> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < hangarStages.Count)
                {
                    return hangarStages[ind];
                }
                return null;
            }
        }
    }
}
