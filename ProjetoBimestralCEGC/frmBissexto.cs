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
    public partial class frmBissexto : Form
    {
        public frmBissexto()
        {
            InitializeComponent();

            // Define a imagem de fundo
            this.BackgroundImage = Image.FromFile("img/bg_bissexto.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            this.MaximizeBox = false;           // Remove o botão de maximizar
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Impede o redimensionamento
        }

        public bool EhAnoBissexto(int ano)
        {
            return DateTime.IsLeapYear(ano);
        }

        private void btnDescobrir_Click(object sender, EventArgs e)
        {
            try
            {
                int ano = Convert.ToInt32(txtAno.Text);

                if (EhAnoBissexto(ano))
                {
                    txtResultado.Text = $"{ano} é um ano bissexto.";
                }
                else
                {
                    txtResultado.Text = $"{ano} NÃO é um ano bissexto.";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite um ano válido (número inteiro).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAno.Focus();
            }
            catch (Exception ex)
            {
                // Tratamento genérico para outros erros inesperados
                MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmBissexto_Load(object sender, EventArgs e)
        {

        }
    }
}
