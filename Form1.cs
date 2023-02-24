using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarwinSanchez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcularbutton_Click(object sender, EventArgs e)
        {
            decimal Capital = 200000;
            decimal TasaInteres = 0.15m;
            string mes = MescomboBox.Text;
            decimal interes;

            MostrarCalculolistBox.Items.Clear();

            if (mes == "Enero")
            {
                interes = Capital * TasaInteres * 1;
               MostrarCalculolistBox.Items.Add("Enero " + interes);
            }
            else if (mes == "Febrero")
            {
                interes = Capital * TasaInteres * 2;
                MostrarCalculolistBox.Items.Add("Febrero " + interes);
            }
            else if (mes == "Marzo")
            {
                interes = Capital * TasaInteres * 3;
                MostrarCalculolistBox.Items.Add("Marzo " + interes);
            }
            else if (mes == "Abril")
            {
                interes = Capital * TasaInteres * 4;
                MostrarCalculolistBox.Items.Add("Abril " + interes);
            }
            else if (mes == "Mayo")
            {
                interes = Capital * TasaInteres * 5;
                MostrarCalculolistBox.Items.Add("Mayo " + interes);
            }
            else if (mes == "Junio")
            {
                interes = Capital * TasaInteres * 6;
                MostrarCalculolistBox.Items.Add("Junio " + interes);
            }
            else if (mes == "Julio")
            {
                interes = Capital * TasaInteres * 7;
                MostrarCalculolistBox.Items.Add("Julio " + interes);
            }
            else if (mes == "Agosto")
            {
                interes = Capital * TasaInteres * 8;
                MostrarCalculolistBox.Items.Add("Agosto " + interes);
            }
            else if (mes == "Septiembre")
            {
                interes = Capital * TasaInteres * 9;
                MostrarCalculolistBox.Items.Add("Septiembre " + interes);
            }
            else if (mes == "Octubre")
            {
                interes = Capital * TasaInteres * 10;
                MostrarCalculolistBox.Items.Add("Ocubre " + interes);
            }
            else if (mes == "Noviembre")
            {
                interes = Capital * TasaInteres * 11;
                MostrarCalculolistBox.Items.Add("Noviembre " + interes);
            }
            else if (mes == "Diciembre")
            {
                interes = Capital * TasaInteres * 12;
                MostrarCalculolistBox.Items.Add("Diciembre " + interes);
            }
        }
    }
}
