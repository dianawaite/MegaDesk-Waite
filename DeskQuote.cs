using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Waite
{
    internal class DeskQuote
    {
        #region Object member variables
        private string CustomerName;
        private DateTime QuoteDate;
        private Desk newDesk = new Desk();
        private int RushDays;
        private int QuoteAmount;
        #endregion

        #region local variables
        private int DrawerCost;
        private int RushCost;
        private int MaterialCost;
        private int SurfaceArea;
        private int SizeCost;
        #endregion

        private const int BASE_PRICE = 200;
        private const int SIZE_TRESHHOLD = 1000;
        private const int PRICE_PER_DRAWER = 50;

        private int CalcMaterialCost(string material)
        {
            newDesk.DeskMaterial = material;

            switch (newDesk.DeskMaterial)
            {
                case "Oak":
                    MaterialCost = 200;
                    break;

                case "Laminate":
                    MaterialCost = 100;
                    break;

                case "Pine":
                    MaterialCost = 50;
                    break;

                case "Rosewood":
                    MaterialCost = 300;
                    break;

                case "Veneer":
                    MaterialCost = 125;
                    break;
            }
            return MaterialCost;
        }

        private int CalcSurfaceArea(int width, int depth)
        {
            newDesk.Width = width;
            newDesk.Depth = depth;
            SurfaceArea = newDesk.Width * newDesk.Depth;
            return SurfaceArea;
        }


        private int CalcRushORderCost(int RushDays, int SurfaceArea)
        {
            if (SurfaceArea < 1000)
            {
                switch (RushDays)
                {
                    case 3:
                        RushCost = 60;
                        break;
                    case 5:
                        RushCost = 40;
                        break;
                    case 7:
                        RushCost = 30;
                        break;
                }
            }
            else if (SurfaceArea < 2000)
            {
                switch (RushDays)
                {
                    case 3:
                        RushCost = 70;
                        break;
                    case 5:
                        RushCost = 50;
                        break;
                    case 7:
                        RushCost = 35;
                        break;
                }
            }
            else if (SurfaceArea > 2000)
            {
                switch (RushDays)
                {
                    case 3:
                        RushCost = 80;
                        break;
                    case 5:
                        RushCost = 60;
                        break;
                    case 7:
                        RushCost = 40;
                        break;
                }
            }
            return RushCost;
        }

        private int calSurfaceAreaCost(int SurfaceArea)
        {
            if (SurfaceArea <= 1000)
            {
                SizeCost = SIZE_TRESHHOLD;
            }
            else
            {
                SizeCost = SIZE_TRESHHOLD + (SurfaceArea - SIZE_TRESHHOLD);
            }

            return SizeCost;
        }

        public DeskQuote()
        {

            DrawerCost = newDesk.NumberOfDrawers * PRICE_PER_DRAWER;

            QuoteAmount = BASE_PRICE + SizeCost + DrawerCost + MaterialCost + RushCost;

        }






    }
}

