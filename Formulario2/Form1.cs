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
            {
                // Obtenemos los productos y precios del usuario
                string[] productos = ProductotextBox.Text.Split(',');
                decimal[] precios = Array.ConvertAll(PreciotextBox.Text.Split(','), decimal.Parse);

                // Validamos que se hayan ingresado los mismos números de productos y precios
                if (productos.Length != precios.Length)
                {
                    MessageBox.Show("Debe ingresar la misma cantidad de productos y precios.");
                    return;
                }

                // Calculamos el total de la factura
                decimal total = 0;
                for (int i = 0; i < productos.Length; i++)
                {
                    total += precios[i];
                }

                // Calculamos el descuento asincrónicamente
                decimal descuento = await CalcularDescuento(total);

                // Mostramos los resultados al usuario
                decimal totalConDescuento = total - descuento;
                MessageBox.Show($"Descuento: ${descuento:0.00}");
                MessageBox.Show($"Total con descuento: ${totalConDescuento:0.00}");
            }

            async Task<decimal> CalcularDescuento(decimal total)
            {
                // Simulamos un retraso de 2 segundos para simular un cálculo asincrónico
                await Task.Delay(2000);

                // Calculamos el descuento del 15% y lo devolvemos
                decimal descuento = total * 0.15m;
                return descuento;
            }
        }
        
    }
}
