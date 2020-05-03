using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Concha
{
    public enum DeskMaterial
    {
        Laminate = 100,
        Oak = 200,
        Rosewood = 300,
        Veneer = 125,
        Pine = 50
    }

    public class Desk
    {
        public double width;
        public double depth;
        public int nDrawers;
        public DeskMaterial surface;

        public const int MIN_WIDTH = 24;
        public const int MAX_WIDTH = 96;
        public const int MIN_DEPTH = 12;
        public const int MAX_DEPTH = 48;

        // Constructor
        public Desk()
        {

        }
        public Desk( double widthArg, double depthArg, int nDrawersArg, string surfaceArg)
        {
            width = widthArg;
            depth = depthArg;
            nDrawers = nDrawersArg;
            surface = (DeskMaterial)Enum.Parse(typeof(DeskMaterial), surfaceArg);
        }

        public int area()
        {
            int area = int.Parse((this.depth * this.width).ToString());
            return area;
        }
    }
}
