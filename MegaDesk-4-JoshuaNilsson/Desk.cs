using System;

namespace MegaDesk_3_JoshuaNilsson
{
    class Desk
    {
        public int Width { get; set; }
        public int Depth { get; set; }
        public int NumDrawers { get; set; }
        public string MaterialType { get; set; }

        // constants
        public const int MINWIDTH = 24;
        public const int MIDWIDTH = 25;
        public const int MAXWIDTH = 96;
        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;
    }
}
