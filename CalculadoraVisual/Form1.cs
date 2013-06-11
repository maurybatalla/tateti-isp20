using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculadoraVisual
{
    public partial class FrmCalculadora : Form
    {
        private Calculadora micalcu; //es una propiedad que se llama calcu y es del tipo Calculadora
        public FrmCalculadora()
        {
            InitializeComponent();
            micalcu = new Calculadora();//inicializo a calcu , osea creo un objeto llamado calcu
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumero1_Leave(object sender, EventArgs e)
        {
            micalcu.IngresarValor(Convert.ToSingle(txtNumero1.Text), Convert.ToSingle(txtNumero2.Text));
        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNumero2_Leave(object sender, EventArgs e)
        {
            micalcu.IngresarValor(Convert.ToSingle(txtNumero1.Text), Convert.ToSingle(txtNumero2.Text));
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            txtResultado.Text=Convert.ToString(micalcu.MostrarResultado("+"));
            
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Convert.ToString(micalcu.MostrarResultado("-"));
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Convert.ToString(micalcu.MostrarResultado("*"));
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Convert.ToString(micalcu.MostrarResultado("/"));
        }
    }
}
