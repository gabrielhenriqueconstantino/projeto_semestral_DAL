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
    public partial class frmNotas : Form
    {
        public frmNotas()
        {
            InitializeComponent();

            // Define a imagem de fundo
            this.BackgroundImage = Image.FromFile("img/bg_notas.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            this.MaximizeBox = false;           // Remove o botão de maximizar
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Impede o redimensionamento
        }

        private void frmNotas_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double nota = Convert.ToDouble(txtNota.Text);
            
            if (nota >= 0 && nota <= 10)
            {
                if (nota == 10)
                {
                    txtResultado.Text = ($"Nota {nota}. Excelente");
                }
                else if (nota >= 8 && nota <= 9.9)
                {
                    txtResultado.Text = ($"Nota {nota}. Muito Bom");
                }
                else if (nota >= 7 && nota <= 7.9)
                {
                    txtResultado.Text = ($"Nota {nota}. Bom");
                }
                else if (nota >= 0 && nota <= 6.9)
                {
                    txtResultado.Text = ($"Nota {nota}. Insatisfatório.");
                }
            }

            else if (nota < 0)
            {
                MessageBox.Show("Nota inválida. Digite uma nota maior ou igual a 0.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (nota > 10)
            {
                MessageBox.Show("Nota inválida. Digite uma nota menor ou igual a 10.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                MessageBox.Show("Nota inválida. Digite uma nota entre 0 e 10.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
