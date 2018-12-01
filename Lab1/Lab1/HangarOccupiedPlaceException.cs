using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class HangarOccupiedPlaceException : Exception
    {
        public HangarOccupiedPlaceException(int i) : base("На месте " + i + " уже стоит истребитель")
        { }
    }
}
