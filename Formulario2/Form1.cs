using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        double Total = 0;
        double promedio = 0;
        double SumaTotal = 0;
        double PromedioTotal = 0;

        public void Agregarbutton_Click(object sender, EventArgs e)
        {

            if (ProductotextBox.Text == "")
            {
                errorProvider1.SetError(ProductotextBox, "Favor Ingrese el Producto");
                return;
            }
            if (PreciotextBox.Text == "")
            {
                errorProvider1.SetError(CantidadtextBox, "Favor Ingrese el Precio");
                return;
            }
            if (CantidadtextBox.Text == "")
            {
                errorProvider1.SetError(CantidadtextBox, "Favor Ingrese la cantidad");
                return;
            }

            Total = Total + Convert.ToDouble(PreciotextBox.Text) * Convert.ToDouble(CantidadtextBox.Text);

            Convert.ToString(PreciotextBox.Text);
            MostrarlistBox.Items.Add(" -- Producto: " + ProductotextBox.Text + " -- Cantidad: " + CantidadtextBox.Text + " -- Precio: " + PreciotextBox.Text);
            MostrarlistBox.Items.Add(" -- SubTotal: " + Total);
          

            SumaTotal = suma(Total, promedio);
            PromediotextBox.Text = Convert.ToString(SumaTotal);
            

            ProductotextBox.Text = "";
            ProductotextBox.Focus();
            PreciotextBox.Text = "";
            PreciotextBox.Focus();
            CantidadtextBox.Text = "";
            CantidadtextBox.Focus();

        }

        public double suma(double total, double promedio)
        {
            promedio = total * 0.15;
            return promedio;

        }
    }
}
