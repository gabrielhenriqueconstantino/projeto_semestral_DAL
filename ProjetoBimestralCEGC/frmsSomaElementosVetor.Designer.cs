namespace ProjetoBimestralCEGC
{
    partial class frmsSomaElementosVetor
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
            txtNumeros = new TextBox();
            btnCalcular = new Button();
            txtResultado = new TextBox();
            SuspendLayout();
            // 
            // txtNumeros
            // 
            txtNumeros.Font = new Font("Century Gothic", 9F);
            txtNumeros.Location = new Point(115, 12);
            txtNumeros.Multiline = true;
            txtNumeros.Name = "txtNumeros";
            txtNumeros.PlaceholderText = "Insira oito números, um por linha...";
            txtNumeros.Size = new Size(222, 194);
            txtNumeros.TabIndex = 2;
            txtNumeros.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Century Gothic", 9F);
            btnCalcular.Location = new Point(115, 212);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(222, 38);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtResultado
            // 
            txtResultado.Font = new Font("Century Gothic", 9F);
            txtResultado.Location = new Point(115, 268);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.PlaceholderText = "Resultado aparecerá aqui...";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(222, 27);
            txtResultado.TabIndex = 2;
            txtResultado.TextAlign = HorizontalAlignment.Center;
            // 
            // frmsSomaElementosVetor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 358);
            Controls.Add(txtResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtNumeros);
            Name = "frmsSomaElementosVetor";
            Text = "frmsSomaElementosVetor";
            Load += frmsSomaElementosVetor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumeros;
        private Button btnCalcular;
        private TextBox txtResultado;
    }
}