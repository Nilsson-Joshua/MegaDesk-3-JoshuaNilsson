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
        private int RushDays { get; set; }
        private int SurfaceArea = 0;

        public string CustName { get; set; }
        public int DeskTotal { get; set; }

        // surface area and drawer constants
        private const int BASE_SIZE = 1000;
        private const int SURFACECOST = 1; // price per extra square inch
        private const int BASE_DESK_PRICE = 200;
        private const int DRAWER_PRICE = 50;

        // shipping constants
        private const int DAYS_3 = 3;
        private const int DAYS_5 = 5;
        private const int DAYS_7 = 7;

        public DeskQuote(int width, int depth, int numDrawers, string materialType, int rushDays)
        {
            Desk.Width = width;
            Desk.Depth = depth;
            Desk.NumDrawers = numDrawers;
            Desk.MaterialType = materialType;
            RushDays = rushDays;

            // calculate surface area from given width and depth in Desk
            SurfaceArea = Desk.Width * Desk.Depth;
        }

        public int SurfaceAreaCost()
        {
            // add additional cost to surface area if greater than 1000 (BASE_SIZE)
            if (SurfaceArea > BASE_SIZE)
                return (SurfaceArea - BASE_SIZE) * SURFACECOST;
            else
                return 0;
        }

        public int DrawerCost()
        {
            // we want the number of drawers before multiplying the constant price for total
            return DRAWER_PRICE * Desk.NumDrawers;
        }

        public int RushOrderCost()
        {
            // now i need to determine the cost for the customer's selected shipping days
            // review design document logic to help you out

            // initialize to zero
            int rushOrderTotal = 0;

            // 3-Day Shipping Conditions
            if (RushDays == DAYS_3 && SurfaceArea < 1000)
            {
                return rushOrderTotal = 60;
            }
            else if (RushDays == DAYS_3 && SurfaceArea >= 1000 && SurfaceArea <= 2000)
            {
                return rushOrderTotal = 70;
            }
            else if (RushDays == DAYS_3 && SurfaceArea > 2000)
            {
                return rushOrderTotal = 80;
            }

            // 5-Day Shipping Conditions
            else if (RushDays == DAYS_5 && SurfaceArea < 1000)
            {
                return rushOrderTotal = 40;
            }
            else if (RushDays == DAYS_5 && SurfaceArea >= 1000 && SurfaceArea <= 2000)
            {
                return rushOrderTotal = 50;
            }
            else if (RushDays == DAYS_5 && SurfaceArea > 2000)
            {
                return rushOrderTotal = 60;
            }

            // 7-Day Shipping Conditions
            else if (RushDays == DAYS_7 && SurfaceArea < 1000)
            {
                return rushOrderTotal = 30;
            }
            else if (RushDays == DAYS_7 && SurfaceArea >= 1000 && SurfaceArea <= 2000)
            {
                return rushOrderTotal = 35;
            }
            else if (RushDays == DAYS_7 && SurfaceArea > 2000)
            {
                return rushOrderTotal = 40;
            }

            // If not 3, 5, or 7 Day-Shipping, no additional cost (initialized above to zero)
            else
            {
                return rushOrderTotal;
            }
        }

        public int MaterialCost()
        {
            // after reviewing discussion board, I have decided against using the if-ifelse-else conditions
            // within my design document to determine material cost.
            // the suggested switch statement seems better in this "case"

            int materialTotal = 0;

            // determines cost of selected desk material
            switch (Desk.MaterialType)
            {
                case "pine":
                    materialTotal = 50;
                    break;
                case "laminate":
                    materialTotal = 100;
                    break;
                case "veneer":
                    materialTotal = 125;
                    break;
                case "oak":
                    materialTotal = 200;
                    break;
                case "rosewood":
                    materialTotal = 300;
                    break;

                // default needed if dropdown menu items fixed in selection?
            }

            return materialTotal;
        }

        public int CalculateTotalCost()
        {
            // look at design document to hook things up.
            return BASE_DESK_PRICE + SurfaceAreaCost() + DrawerCost() + RushOrderCost() + MaterialCost();

        }
    }
}
