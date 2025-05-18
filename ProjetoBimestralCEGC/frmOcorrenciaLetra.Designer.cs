namespace ProjetoBimestralCEGC
{
    partial class frmOcorrenciaLetra
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
            label1 = new Label();
            txtFrase = new TextBox();
            label2 = new Label();
            txtLetra = new TextBox();
            btnConfirmar = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 108);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "Frase:";
            // 
            // txtFrase
            // 
            txtFrase.Location = new Point(162, 94);
            txtFrase.Multiline = true;
            txtFrase.Name = "txtFrase";
            txtFrase.ScrollBars = ScrollBars.Vertical;
            txtFrase.Size = new Size(224, 34);
            txtFrase.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 155);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 2;
            label2.Text = "Letra:";
            // 
            // txtLetra
            // 
            txtLetra.Location = new Point(162, 148);
            txtLetra.MaxLength = 1;
            txtLetra.Name = "txtLetra";
            txtLetra.Size = new Size(49, 27);
            txtLetra.TabIndex = 3;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(245, 198);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(94, 29);
            btnConfirmar.TabIndex = 4;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(86, 248);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(75, 20);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "Resultado";
            // 
            // frmOcorrenciaLetra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 397);
            Controls.Add(lblResultado);
            Controls.Add(btnConfirmar);
            Controls.Add(txtLetra);
            Controls.Add(label2);
            Controls.Add(txtFrase);
            Controls.Add(label1);
            Name = "frmOcorrenciaLetra";
            Text = "frmOcorrenciaLetra";
            Load += frmOcorrenciaLetra_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFrase;
        private Label label2;
        private TextBox txtLetra;
        private Button btnConfirmar;
        private Label lblResultado;
    }
}