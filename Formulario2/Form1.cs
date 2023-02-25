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
        double total = 0;
        double promedio = 0;
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

            //total = total + Convert.ToDouble(PreciotextBox.Text);
            //TotaltextBox.Text = Convert.ToString(total);

            Convert.ToString(PreciotextBox.Text);
            MostrarlistBox.Items.Add(" -- Producto: " + ProductotextBox.Text + " -- Cantidad: " + CantidadtextBox.Text + " -- Precio: "  + PreciotextBox.Text);

            total = total + (Convert.ToDouble(PreciotextBox.Text) * Convert.ToDouble(CantidadtextBox.Text));
            TotaltextBox.Text = Convert.ToString(total);
            promedio = (total * 0.15);
            PromediotextBox.Text = Convert.ToString(promedio);

            ProductotextBox.Text = "";
            ProductotextBox.Focus();
            PreciotextBox.Text = "";
            PreciotextBox.Focus();
            CantidadtextBox.Text = "";
            CantidadtextBox.Focus();

        }


    }
}
