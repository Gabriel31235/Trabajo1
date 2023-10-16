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
    public partial class FormaRuleta : Form
    {
        private int numeroGanador;
        private bool juegoTerminado = false;
        public FormaRuleta()
        {
            InitializeComponent();
            Random random = new Random();
            numeroGanador = random.Next(1, 7);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (juegoTerminado)
                {
                    MessageBox.Show("El juego ya terminó. Reinicia la aplicación para jugar de nuevo.");
                    return;
                }

                int numeroElegido;
                if (int.TryParse(textBox1.Text, out numeroElegido))
                {
                    if (numeroElegido == numeroGanador)
                    {
                        MessageBox.Show("¡Ganaste!");
                    }
                    else
                    {
                        MessageBox.Show("Perdiste. El número ganador era " + numeroGanador);
                    }

                    juegoTerminado = true;
                }
                else
                {
                    MessageBox.Show("Ingresa un número válido en el TextBox.");
                }
            }
        }
    }

}
    

