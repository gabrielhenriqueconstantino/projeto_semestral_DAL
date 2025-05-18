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

            // Impede redimensionamento e maximização
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

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

        public void CentralizarFormulario(Form form)
        {
            if (form.MdiParent != null)
            {
                int x = (form.MdiParent.ClientSize.Width - form.Width) / 2;
                int y = (form.MdiParent.ClientSize.Height - form.Height) / 2;
                form.Location = new Point(Math.Max(x, 0), Math.Max(y, 0));
            }
        }

        private void conversorDeTempoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTempo frm = new frmTempo();
            frm.Load += (s, ev) => CentralizarFormulario(frm);
            frm.MdiParent = this;
            frm.Show();
        }

        private void númerosParesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmParOuImpar frm = new frmParOuImpar();
            frm.Load += (s, ev) => CentralizarFormulario(frm);
            frm.MdiParent = this;
            frm.Show();
        }

        private void conversorKelvinFahrenheitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTemperatura frm = new frmTemperatura();
            frm.Load += (s, ev) => CentralizarFormulario(frm);
            frm.MdiParent = this;
            frm.Show();
        }

        private void divisívelPoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDivisivelPor3 frm = new frmDivisivelPor3();
            frm.Load += (s, ev) => CentralizarFormulario(frm);
            frm.MdiParent = this;
            frm.Show();
        }

        private void suaIdadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAniversario frm = new frmAniversario();
            frm.Load += (s, ev) => CentralizarFormulario(frm);
            frm.MdiParent = this;
            frm.Show();
        }

        private void dobroOuMetadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDobroMetade frm = new frmDobroMetade();
            frm.Load += (s, ev) => CentralizarFormulario(frm);
            frm.MdiParent = this;
            frm.Show();

        }

        private void diferençaEntreEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDiferençaMaiorMenor frm = new frmDiferençaMaiorMenor();
            frm.Load += (s, ev) => CentralizarFormulario(frm);
            frm.MdiParent = this;
            frm.Show();
        }

        private void cálculoIMCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalcIMC frm = new frmCalcIMC();
            frm.Load += (s, ev) => CentralizarFormulario(frm);
            frm.MdiParent = this;
            frm.Show();
        }

        private void diasEntreDatasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDiferencaDatas frm = new frmDiferencaDatas();
            frm.Load += (s, ev) => CentralizarFormulario(frm);
            frm.MdiParent = this;
            frm.Show();

        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNotas frm = new frmNotas();
            frm.Load += (s, ev) => CentralizarFormulario(frm);
            frm.MdiParent = this;
            frm.Show();
        }

        private void compararDoisArraysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArray frm = new frmArray();
            frm.Load += (s, ev) => CentralizarFormulario(frm);
            frm.MdiParent = this;
            frm.Show();
        }




























        private void faixasNuméricasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFaixasNumericas frm = new frmFaixasNumericas();
            frm.Load += (s, ev) => CentralizarFormulario(frm);
            frm.MdiParent = this;
            frm.Show();
        }

        private void anoBissextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBissexto frm = new frmBissexto();
            frm.Load += (s, ev) => CentralizarFormulario(frm);
            frm.MdiParent = this;
            frm.Show();
        }

        private void ocorrênciaDeLetrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOcorrenciaLetra frm = new frmOcorrenciaLetra();
            frm.Load += (s, ev) => CentralizarFormulario(frm);
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
