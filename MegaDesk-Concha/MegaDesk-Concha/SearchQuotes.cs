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
    public partial class SearchQuotes : Form
    {
        public Form refBack { get; set; }
        //Override default Close Button. Instead go Back
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            this.refBack.Show();
        }

        public SearchQuotes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.refBack.Show();
        }
    }
}
