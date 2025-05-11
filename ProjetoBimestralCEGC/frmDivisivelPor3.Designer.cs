namespace ProjetoBimestralCEGC
{
    partial class frmDivisivelPor3
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
            txtDigiteSeuNumero = new TextBox();
            btnConfirmar = new Button();
            SuspendLayout();
            // 
            // txtDigiteSeuNumero
            // 
            txtDigiteSeuNumero.Location = new Point(218, 109);
            txtDigiteSeuNumero.Name = "txtDigiteSeuNumero";
            txtDigiteSeuNumero.PlaceholderText = "Digite seu numero:";
            txtDigiteSeuNumero.Size = new Size(140, 27);
            txtDigiteSeuNumero.TabIndex = 0;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(245, 191);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(94, 29);
            btnConfirmar.TabIndex = 1;
            btnConfirmar.Text = "Confirmar:";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // frmDivisivelPor3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 356);
            Controls.Add(btnConfirmar);
            Controls.Add(txtDigiteSeuNumero);
            Name = "frmDivisivelPor3";
            Text = "frmDivisivelPor3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDigiteSeuNumero;
        private Button btnConfirmar;
    }
}