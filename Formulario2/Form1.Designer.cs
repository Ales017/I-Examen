namespace Formulario2
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
            this.components = new System.ComponentModel.Container();
            this.Productolabel = new System.Windows.Forms.Label();
            this.ProductotextBox = new System.Windows.Forms.TextBox();
            this.Preciolabel = new System.Windows.Forms.Label();
            this.PreciotextBox = new System.Windows.Forms.TextBox();
            this.MostrarlistBox = new System.Windows.Forms.ListBox();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.Calcularbutton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Productolabel
            // 
            this.Productolabel.AutoSize = true;
            this.Productolabel.Location = new System.Drawing.Point(132, 62);
            this.Productolabel.Name = "Productolabel";
            this.Productolabel.Size = new System.Drawing.Size(76, 20);
            this.Productolabel.TabIndex = 0;
            this.Productolabel.Text = "Producto";
            // 
            // ProductotextBox
            // 
            this.ProductotextBox.Location = new System.Drawing.Point(238, 59);
            this.ProductotextBox.Name = "ProductotextBox";
            this.ProductotextBox.Size = new System.Drawing.Size(100, 22);
            this.ProductotextBox.TabIndex = 1;
            // 
            // Preciolabel
            // 
            this.Preciolabel.AutoSize = true;
            this.Preciolabel.Location = new System.Drawing.Point(132, 121);
            this.Preciolabel.Name = "Preciolabel";
            this.Preciolabel.Size = new System.Drawing.Size(58, 20);
            this.Preciolabel.TabIndex = 2;
            this.Preciolabel.Text = "Precio";
            // 
            // PreciotextBox
            // 
            this.PreciotextBox.Location = new System.Drawing.Point(238, 118);
            this.PreciotextBox.Name = "PreciotextBox";
            this.PreciotextBox.Size = new System.Drawing.Size(100, 22);
            this.PreciotextBox.TabIndex = 3;
            // 
            // MostrarlistBox
            // 
            this.MostrarlistBox.FormattingEnabled = true;
            this.MostrarlistBox.ItemHeight = 16;
            this.MostrarlistBox.Location = new System.Drawing.Point(495, 40);
            this.MostrarlistBox.Name = "MostrarlistBox";
            this.MostrarlistBox.Size = new System.Drawing.Size(198, 244);
            this.MostrarlistBox.TabIndex = 4;
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Location = new System.Drawing.Point(110, 169);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(150, 66);
            this.Agregarbutton.TabIndex = 5;
            this.Agregarbutton.Text = "Agregar";
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // Calcularbutton
            // 
            this.Calcularbutton.Location = new System.Drawing.Point(306, 169);
            this.Calcularbutton.Name = "Calcularbutton";
            this.Calcularbutton.Size = new System.Drawing.Size(150, 66);
            this.Calcularbutton.TabIndex = 6;
            this.Calcularbutton.Text = "Calcular";
            this.Calcularbutton.UseVisualStyleBackColor = true;
            this.Calcularbutton.Click += new System.EventHandler(this.Calcularbutton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Calcularbutton);
            this.Controls.Add(this.Agregarbutton);
            this.Controls.Add(this.MostrarlistBox);
            this.Controls.Add(this.PreciotextBox);
            this.Controls.Add(this.Preciolabel);
            this.Controls.Add(this.ProductotextBox);
            this.Controls.Add(this.Productolabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Productolabel;
        private System.Windows.Forms.TextBox ProductotextBox;
        private System.Windows.Forms.Label Preciolabel;
        private System.Windows.Forms.TextBox PreciotextBox;
        private System.Windows.Forms.ListBox MostrarlistBox;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.Button Calcularbutton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

