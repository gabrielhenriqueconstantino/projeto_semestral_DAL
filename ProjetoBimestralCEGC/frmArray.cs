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
    public partial class frmArray : Form
    {
        private readonly List<int> numeros = new();
        public frmArray()
        {
            InitializeComponent();

            this.MaximizeBox = false;// Remove o botão de maximizar
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Impede o redimensionamento

            this.BackgroundImage = Image.FromFile("img/array.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void frmArray_Load(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumero.Text, out int num) && num >= 0 && num <= 100)
            {
                numeros.Add(num);           // guarda
                AtualizarLista();            // mostra na ListBox
                txtNumero.Clear();
                txtNumero.Focus();
            }
            else
            {
                MessageBox.Show("Digite um número inteiro entre 0 e 100.",
                                "Entrada inválida", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtNumero.SelectAll();
                txtNumero.Focus();
            }
        }

        private void btnConferir_Click(object sender, EventArgs e)
        {
            int faixaA = numeros.Count(n => n <= 25);                 // 0–25
            int faixaB = numeros.Count(n => n >= 26 && n <= 50);      // 26–50
            int faixaC = numeros.Count(n => n >= 51 && n <= 75);      // 51–75
            int faixaD = numeros.Count(n => n >= 76);                 // 76–100

            lblResultado.Text =
                $"Resultados:\n" +
                $"a) 0 – 25 : {faixaA}\n" +
                $"b) 26 – 50: {faixaB}\n" +
                $"c) 51 – 75: {faixaC}\n" +
                $"d) 76 – 100: {faixaD}";
        }

        private void AtualizarLista()
        {
            lstNumeros.Items.Clear();
            foreach (int n in numeros)
                lstNumeros.Items.Add(n);
        }
    }
}
