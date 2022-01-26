using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class grpResultado : Form
    {
        public grpResultado()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            int valor1 = 0;
            int valor2 = 0;
            int resultado = 0;

            valor1 = Convert.ToInt16(txtDigitePrimeiroValor.Text);
            valor2 = Convert.ToInt16(txtDigiteSegundoValor.Text);

            if(valor2 != 0)
            {
                resultado = valor1 / valor2;
                txtResultado.Text = Convert.ToString(resultado);
                MessageBox.Show("O valor da divisão é: " + resultado.ToString());
            }
            else
            {
                MessageBox.Show("Não é possível efetuar a divisão por zero (0)");
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            int valor1 = 0;
            int valor2 = 0;
            int resultado = 0;

            valor1 = Convert.ToInt16(txtDigitePrimeiroValor.Text);
            valor2 = Convert.ToInt16(txtDigiteSegundoValor.Text);

            resultado = valor1 + valor2;
            lblResultado.Visible = true;
            txtResultado.Visible = true;

            txtResultado.Text = Convert.ToString(resultado);
            MessageBox.Show("O valor da divisão é: " + resultado.ToString());
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int valor1 = 0;
            int valor2 = 0;
            int resultado = 0;

            valor1 = Convert.ToInt16(txtDigitePrimeiroValor.Text);
            valor2 = Convert.ToInt16(txtDigiteSegundoValor.Text);

            resultado = valor1 * valor2;

            txtResultado.Text = Convert.ToString(resultado);
            MessageBox.Show("O valor da divisão é: " + resultado.ToString());
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            int valor1 = 0;
            int valor2 = 0;
            int resultado = 0;

            valor1 = Convert.ToInt16(txtDigitePrimeiroValor.Text);
            valor2 = Convert.ToInt16(txtDigiteSegundoValor.Text);

            resultado = valor1 - valor2;

            txtResultado.Text = Convert.ToString(resultado);
            MessageBox.Show("O valor da divisão é: " + resultado.ToString());
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Close();

            var result = MessageBox.Show("Deseja realmente fechar essa aplicação", "Atenção",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result != DialogResult.No)
            {
                Close();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDigitePrimeiroValor.Text = string.Empty;
            txtDigiteSegundoValor.Text = string.Empty;
            txtResultado.Text = string.Empty;
            txtDigitePrimeiroValor.Focus();
        }

        private void lblLimpar_Click(object sender, EventArgs e)
        {
            txtDigitePrimeiroValor.Text = string.Empty;
            txtDigiteSegundoValor.Text = string.Empty;
            txtResultado.Text = string.Empty;
            txtDigitePrimeiroValor.Focus();
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpResultado_Load(object sender, EventArgs e)
        {

        }
    }
}
