using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_JoshuaNilsson
{
    class DeskQuote
    {
        public Desk Desk = new Desk();
        private int RushDays = 0;
        private int SurfaceArea = 0;

        // static const min max
        private int BASESIZE = 1000;
        private int SURFACECOST = 1; // price per extra square inch
        private int BASEPRICE = 200;


        public string CustName { get; set; }
        public DateTime QuoteDate { get; set; }

        public DeskQuote(int width, int depth, int numDrawers, string materialType, int rushDays)
        {
            Desk.Width = width;
            Desk.Depth = depth;
            Desk.NumDrawers = numDrawers;
            Desk.MaterialType = materialType;
            RushDays = rushDays;

            SurfaceArea = Desk.Width * Desk.Depth;
        }

        //public int CalculateTotalCost()
        //{
        //    //return BASEPRICE + SurfaceAreaCost() + DrawerCost() + RushOrderCost() + MaterialCost();
        //    // from design document - look at constructor to work with values
        //    // finish at latest wednesday
        //}

        public int SurfaceAreaCost()
        {
            if (SurfaceArea > BASESIZE)
                return (SurfaceArea - BASESIZE) * SURFACECOST;
            else
                return 0;
        }
    }
}
