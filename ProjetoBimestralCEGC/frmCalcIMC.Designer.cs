namespace ProjetoBimestralCEGC
{
    partial class frmCalcIMC
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
            txtPeso = new TextBox();
            txtAltura = new TextBox();
            btnCalcular = new Button();
            txtResultado = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 192, 0);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(406, 52);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(81, 9);
            label1.Name = "label1";
            label1.Size = new Size(258, 30);
            label1.TabIndex = 0;
            label1.Text = "Calculadora de IMC";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(118, 80);
            txtPeso.Name = "txtPeso";
            txtPeso.PlaceholderText = "Insira seu peso...";
            txtPeso.Size = new Size(183, 23);
            txtPeso.TabIndex = 1;
            txtPeso.TextChanged += txtPeso_TextChanged;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(118, 109);
            txtAltura.Name = "txtAltura";
            txtAltura.PlaceholderText = "Insira sua altura...";
            txtAltura.Size = new Size(183, 23);
            txtAltura.TabIndex = 1;
            txtAltura.TextChanged += txtPeso_TextChanged;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(118, 148);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(183, 31);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(118, 213);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.PlaceholderText = "Resultado aparecerá aqui...";
            txtResultado.Size = new Size(183, 76);
            txtResultado.TabIndex = 3;
            txtResultado.TextAlign = HorizontalAlignment.Center;
            // 
            // frmCalcIMC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 364);
            Controls.Add(txtResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtAltura);
            Controls.Add(txtPeso);
            Controls.Add(panel1);
            Name = "frmCalcIMC";
            Text = "frmCalcIMC";
            Load += frmCalcIMC_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtPeso;
        private TextBox txtAltura;
        private Button btnCalcular;
        private TextBox txtResultado;
    }
}