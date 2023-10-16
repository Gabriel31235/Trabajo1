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
    public partial class FormaFormula : Form
    {
        public FormaFormula()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, discriminante, x1, x2;
            bool esNumero;

            esNumero = double.TryParse(textBox1.Text, out a);
            if (!esNumero)
            {
                MessageBox.Show("Por favor ingrese un número válido para a.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            esNumero = double.TryParse(textBox2.Text, out b);
            if (!esNumero)
            {
                MessageBox.Show("Por favor ingrese un número válido para b.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            esNumero = double.TryParse(textBox3.Text, out c);
            if (!esNumero)
            {
                MessageBox.Show("Por favor ingrese un número válido para c.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            discriminante = b * b - 4 * a * c;

            if (discriminante < 0)
            {
                MessageBox.Show("La ecuación no tiene raíces reales.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (discriminante == 0)
            {
                x1 = -b / (2 * a);
                MessageBox.Show("La ecuación tiene una raíz real: " + x1.ToString(), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
                MessageBox.Show("La ecuación tiene dos raíces reales: " + x1.ToString() + " y " + x2.ToString(), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

