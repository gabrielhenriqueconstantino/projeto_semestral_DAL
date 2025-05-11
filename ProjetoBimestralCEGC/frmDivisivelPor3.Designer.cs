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
            label1 = new Label();
            SuspendLayout();
            // 
            // txtDigiteSeuNumero
            // 
            txtDigiteSeuNumero.Location = new Point(68, 49);
            txtDigiteSeuNumero.Margin = new Padding(3, 2, 3, 2);
            txtDigiteSeuNumero.Name = "txtDigiteSeuNumero";
            txtDigiteSeuNumero.PlaceholderText = "Digite seu numero:";
            txtDigiteSeuNumero.Size = new Size(174, 23);
            txtDigiteSeuNumero.TabIndex = 0;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(114, 79);
            btnConfirmar.Margin = new Padding(3, 2, 3, 2);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(82, 22);
            btnConfirmar.TabIndex = 1;
            btnConfirmar.Text = "Confirmar:";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(289, 23);
            label1.TabIndex = 2;
            label1.Text = "Seu número é divisível por 3??";
            // 
            // frmDivisivelPor3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 267);
            Controls.Add(label1);
            Controls.Add(btnConfirmar);
            Controls.Add(txtDigiteSeuNumero);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmDivisivelPor3";
            Text = "frmDivisivelPor3";
            Load += frmDivisivelPor3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDigiteSeuNumero;
        private Button btnConfirmar;
        private Label label1;
    }
}