using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBimestralCEGC
{
    public partial class frmDiferençaMaiorMenor : Form
    {
        public frmDiferençaMaiorMenor()
        {
            InitializeComponent();

            this.MaximizeBox = false;// Remove o botão de maximizar
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Impede o redimensionamento

            this.BackgroundImage = Image.FromFile("img/MenorMaior.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero1, numero2;

            if (int.TryParse(txtNumero1.Text, out numero1) && int.TryParse(txtNumero2.Text, out numero2))
            {
                int maior = Math.Max(numero1, numero2);
                int menor = Math.Min(numero1, numero2);
                int diferenca = maior - menor;

                MessageBox.Show($"Diferença entre o maior e o menor: {diferenca}");
            }
            else
            {
                MessageBox.Show("Por favor, digite dois números inteiros válidos.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumero1.Focus();
            }
        }

        private void frmDiferençaMaiorMenor_Load(object sender, EventArgs e)
        {

        }
    }
}
