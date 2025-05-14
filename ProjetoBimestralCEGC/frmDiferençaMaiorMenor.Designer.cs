namespace ProjetoBimestralCEGC
{
    partial class frmDiferençaMaiorMenor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNumero2 = new TextBox();
            txtNumero1 = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(152, 134);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.PlaceholderText = "Digite o segundo numero:";
            txtNumero2.Size = new Size(189, 27);
            txtNumero2.TabIndex = 0;
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(152, 79);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.PlaceholderText = "Digite o primeiro numero:";
            txtNumero1.Size = new Size(189, 27);
            txtNumero1.TabIndex = 0;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(200, 196);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // frmDiferençaMaiorMenor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 321);
            Controls.Add(btnCalcular);
            Controls.Add(txtNumero1);
            Controls.Add(txtNumero2);
            Name = "frmDiferençaMaiorMenor";
            Text = "frmDiferençaMaiorMenor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumero2;
        private TextBox txtNumero1;
        private Button btnCalcular;
    }
}