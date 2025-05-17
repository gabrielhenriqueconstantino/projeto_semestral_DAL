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
    public partial class frmDiferencaDatas : Form
    {
        public frmDiferencaDatas()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (DateTime.TryParse(txtNumeroUM.Text,   // entrada 1
                           out DateTime dataInicial) &&
         DateTime.TryParse(txtNumeroDois.Text, // entrada 2
                           out DateTime dataFinal))
            {
                int dias = Math.Abs((dataFinal - dataInicial).Days);
                MessageBox.Show($"Diferença entre dias: {dias}");
            }
            else
            {
                MessageBox.Show($"Digite datas válidas (ex.: 17/05/2025).",
                                "Entrada inválida");
            }
        }
    }
}
