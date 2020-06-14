using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorMegaDesk.Models
{
    public enum DesktopMaterial
    {
        Oak,
        Laminate,
        Pine,
        Rosewood,
        Veneer
    }
    public class DeskQuote
    {
        public int ID { get; set; }
        public int RushDays { get; set; }
        public string CustomerName { get; set; }
        [DataType(DataType.Date)]
        public DateTime QuoteDate { get; set; }
        public int DeskWidth { get; set; }
        public int DeskDepth { get; set; }
//        public DesktopMaterial DeskMaterial { get; set; }
        [EnumDataType(typeof(DesktopMaterial))]
        public DesktopMaterial DeskMaterial { get; set; }
        public int DeskDrawers { get; set; }

        private int DRAWER_PRICE = 50;
        private int BASE_PRICE = 200;
        private int PRICE_PER_INCH = 1;
        private int INCLUDED_INCHES = 1000;
        private int MIN_WIDTH { get; set; } = 24;
        private int MAX_WIDTH { get; set; } = 96;
        private int MIN_DEPTH { get; set; } = 12;
        private int MAX_DEPTH { get; set; } = 48;

        public int GetArea() {
            int area = this.DeskDepth * this.DeskWidth;
            return area;
        }

    }
}
