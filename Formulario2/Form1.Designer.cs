﻿namespace Formulario2
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
            this.CantidadtextBox = new System.Windows.Forms.TextBox();
            this.MostrarlistBox = new System.Windows.Forms.ListBox();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.PromediotextBox = new System.Windows.Forms.TextBox();
            this.Promediolabel = new System.Windows.Forms.Label();
            this.PreciotextBox = new System.Windows.Forms.TextBox();
            this.Cantidadlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Productolabel
            // 
            this.Productolabel.AutoSize = true;
            this.Productolabel.Location = new System.Drawing.Point(132, 62);
            this.Productolabel.Name = "Productolabel";
            this.Productolabel.Size = new System.Drawing.Size(61, 16);
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
            this.Preciolabel.Location = new System.Drawing.Point(132, 181);
            this.Preciolabel.Name = "Preciolabel";
            this.Preciolabel.Size = new System.Drawing.Size(46, 16);
            this.Preciolabel.TabIndex = 2;
            this.Preciolabel.Text = "Precio";
            // 
            // CantidadtextBox
            // 
            this.CantidadtextBox.Location = new System.Drawing.Point(238, 115);
            this.CantidadtextBox.Name = "CantidadtextBox";
            this.CantidadtextBox.Size = new System.Drawing.Size(100, 22);
            this.CantidadtextBox.TabIndex = 3;
            // 
            // MostrarlistBox
            // 
            this.MostrarlistBox.FormattingEnabled = true;
            this.MostrarlistBox.ItemHeight = 16;
            this.MostrarlistBox.Location = new System.Drawing.Point(363, 59);
            this.MostrarlistBox.Name = "MostrarlistBox";
            this.MostrarlistBox.Size = new System.Drawing.Size(397, 356);
            this.MostrarlistBox.TabIndex = 4;
            
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Location = new System.Drawing.Point(207, 236);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(150, 66);
            this.Agregarbutton.TabIndex = 5;
            this.Agregarbutton.Text = "Agregar Y Calcular";
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PromediotextBox
            // 
            this.PromediotextBox.Location = new System.Drawing.Point(220, 336);
            this.PromediotextBox.Name = "PromediotextBox";
            this.PromediotextBox.Size = new System.Drawing.Size(118, 22);
            this.PromediotextBox.TabIndex = 7;
            // 
            // Promediolabel
            // 
            this.Promediolabel.AutoSize = true;
            this.Promediolabel.Location = new System.Drawing.Point(235, 376);
            this.Promediolabel.Name = "Promediolabel";
            this.Promediolabel.Size = new System.Drawing.Size(92, 16);
            this.Promediolabel.TabIndex = 9;
            this.Promediolabel.Text = "Total a Pagar ";
            // 
            // PreciotextBox
            // 
            this.PreciotextBox.Location = new System.Drawing.Point(238, 178);
            this.PreciotextBox.Name = "PreciotextBox";
            this.PreciotextBox.Size = new System.Drawing.Size(100, 22);
            this.PreciotextBox.TabIndex = 10;
            // 
            // Cantidadlabel
            // 
            this.Cantidadlabel.AutoSize = true;
            this.Cantidadlabel.Location = new System.Drawing.Point(132, 118);
            this.Cantidadlabel.Name = "Cantidadlabel";
            this.Cantidadlabel.Size = new System.Drawing.Size(61, 16);
            this.Cantidadlabel.TabIndex = 11;
            this.Cantidadlabel.Text = "Cantidad";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 450);
            this.Controls.Add(this.Cantidadlabel);
            this.Controls.Add(this.PreciotextBox);
            this.Controls.Add(this.Promediolabel);
            this.Controls.Add(this.PromediotextBox);
            this.Controls.Add(this.Agregarbutton);
            this.Controls.Add(this.MostrarlistBox);
            this.Controls.Add(this.CantidadtextBox);
            this.Controls.Add(this.Preciolabel);
            this.Controls.Add(this.ProductotextBox);
            this.Controls.Add(this.Productolabel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.TextBox CantidadtextBox;
        private System.Windows.Forms.ListBox MostrarlistBox;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label Promediolabel;
        private System.Windows.Forms.TextBox PromediotextBox;
        private System.Windows.Forms.Label Cantidadlabel;
        private System.Windows.Forms.TextBox PreciotextBox;
    }
}

