using System;
using System.Windows.Forms;

namespace Trabajo1.Formas
{
    public partial class FormaInstrucciones : Form
    {
        public FormaInstrucciones()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormaMemo forma = new FormaMemo();
            forma.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
