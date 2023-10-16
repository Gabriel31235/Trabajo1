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
    public partial class FormaHome : Form
    {
        public FormaHome()
        {
            InitializeComponent();
        }

        private void archivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaArchivo forma = new FormaArchivo();
            forma.Show();
        }

        private void formasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaF forma = new FormaF();
            forma.Show();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaCalc forma = new FormaCalc();
            forma.Show();
        }

        private void areaTrianguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaTraingulo forma = new FormaTraingulo();
            forma.Show();

        }

        private void conversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaConversion forma = new FormaConversion();
            forma.Show();
        }

        private void frecuenciaCardiacaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaCorazon forma = new FormaCorazon();
            forma.Show();
        }

        private void aumentoSalarialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaSalario forma = new FormaSalario();
            forma.Show();
        }

        private void formulaCuadraticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaFormula forma = new FormaFormula();
            forma.Show();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaHelp forma = new FormaHelp();
            forma.Show();
        }

        private void ruletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaRuleta forma = new FormaRuleta();
            forma.Show();
        }

        private void matematicasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void visorDeImagenesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormaVisor forma = new FormaVisor();
            forma.Show();
        }

        private void matematicasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormaDificultad forma = new FormaDificultad();
            forma.Show();
        }
    }
}
