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
    public partial class ViewAllQuotes : Form
    {
        public Form refBack { get; set; }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // El formulario ya se esta cerrando por lo que no necesitamos
            // Llamar this.Close();
            this.refBack.Show();
        }

        public ViewAllQuotes()
        {
            InitializeComponent();
        }

        private void viewAllQuotesBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.refBack.Show();
        }
    }
}
