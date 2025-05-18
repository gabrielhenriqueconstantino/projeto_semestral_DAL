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
    public partial class frmOcorrenciaLetra : Form
    {
        public frmOcorrenciaLetra()
        {
            InitializeComponent();

            this.MaximizeBox = false;// Remove o botão de maximizar
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Impede o redimensionamento

            this.BackgroundImage = Image.FromFile("img/Letras.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string frase = txtFrase.Text;
            string letraDigitada = txtLetra.Text;

            // Validação: frase não vazia e exatamente 1 caractere na letra
            if (string.IsNullOrWhiteSpace(frase) || letraDigitada.Length != 1)
            {
                MessageBox.Show($"Digite uma frase e exatamente uma letra.",
                                "Entrada inválida",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            char letra = letraDigitada[0];

            // Conta ocorrências, ignorando maiúsculas/minúsculas
            int ocorrencias = frase.Count(c => char.ToUpperInvariant(c) == char.ToUpperInvariant(letra));

            lblResultado.Text = $"Resultado: a letra \"{letra}\" aparece {ocorrencias} vez(es).";
        }

        private void frmOcorrenciaLetra_Load(object sender, EventArgs e)
        {
           
        }
    }
}
