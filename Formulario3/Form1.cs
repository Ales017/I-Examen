using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            List<string> multiplos = new List<string>();

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    multiplos.Add("Darwin Sanchez");
                }
                else if (i % 3 == 0)
                {
                    multiplos.Add("Darwin");
                }
                else if (i % 5 == 0)
                {
                    multiplos.Add("Sanchez");
                }
                else
                {
                    multiplos.Add(i.ToString());
                }
            }

            MultiploslistBox.DataSource = multiplos;
        }
    }
}
