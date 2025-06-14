namespace Ejercicio_9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblIngresarPrecio = new System.Windows.Forms.Label();
            this.lblDineroCliente = new System.Windows.Forms.Label();
            this.txtPrecioArticulo = new System.Windows.Forms.TextBox();
            this.txtDineroPago = new System.Windows.Forms.TextBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grbConversion = new System.Windows.Forms.GroupBox();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.lblSon = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.grbConversion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIngresarPrecio
            // 
            this.lblIngresarPrecio.AutoSize = true;
            this.lblIngresarPrecio.Location = new System.Drawing.Point(73, 70);
            this.lblIngresarPrecio.Name = "lblIngresarPrecio";
            this.lblIngresarPrecio.Size = new System.Drawing.Size(141, 13);
            this.lblIngresarPrecio.TabIndex = 0;
            this.lblIngresarPrecio.Text = "Ingrese el Precio del Articulo";
            // 
            // lblDineroCliente
            // 
            this.lblDineroCliente.AutoSize = true;
            this.lblDineroCliente.Location = new System.Drawing.Point(73, 164);
            this.lblDineroCliente.Name = "lblDineroCliente";
            this.lblDineroCliente.Size = new System.Drawing.Size(151, 13);
            this.lblDineroCliente.TabIndex = 1;
            this.lblDineroCliente.Text = "Ingrese el Dinero de la compra";
            // 
            // txtPrecioArticulo
            // 
            this.txtPrecioArticulo.BackColor = System.Drawing.Color.Thistle;
            this.txtPrecioArticulo.Location = new System.Drawing.Point(76, 90);
            this.txtPrecioArticulo.Name = "txtPrecioArticulo";
            this.txtPrecioArticulo.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioArticulo.TabIndex = 2;
            // 
            // txtDineroPago
            // 
            this.txtDineroPago.BackColor = System.Drawing.Color.Thistle;
            this.txtDineroPago.Location = new System.Drawing.Point(76, 190);
            this.txtDineroPago.Name = "txtDineroPago";
            this.txtDineroPago.Size = new System.Drawing.Size(100, 20);
            this.txtDineroPago.TabIndex = 3;
            // 
            // btnConvertir
            // 
            this.btnConvertir.BackColor = System.Drawing.Color.SkyBlue;
            this.btnConvertir.Image = ((System.Drawing.Image)(resources.GetObject("btnConvertir.Image")));
            this.btnConvertir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConvertir.Location = new System.Drawing.Point(593, 47);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(109, 76);
            this.btnConvertir.TabIndex = 15;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConvertir.UseVisualStyleBackColor = false;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(593, 295);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(109, 76);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // grbConversion
            // 
            this.grbConversion.Controls.Add(this.txtCambio);
            this.grbConversion.Controls.Add(this.lblSon);
            this.grbConversion.Location = new System.Drawing.Point(50, 281);
            this.grbConversion.Name = "grbConversion";
            this.grbConversion.Size = new System.Drawing.Size(512, 100);
            this.grbConversion.TabIndex = 17;
            this.grbConversion.TabStop = false;
            this.grbConversion.Text = "Resultado";
            // 
            // txtCambio
            // 
            this.txtCambio.BackColor = System.Drawing.Color.Thistle;
            this.txtCambio.Location = new System.Drawing.Point(105, 46);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.ReadOnly = true;
            this.txtCambio.Size = new System.Drawing.Size(100, 20);
            this.txtCambio.TabIndex = 9;
            // 
            // lblSon
            // 
            this.lblSon.AutoSize = true;
            this.lblSon.Location = new System.Drawing.Point(23, 49);
            this.lblSon.Name = "lblSon";
            this.lblSon.Size = new System.Drawing.Size(32, 13);
            this.lblSon.TabIndex = 1;
            this.lblSon.Text = "Son :";
            this.lblSon.Click += new System.EventHandler(this.lblSon_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrar.Image")));
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBorrar.Location = new System.Drawing.Point(593, 164);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(109, 76);
            this.btnBorrar.TabIndex = 18;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.grbConversion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.txtDineroPago);
            this.Controls.Add(this.txtPrecioArticulo);
            this.Controls.Add(this.lblDineroCliente);
            this.Controls.Add(this.lblIngresarPrecio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculador de Cambio";
            this.grbConversion.ResumeLayout(false);
            this.grbConversion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngresarPrecio;
        private System.Windows.Forms.Label lblDineroCliente;
        private System.Windows.Forms.TextBox txtPrecioArticulo;
        private System.Windows.Forms.TextBox txtDineroPago;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox grbConversion;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.Label lblSon;
        private System.Windows.Forms.Button btnBorrar;
    }
}

