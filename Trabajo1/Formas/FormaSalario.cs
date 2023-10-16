using System;
using System.Windows.Forms;

namespace Trabajo1.Formas
{
    public partial class FormaSalario : Form
    {
        public FormaSalario()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            try
            {
                decimal number = decimal.Parse(textBox1.Text);

                if (number < 0)
                {
                    MessageBox.Show("Error: El número no puede ser negativo.");
                    return;
                }

                decimal result = number + (number * 0.25m);
                textBox2.Text = $"{result}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Error: El valor ingresado no es válido.");
            }
        }
    }
}

