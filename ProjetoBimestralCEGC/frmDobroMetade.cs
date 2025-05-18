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
    public partial class frmDobroMetade : Form
    {
        public frmDobroMetade()
        {
            InitializeComponent();

            this.MaximizeBox = false;// Remove o botão de maximizar
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Impede o redimensionamento

            this.BackgroundImage = Image.FromFile("img/Roleta.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero;

            if (int.TryParse(txtNumero.Text, out numero))
            {
                if (numero % 2 == 0)
                {
                    int dobro = numero * 2;
                    MessageBox.Show($"Número par. Dobro: {dobro}");
                }
                else
                {
                    double metade = numero / 2.0;
                    MessageBox.Show($"Número ímpar. Metade: {metade}");
                }
            }
            else
            {
                MessageBox.Show("Por favor, digite um número inteiro válido.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumero.Focus();
            }
        }

        private void frmDobroMetade_Load(object sender, EventArgs e)
        {

        }
    }
}
