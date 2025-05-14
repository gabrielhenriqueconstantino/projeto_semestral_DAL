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
    public partial class frmCalcIMC : Form
    {
        public frmCalcIMC()
        {
            InitializeComponent();

            // Define a imagem de fundo
            this.BackgroundImage = Image.FromFile("img/bg_imc.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            this.MaximizeBox = false;           // Remove o botão de maximizar
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Impede o redimensionamento
        }

        private void frmCalcIMC_Load(object sender, EventArgs e)
        {

        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
           double peso = Convert.ToDouble(txtPeso.Text);
           double altura = Convert.ToDouble(txtAltura.Text);
           double imc = peso / (altura * altura);

            if (imc < 18.5)
            {
                txtResultado.Text = $"Seu IMC é {imc:F2}. Abaixo do peso";
            }
            else if (imc >= 18.5 && imc < 24.9)
            {
                txtResultado.Text = $"Seu IMC é {imc:F2}. Peso normal";
            }
            else if (imc >= 25 && imc < 29.9)
            {
                txtResultado.Text = $"Seu IMC é {imc:F2}. Sobrepeso";
            }
            else
            {
                txtResultado.Text = $"Seu IMC é {imc:F2}. Obesidade";
            }
        }
    }
}
