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

        public void Agregarbutton_Click(object sender, EventArgs e)
        {

            if (ProductotextBox.Text == "")
            {
                errorProvider1.SetError(ProductotextBox, "Favor Ingrese el Producto");
                return;
            }
            if (PreciotextBox.Text == "")
            {
                errorProvider1.SetError(PreciotextBox, "Favor Ingrese el Precio");
                return;
            }

            //Convert.ToString(PreciotextBox.Text);
            MostrarlistBox.Items.Add(ProductotextBox.Text + " " + PreciotextBox.Text);

            ProductotextBox.Text = "";
            ProductotextBox.Focus();
            PreciotextBox.Text = "";
            PreciotextBox.Focus();

        }

        double suma;

        private async void Calcularbutton_Click(object sender, EventArgs e)
        {

        }
        
    }
}
