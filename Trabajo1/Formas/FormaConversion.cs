using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo1.Formas
{
    public partial class FormaConversion : Form
    {
        const double TipoCambioDolar = 0.05;
        const double TipoCambioEuro = 0.04;
        public FormaConversion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double pesos))
            {
                if (pesos >= 0)
                {
                    double dolares = pesos * TipoCambioDolar / 2;
                    double euros = pesos * TipoCambioEuro / 2 ;

                    textBox2.Text = $"Dólares: {dolares}";
                    textBox3.Text = $"Euros: {euros}";
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese una cantidad válida de pesos mexicanos.");
                }
            }
            else
            {
                    MessageBox.Show("Por favor, ingrese una cantidad válida de pesos mexicanos.");
            }
        }
    }
}