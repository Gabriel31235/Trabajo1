using System;
using System.Windows.Forms;

namespace Trabajo1.Formas
{
    public partial class FormaTraingulo : Form
    {
        public FormaTraingulo()
        {
            InitializeComponent();
        }

        private void FormaTraingulo_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            { 
                if
                (!double.TryParse(textBox1.Text, out double Base) || !double.TryParse(textBox2.Text, out double Altura))
                {
                    MessageBox.Show("Por favor, ingrese valores numéricos válidos.");
                    return;
                }

                double Area = 0.5 * Base * Altura;
                if (Base < 0)
                {
                    MessageBox.Show("Dato no valido");
                }
                else
                {
                    if (Altura < 0)
                    {
                        MessageBox.Show("Dato no valido");
                    }
                    else
                    {
                        textBox3.Text = Area.ToString();
                    }
                }
            }



            catch
            {
                MessageBox.Show("Dato no valido");
            }


        }
    }
}




