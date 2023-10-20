using System;
using System.Windows.Forms;

namespace Trabajo1.Formas
{
    public partial class FormaDificultad : Form
    {
        public FormaDificultad()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormaMate forma = new FormaMate();
            forma.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormaMateMedio forma = new FormaMateMedio();
            forma.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormaMateDificil forma = new FormaMateDificil();
            forma.Show();
        }
    }
}
