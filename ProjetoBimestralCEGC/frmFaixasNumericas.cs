using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetoBimestralCEGC
{
    public partial class frmFaixasNumericas : Form
    {
        private List<int> numbersList = new List<int>();

        public frmFaixasNumericas()
        {
            InitializeComponent();

            // Define a imagem de fundo
            this.BackgroundImage = Image.FromFile("img/bg_numeros.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            this.MaximizeBox = false;           // Remove o botão de maximizar
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Impede o redimensionamento
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumero.Text, out int number))
            {
                if (number >= 0 && number <= 100)
                {
                    numbersList.Add(number);
                    UpdateNumbersDisplay();
                    txtNumero.Clear();
                }
                else
                {
                    MessageBox.Show("Por favor, insira um número entre 0 e 100.", "Valor inválido",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um número válido.", "Entrada inválida",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            txtNumero.Focus();
        }

        private void UpdateNumbersDisplay()
        {
            listBoxNumeros.Items.Clear();
            foreach (int num in numbersList)
            {
                listBoxNumeros.Items.Add(num);
            }
        }

        private void btnConferir_Click(object sender, EventArgs e)
        {
            int range0to25 = 0;
            int range26to50 = 0;
            int range51to75 = 0;
            int range76to100 = 0;

            foreach (int num in numbersList)
            {
                if (num >= 0 && num <= 25)
                    range0to25++;
                else if (num >= 26 && num <= 50)
                    range26to50++;
                else if (num >= 51 && num <= 75)
                    range51to75++;
                else if (num >= 76 && num <= 100)
                    range76to100++;
            }

            string result = $"Quantidade por faixa:\n" +
                           $"0-25: {range0to25}\n" +
                           $"26-50: {range26to50}\n" +
                           $"51-75: {range51to75}\n" +
                           $"76-100: {range76to100}";

            MessageBox.Show(result, "Resultado da Conferência",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnAdicionar_Click(sender, e);
                e.Handled = true;
            }
        }

        private void frmFaixasNumericas_Load(object sender, EventArgs e)
        {
            // Pode adicionar inicializações aqui se necessário
        }
    }
}