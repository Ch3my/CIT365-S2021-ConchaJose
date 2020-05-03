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
    public partial class MegaDesk : Form
    {
        public MegaDesk()
        {
            InitializeComponent();
        }

        private void addQuoteButton_Click(object sender, EventArgs e)
        {
            // Creamos una nueva instacia del formulario destino
            // y pasamos la referencia al mainForm como
            // Formulario para que vuelva
            AddQuote addQuoteWindow = new AddQuote();
            addQuoteWindow.refBack = this;
            addQuoteWindow.Show();
            this.Hide();
        }

        private void viewQuotesButton_Click(object sender, EventArgs e)
        {
            // Creamos una nueva instacia del formulario destino
            // y pasamos la referencia al mainForm como
            // Formulario para que vuelva
            ViewAllQuotes viewQuotesWindow = new ViewAllQuotes();
            viewQuotesWindow.refBack = this;
            viewQuotesWindow.Show();
            this.Hide();
        }

        private void searchQuotesButton_Click(object sender, EventArgs e)
        {
            // Creamos una nueva instacia del formulario destino
            // y pasamos la referencia al mainForm como
            // Formulario para que vuelva
            SearchQuotes searchQuotesWindow = new SearchQuotes();
            searchQuotesWindow.refBack = this;
            searchQuotesWindow.Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
