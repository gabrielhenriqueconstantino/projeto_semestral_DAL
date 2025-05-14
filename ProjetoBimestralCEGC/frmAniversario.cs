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
    public partial class frmAniversario : Form
    {
        public frmAniversario()
        {
            InitializeComponent();

            this.MaximizeBox = false;// Remove o botão de maximizar
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Impede o redimensionamento

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            DateTime nascimento;

            if (DateTime.TryParse(txtIdade.Text, out nascimento))
            {
                DateTime hoje = DateTime.Today;
                int idade = hoje.Year - nascimento.Year;
                if (nascimento.Date > hoje.AddYears(-idade)) idade--;
                MessageBox.Show($"Idade: " + idade + "anos.");
            }
            else
            {
                MessageBox.Show($"Digite uma data de nascimento válida.");
            }

        }

        private void frmAniversario_Load(object sender, EventArgs e)
        {

        }
    }
}
