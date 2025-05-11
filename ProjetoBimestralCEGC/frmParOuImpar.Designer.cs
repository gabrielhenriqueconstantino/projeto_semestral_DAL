namespace ProjetoBimestralCEGC
{
    partial class frmParOuImpar
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
            txtInicial = new TextBox();
            txtFinal = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnDescobrir = new Button();
            txtResultado = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(432, 61);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(6, 12);
            label1.Name = "label1";
            label1.Size = new Size(455, 36);
            label1.TabIndex = 0;
            label1.Text = "DESCUBRA OS NÚMEROS PARES";
            // 
            // txtInicial
            // 
            txtInicial.Location = new Point(115, 159);
            txtInicial.Margin = new Padding(3, 4, 3, 4);
            txtInicial.Name = "txtInicial";
            txtInicial.PlaceholderText = "Número inicial...";
            txtInicial.Size = new Size(204, 27);
            txtInicial.TabIndex = 4;
            // 
            // txtFinal
            // 
            txtFinal.Location = new Point(115, 197);
            txtFinal.Margin = new Padding(3, 4, 3, 4);
            txtFinal.Name = "txtFinal";
            txtFinal.PlaceholderText = "Número final...";
            txtFinal.Size = new Size(204, 27);
            txtFinal.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(99, 65);
            label2.Name = "label2";
            label2.Size = new Size(272, 23);
            label2.TabIndex = 2;
            label2.Text = "Insira um número inicial e um final.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(43, 93);
            label3.Name = "label3";
            label3.Size = new Size(403, 23);
            label3.TabIndex = 2;
            label3.Text = "Dentro deste intervalo, será exibido todos os números";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(182, 116);
            label4.Name = "label4";
            label4.Size = new Size(77, 28);
            label4.TabIndex = 2;
            label4.Text = "PARES.";
            // 
            // btnDescobrir
            // 
            btnDescobrir.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDescobrir.Location = new Point(115, 251);
            btnDescobrir.Margin = new Padding(3, 4, 3, 4);
            btnDescobrir.Name = "btnDescobrir";
            btnDescobrir.Size = new Size(205, 37);
            btnDescobrir.TabIndex = 2;
            btnDescobrir.Text = "DESCOBRIR";
            btnDescobrir.UseVisualStyleBackColor = true;
            btnDescobrir.Click += btnDescobrir_Click;
            // 
            // txtResultado
            // 
            txtResultado.BorderStyle = BorderStyle.FixedSingle;
            txtResultado.Enabled = false;
            txtResultado.Location = new Point(14, 313);
            txtResultado.Margin = new Padding(3, 4, 3, 4);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(403, 281);
            txtResultado.TabIndex = 1;
            // 
            // frmParOuImpar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(431, 611);
            Controls.Add(txtResultado);
            Controls.Add(btnDescobrir);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(txtFinal);
            Controls.Add(txtInicial);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmParOuImpar";
            Text = "frmParOuImpar";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtInicial;
        private TextBox txtFinal;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnDescobrir;
        private TextBox txtResultado;
    }
}