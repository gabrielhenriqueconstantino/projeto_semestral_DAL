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
    public partial class frmsSomaElementosVetor : Form
    {
        public frmsSomaElementosVetor()
        {
            InitializeComponent();

            // Define a imagem de fundo
            this.BackgroundImage = Image.FromFile("img/bg_vetor.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            this.MaximizeBox = false;           // Remove o botão de maximizar
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Impede o redimensionamento
        }

        private void frmsSomaElementosVetor_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Verifica se a TextBox tem 8 linhas (uma para cada número)
            string[] linhas = txtNumeros.Lines;

            if (linhas.Length != 8)
            {
                MessageBox.Show("Por favor, insira exatamente 8 números (um em cada linha).");
                return;
            }

            int[] numeros = new int[8];
            int soma = 0;

            for (int i = 0; i < 8; i++)
            {
                if (int.TryParse(linhas[i].Trim(), out int numero))
                {
                    numeros[i] = numero;
                    soma += numeros[i] * i; // Multiplica o número pela sua posição (0 a 7)
                }
                else
                {
                    MessageBox.Show($"Linha {i + 1} não é um número válido: '{linhas[i]}'");
                    return;
                }
            }

            // Mostra o resultado (pode ser em um Label ou MessageBox)
            txtResultado.Text = $"Soma = {soma}";
            // Ou: MessageBox.Show($"Soma dos elementos × posição = {soma}");
        }
    }
}
