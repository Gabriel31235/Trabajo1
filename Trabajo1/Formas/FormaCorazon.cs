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
    public partial class FormaCorazon : Form
    {
        public FormaCorazon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int age) || age <= 0)
            {
                MessageBox.Show("Por favor, introduce una edad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int heartRate = 220 - age;

            textBox2.Text = $"Tu BPM: {heartRate}";
        }
    }
}
        
    

