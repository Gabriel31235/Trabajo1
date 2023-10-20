using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Trabajo1.Formas
{
    public partial class FormaGatolink : Form
    {
        public FormaGatolink()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            {
                // Define la URL a la que deseas redirigir
                string url = "https://www.youtube.com/watch?v=5TXvQ3CpkM0";

                // Abre la URL en el navegador predeterminado del sistema
                Process.Start(url);
            }
        }
    }
}
