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
    public partial class frmTempo : Form
    {
        public frmTempo()
        {
            InitializeComponent();

            // Define a imagem de fundo
            this.BackgroundImage = Image.FromFile("img/bg_tempo.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void frmTempo_Load(object sender, EventArgs e)
        {

        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            // Verifica se o valor inserido é um número inteiro válido
            if (int.TryParse(txtSegundos.Text, out int totalSegundos) && totalSegundos >= 0)
            {
                int horas = totalSegundos / 3600;
                int minutos = (totalSegundos % 3600) / 60;
                int segundos = totalSegundos % 60;

                txtResultado.Text = $"{horas} hora{(horas != 1 ? "s" : "")}, {minutos} minuto{(minutos != 1 ? "s" : "")} e {segundos} segundo{(segundos != 1 ? "s" : "")}";

            }
            else
            {
                MessageBox.Show("Por favor, insira um número inteiro de segundos válido.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
