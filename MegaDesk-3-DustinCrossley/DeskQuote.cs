using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_DustinCrossley
{
    class DeskQuote
    {
        private Desk Desk = new Desk();
        public string CustomerName { get; set; }
        public RushDays RushOrderDays { get; set; }
        private decimal _QuoteAmount { get; set; }
        public DateTime _QuoteDate { get; set; }

        private const decimal BASE_PRICE = 200;
        private const decimal PER_DRAWER_PRICE = 50;
        //private const decimal 

        public decimal QuoteAmount {get { return _QuoteAmount; }}
        public DateTime QuoteDate {get { return _QuoteDate; }}

        public enum RushDays
        {
            None = 0,
            Three = 3,
            Five = 5,
            Seven = 7         
        }

        public enum DrawerCount
        {
            One = 1,
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7
        }

        public void CalculateDeskQuote()
        {
            // Updates the QuoteAmount and QuoteDate
            _QuoteAmount = BASE_PRICE + LargeDeskPrice() + DrawerPrice() + SurfacePrice() + RushOrderPrice();
            _QuoteDate = DateTime.Now;
        }

        private decimal DrawerPrice()
        {
            // Returns cost of all drawers
            return PER_DRAWER_PRICE * Desk.DrawerCount;
        }

        private decimal LargeDeskPrice()
        {
            // Returns cost of large desks > 1000 sq in.
            if (Desk.Area > 1000)
                return Desk.Area - 1000;
            else
                return 0;
        }

        private decimal RushOrderPrice()
        {
            // Returns cost of rush order.
            if (Desk.Area < 1000)
            {
                switch (RushOrderDays)
                {
                    case RushDays.Three:
                        return 60;
                    case RushDays.Five:
                        return 40;
                    case RushDays.Seven:
                        return 30;
                    default:
                        return 99999;
                }
            }
            else if (Desk.Area >= 1000 && Desk.Area <= 2000)
            {
                switch (RushOrderDays)
                {
                    case RushDays.Three:
                        return 70;
                    case RushDays.Five:
                        return 50;
                    case RushDays.Seven:
                        return 35;
                    default:
                        return 99999;
                }
            }
            else
            {
                switch (RushOrderDays)
                {
                    case RushDays.Three:
                        return 80;
                    case RushDays.Five:
                        return 60;
                    case RushDays.Seven:
                        return 40;
                    default:
                        return 99999;
                }
            }
        }

        private decimal SurfacePrice()
        {
            // Returns cost of surface material
            switch (Desk.Surface)
            {
                case Desk.SurfaceType.Laminate:
                    return 100;
                case Desk.SurfaceType.Oak:
                    return 200;
                case Desk.SurfaceType.Pine:
                    return 50;
                case Desk.SurfaceType.Rosewood:
                    return 300;
                case Desk.SurfaceType.Veneer:
                    return 125;
                default:
                    return 99999;
            }
        }
    }
}
