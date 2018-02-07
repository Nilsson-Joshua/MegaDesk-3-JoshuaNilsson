using System;

namespace MegaDesk_4_JoshuaNilsson
{
    class Desk
    {
        public int Width { get; set; }
        public int Depth { get; set; }
        public int NumDrawers { get; set; }
        public string MaterialType { get; set; }

        // width and depth constants
        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;
        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;
    }

    public enum MaterialTypes
    {
        Pine = 50,
        Laminate = 100,
        Veneer = 125,
        Oak = 200,
        Rosewood = 300
    }
}
