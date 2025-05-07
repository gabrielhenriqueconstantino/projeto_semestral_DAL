using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoBimestralCEGC
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();

            // Configura o MDI
            this.IsMdiContainer = true;

            // Define a imagem de fundo
            this.BackgroundImage = Image.FromFile("img/bg.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void menu1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void conversorDeTempoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTempo frm = new frmTempo();

            frm.MdiParent = this;
            frm.Show();
        }
    }
}
