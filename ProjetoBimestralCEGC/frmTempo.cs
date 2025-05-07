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

        }
    }
}
