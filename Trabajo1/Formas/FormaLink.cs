using System.Windows.Forms;

namespace Trabajo1.Formas
{
    public partial class FormaLink : Form
    {
        public FormaLink()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://learn.microsoft.com/es-es/visualstudio/get-started/csharp/tutorial-windows-forms-picture-viewer-layout?view=vs-2022");
        }
    }
}
