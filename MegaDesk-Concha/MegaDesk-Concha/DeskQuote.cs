using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Concha
{
    public class DeskQuote
    {
        // Se implementara un sistema simulando colecciones 
        // mas que in sistema basado en tablas. Ya que al parecer no trabajaremos 
        // con SQL
        // Fields
        //public string desk = "";
        public Desk desk = new Desk();
        public int rushDays = 0;
        public string customerName = "";
        public string quoteDate = "";

        public const int PRICE_PER_DRAWER = 50;
        private const int PRICE_BASE = 200;
        private const int SIZE_THRESHOLD = 1000; // Square Inches
        private const int PRICE_PER_AREA = 1; // cost per square inch over SIZE_THRESHOLD
        private const int RUSH_THRESHOLD = 2000;

        // Constructor
        public DeskQuote(Desk deskArg, int rushDaysArg, string customerNameArg)
        {
            // Asumimos la fecha actual siempre. No se recibe por medio de argumento
            DateTime date = DateTime.Now;

            desk = deskArg;
            rushDays = rushDaysArg;
            customerName = customerNameArg;
            quoteDate = date.ToString();
        }
        public int DrawerCost()
        {
            int DrawerCost = desk.nDrawers * PRICE_PER_DRAWER;
            return DrawerCost;
        }
        public int AreaCost()
        {
            // check if Area is bigger than SIZE_THRESHOLD
            if (desk.area() > SIZE_THRESHOLD)
            {
                return (desk.area() - SIZE_THRESHOLD) * PRICE_PER_AREA;
            }
            else
            {
                return 0;
            }
        }
        public int CalcQuote()
        {
            int QuoteTotal = PRICE_BASE + AreaCost() + DrawerCost() + (int)desk.surface + RushCost();
            return QuoteTotal;
        }

        private int RushCost()
        {
            int rushCost = 0;

            switch (rushDays)
            {
                case 3:
                    if (desk.area() < SIZE_THRESHOLD)
                    {
                        rushCost = 60;
                    }
                    if (desk.area() > SIZE_THRESHOLD && desk.area() < RUSH_THRESHOLD)
                    {
                        rushCost = 70;
                    }
                    if (desk.area() > RUSH_THRESHOLD)
                    {
                        rushCost = 80;
                    }
                    break;
                case 5:
                    if (desk.area() < SIZE_THRESHOLD)
                    {
                        rushCost = 40;
                    }
                    if (desk.area() > SIZE_THRESHOLD && desk.area() < RUSH_THRESHOLD)
                    {
                        rushCost = 50;
                    }
                    if (desk.area() > RUSH_THRESHOLD)
                    {
                        rushCost = 60;
                    }
                    break;
                case 7:
                    if (desk.area() < SIZE_THRESHOLD)
                    {
                        rushCost = 30;
                    }
                    if (desk.area() > SIZE_THRESHOLD && desk.area() < RUSH_THRESHOLD)
                    {
                        rushCost = 35;
                    }
                    if (desk.area() > RUSH_THRESHOLD)
                    {
                        rushCost = 40;
                    }
                    break;
            }
            return rushCost;
        }
    }
}
