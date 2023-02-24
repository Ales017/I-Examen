namespace DarwinSanchez
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button Calcularbutton;
            this.CalculoMeslabel = new System.Windows.Forms.Label();
            this.MostrarCalculolistBox = new System.Windows.Forms.ListBox();
            this.MescomboBox = new System.Windows.Forms.ComboBox();
            Calcularbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Calcularbutton
            // 
            Calcularbutton.Location = new System.Drawing.Point(254, 155);
            Calcularbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Calcularbutton.Name = "Calcularbutton";
            Calcularbutton.Size = new System.Drawing.Size(161, 55);
            Calcularbutton.TabIndex = 2;
            Calcularbutton.Text = "Calcular";
            Calcularbutton.UseVisualStyleBackColor = true;
            Calcularbutton.Click += new System.EventHandler(this.Calcularbutton_Click);
            // 
            // CalculoMeslabel
            // 
            this.CalculoMeslabel.AutoSize = true;
            this.CalculoMeslabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculoMeslabel.Location = new System.Drawing.Point(36, 64);
            this.CalculoMeslabel.Name = "CalculoMeslabel";
            this.CalculoMeslabel.Size = new System.Drawing.Size(271, 24);
            this.CalculoMeslabel.TabIndex = 0;
            this.CalculoMeslabel.Text = "Escoja un mes para hacer el calculo";
            // 
            // MostrarCalculolistBox
            // 
            this.MostrarCalculolistBox.FormattingEnabled = true;
            this.MostrarCalculolistBox.ItemHeight = 22;
            this.MostrarCalculolistBox.Location = new System.Drawing.Point(12, 297);
            this.MostrarCalculolistBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MostrarCalculolistBox.Name = "MostrarCalculolistBox";
            this.MostrarCalculolistBox.Size = new System.Drawing.Size(678, 92);
            this.MostrarCalculolistBox.TabIndex = 1;
            // 
            // MescomboBox
            // 
            this.MescomboBox.FormattingEnabled = true;
            this.MescomboBox.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.MescomboBox.Location = new System.Drawing.Point(353, 63);
            this.MescomboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MescomboBox.Name = "MescomboBox";
            this.MescomboBox.Size = new System.Drawing.Size(267, 30);
            this.MescomboBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 423);
            this.Controls.Add(this.MescomboBox);
            this.Controls.Add(Calcularbutton);
            this.Controls.Add(this.MostrarCalculolistBox);
            this.Controls.Add(this.CalculoMeslabel);
            this.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Formulario1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CalculoMeslabel;
        private System.Windows.Forms.ListBox MostrarCalculolistBox;
        private System.Windows.Forms.ComboBox MescomboBox;
    }
}

