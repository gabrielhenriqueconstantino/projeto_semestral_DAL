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
    public partial class frmIMC : Form
    {
        public frmIMC()
        {
            InitializeComponent();

            // Define a imagem de fundo
            this.BackgroundImage = Image.FromFile("img/bg_imc.jpeg"); 
            this.BackgroundImageLayout = ImageLayout.Stretch;


            this.MaximizeBox = false;           // Remove o botão de maximizar
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Impede o redimensionamento
        }
    }
}
