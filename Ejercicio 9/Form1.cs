using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_9
{
    public partial class Form1: Form
    {
        double precioArticulo, dineroPago, cambio;

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtCambio.Clear();
            txtDineroPago.Clear();
            txtPrecioArticulo.Clear();
        }

        public Form1()
        {
            InitializeComponent();
        }
        private void btnConvertir_Click(object sender, EventArgs e)
        {


            if (double.TryParse(txtPrecioArticulo.Text, out precioArticulo) && double.TryParse(txtDineroPago.Text, out dineroPago))
            {

                if (dineroPago >= precioArticulo)
                {
                    cambio = dineroPago - precioArticulo;
                    txtCambio.Text = cambio.ToString("N2");
                }
                else
                {
                    txtCambio.Text = "Dinero insuficiente";
                }
            }
            else
            {
                txtCambio.Text = "Entrada inválida";
            }
        }

    }
}
