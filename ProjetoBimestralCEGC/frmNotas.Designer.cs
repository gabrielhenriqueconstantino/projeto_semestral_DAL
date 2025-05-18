namespace ProjetoBimestralCEGC
{
    partial class frmNotas
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
            panel1 = new Panel();
            label1 = new Label();
            txtNota = new TextBox();
            btnCalcular = new Button();
            txtResultado = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(385, 41);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(61, 9);
            label1.Name = "label1";
            label1.Size = new Size(275, 24);
            label1.TabIndex = 0;
            label1.Text = "CALCULADORA DE NOTAS";
            // 
            // txtNota
            // 
            txtNota.Location = new Point(110, 58);
            txtNota.Multiline = true;
            txtNota.Name = "txtNota";
            txtNota.PlaceholderText = "Nota do aluno...";
            txtNota.Size = new Size(169, 25);
            txtNota.TabIndex = 2;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(110, 104);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(169, 30);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(110, 165);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.PlaceholderText = "Resultado aparecerá aqui...";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(169, 36);
            txtResultado.TabIndex = 3;
            txtResultado.TextAlign = HorizontalAlignment.Center;
            // 
            // frmNotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 355);
            Controls.Add(txtResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtNota);
            Controls.Add(panel1);
            Name = "frmNotas";
            Text = "frmNotas";
            Load += frmNotas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtNota;
        private Button btnCalcular;
        private TextBox txtResultado;
    }
}