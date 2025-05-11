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
    public partial class frmDivisivelPor3 : Form
    {
        public frmDivisivelPor3()
        {
            InitializeComponent();

            // Define a imagem de fundo
            this.BackgroundImage = Image.FromFile("img/bg_div.jpeg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            int numero;

            if (int.TryParse(txtDigiteSeuNumero.Text, out numero))
            {
                if (numero % 3 == 0)
                    MessageBox.Show($"O número é divisivel por 3.");

                else
                    MessageBox.Show($"O número não é divisível por 3.");
            }

            else
                MessageBox.Show($"Digite um número inteiro válido.");

        }

        private void frmDivisivelPor3_Load(object sender, EventArgs e)
        {

        }
    }
}
