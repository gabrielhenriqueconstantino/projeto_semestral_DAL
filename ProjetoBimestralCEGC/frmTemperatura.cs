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
    public partial class frmTemperatura : Form
    {
        public frmTemperatura()
        {
            InitializeComponent();

            // Define a imagem de fundo
            this.BackgroundImage = Image.FromFile("img/bg_temp.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            this.MaximizeBox = false;           // Remove o botão de maximizar
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Impede o redimensionamento
        }

        private void frmTemperatura_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double temperaturaCelscius = Convert.ToDouble(txtCelscius.Text);
            double temperaturaFahrenheit = (temperaturaCelscius * 9 / 5) + 32;
            double temperaturaKelvin = (temperaturaCelscius + 273.15);

            if (radioFahrenheit.Checked)
            {
                txtResultado.Text = $"{temperaturaFahrenheit} °F";
            }
            else if (radioKelvin.Checked)
            {
                txtResultado.Text = $"{temperaturaKelvin} K";
            }
            else
            {
                MessageBox.Show("Selecione uma opção de conversão.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
