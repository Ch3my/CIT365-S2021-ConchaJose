using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Concha
{
    public partial class AddQuote : Form
    {
        public Form refBack { get; set; }
        //Override default Close Button. Instead go Back
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // El formulario ya se esta cerrando por lo que no necesitamos
            // Llamar this.Close();
            this.refBack.Show();
        }
        public AddQuote()
        {
            InitializeComponent();
            // Ingresar datos a los Combobox
            List<DeskMaterial> deskMaterialsList = Enum.GetValues(typeof(DeskMaterial)).Cast<DeskMaterial>().ToList();
            surfaceCombobox.DataSource = deskMaterialsList;
            List<int> nDrawersList = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7 };
            nDrawersCombobox.DataSource = nDrawersList;
            List<int> buildTimeList = new List<int> { 14, 5, 7, 3 };
            buildTimeCombobox.DataSource = buildTimeList;
        }

        private void addQuoteBackButton_Click(object sender, EventArgs e)
        {
            // Cerramos este form y mostramos la refBack que nos entregaron
            // en este caso MainForm
            this.Close();
            this.refBack.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string consumerFullname = consumerFullNameTextbox.Text;
            int deskWidth = 0;
            int deskWidthValue = 0;

            if (int.TryParse(deskWidthTextbox.Text, out deskWidthValue))
            {
                deskWidth = deskWidthValue;
            }
            else
            {
                return;
            }

            int deskDepth = 0;
            int deskDepthValue = 0;
            if (int.TryParse(deskDepthTextbox.Text, out deskDepthValue))
            {
                deskDepth = deskDepthValue;
            }
            else
            {
                return;
            }

            int nDrawers = int.Parse(nDrawersCombobox.Text);
            string desktopSurface = surfaceCombobox.Text;
            int rushTime = int.Parse(buildTimeCombobox.Text);

            // ===== DEBUG =====
            string message = String.Format("Consumer Name: {0}\ndeskWidth: {1}\ndeskDepth: {2}\n" +
                "Drawers: {3}\nsurface: {4}\nrush: {5}", consumerFullname, deskWidth, deskDepth,
                nDrawers, desktopSurface, rushTime);
            MessageBox.Show(message, "Debug");

            // Creamos objectos segun los parametros entregados
            Desk desk = new Desk(deskWidth, deskDepth, nDrawers, desktopSurface);
            DeskQuote deskQuote = new DeskQuote(desk, rushTime, consumerFullname);


            // Obtenemos el directorio donde se esta ejecutando el exe
            //Console.WriteLine(System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location));

            // Leer archivo
            // Verificar si tiene datos
            // Si tiene datos añadir este objeto al final
            // guardar y cerrar archivo

            // TODO. how to get the Serializer to get them when they are "private".
            // Se añade el json resultante del objecto 1 por linea
            string jsonWrite = JsonConvert.SerializeObject(deskQuote);
            string jsonFile = @"quotes.json";

            try
            {
                if (!File.Exists(jsonFile))
                {
                    using (StreamWriter sw = File.CreateText(jsonFile)) { }
                }
                using (StreamWriter swa = File.AppendText(jsonFile)) { swa.WriteLine(jsonWrite); }

            }
            catch (IOException err)
            {
                // Extract some information from this exception, and then
                // throw it to the parent method.
                if (err.Source != null)
                    Console.WriteLine("IOException source: {0}", err.Source);
                throw;
            }

            // Display Quote Data
            DisplayQuote displayQuoteScreen = new DisplayQuote(deskQuote);
            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (displayQuoteScreen.ShowDialog(this) == DialogResult.OK)
            {
                // Presionene Okay o X en la ventana genera un
                // DialogResult.OK
                // Cerramos esta ventana y vamos al Menu Principal
                this.Close();
                this.refBack.Show();
            }
        }

        private void addQuoteDeskWidthValidating(object sender, CancelEventArgs e)
        {
            int value;
            if (int.TryParse(deskWidthTextbox.Text, out value))
            {
                // Ingresaron numeros
                if (value >= Desk.MIN_WIDTH && value <= Desk.MAX_WIDTH)
                {
                    // Es un numero valido
                    errorProviderDeskWidth.Clear();
                }
                else
                {
                    // El Valor no corresponde a los parametros aceptados
                    // Retornamos Error
                    errorProviderDeskWidth.SetError(deskWidthTextbox,
                        "The value needs to be between 24 and 96 inches");
                }
            }
            else
            {
                // No ingresaron numeros
                errorProviderDeskWidth.SetError(deskWidthTextbox,
                    "Please enter only numebers");
            }
        }

        private void addQuoteDeskDeptValidating(object sender, CancelEventArgs e)
        {
            int value;
            if (int.TryParse(deskDepthTextbox.Text, out value))
            {
                if (value >= Desk.MIN_DEPTH && value <= Desk.MAX_DEPTH)
                {
                    // Es un numero valido
                    errorProviderDeskDepth.Clear();
                }
                else
                {
                    // El Valor no corresponde a los parametros aceptados
                    // Retornamos Error
                    errorProviderDeskDepth.SetError(deskDepthTextbox,
                        "The value needs to be between 12 and 48 inches");
                }
            }
            else
            {
                errorProviderDeskDepth.SetError(deskDepthTextbox,
                    "Please enter only numbers");
            }
        }

        private void addQuoteDeskDepthKeyPressValidating(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Ingresaron un numero y no tocaron la tecla enter, que seria una tecla de control
                // Es una entrada valida
                errorProviderDeskDepth.Clear();
            }
            else if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // INgresaron algo que no es numero y no es tecla de control
                // Posiblemente un string o algo erroneo, Arrojamos Error
                errorProviderDeskDepth.SetError(deskDepthTextbox,
                    "Please enter only numbers");

            }
        }

        private void surfaceCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
