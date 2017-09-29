using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_DustinCrossley
{
    class Desk
    {
        public int Width { get; set; }
        public int Depth { get; set; }
        public int DrawerCount { get; set; }
        public SurfaceType Surface { get; set; }

        public enum SurfaceType{
            Laminate,
            Oak,
            Rosewood,
            Veneer,
            Pine
        }

        public int Area
        {
            get { return Width * Depth; }
        }
    }
}
