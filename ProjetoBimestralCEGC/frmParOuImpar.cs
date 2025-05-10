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
    public partial class frmParOuImpar : Form
    {
        public frmParOuImpar()
        {
            InitializeComponent();
        }

        private void btnDescobrir_Click(object sender, EventArgs e)
        {
            // Verifica se as entradas são números válidos
            if (int.TryParse(txtInicial.Text, out int inicio) && int.TryParse(txtFinal.Text, out int fim))
            {
                if (inicio > fim)
                {
                    MessageBox.Show("O número inicial deve ser menor ou igual ao número final.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                List<int> pares = new List<int>();
                List<int> impares = new List<int>();

                for (int i = inicio; i <= fim; i++)
                {
                    if (i % 2 == 0)
                        pares.Add(i);
                    else
                        impares.Add(i);
                }

                // Monta o texto de saída
                txtResultado.Text = "Números pares: " + string.Join(", ", pares) +
                                    Environment.NewLine +
                                    "Números ímpares: " + string.Join(", ", impares);
            }
            else
            {
                MessageBox.Show("Insira números inteiros válidos.", "Erro de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
