using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Concha
{
    public partial class DisplayQuote : Form
    {
        public Form refBack { get; set; }
        //public DeskQuote dqDeskQuote { get; set; }

        //Override default Close Button. Instead go Back
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        public DisplayQuote(DeskQuote dqDeskQuote)
        {
            InitializeComponent();
            dqCustomerNameVal.Text = dqDeskQuote.customerName;
            dqDeskWidthVal.Text = dqDeskQuote.desk.width.ToString();
            dqDeskDepthVal.Text = dqDeskQuote.desk.depth.ToString();
            dqNDrawersVal.Text = dqDeskQuote.desk.nDrawers.ToString();
            dqSurfaceMatVal.Text = dqDeskQuote.desk.surface.ToString();
            dqBuildTimeVal.Text = dqDeskQuote.rushDays.ToString();
            dqQuoteTotalVal.Text = dqDeskQuote.CalcQuote().ToString();
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {

        }
    }
}
