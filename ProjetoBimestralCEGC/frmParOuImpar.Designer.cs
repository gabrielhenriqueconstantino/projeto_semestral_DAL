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
            panel1.BackColor = Color.Blue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(378, 46);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(89, 9);
            label1.Name = "label1";
            label1.Size = new Size(205, 33);
            label1.TabIndex = 0;
            label1.Text = "PAR OU ÍMPAR?";
            // 
            // txtInicial
            // 
            txtInicial.Location = new Point(101, 119);
            txtInicial.Name = "txtInicial";
            txtInicial.PlaceholderText = "Número inicial...";
            txtInicial.Size = new Size(179, 23);
            txtInicial.TabIndex = 4;
            // 
            // txtFinal
            // 
            txtFinal.Location = new Point(101, 148);
            txtFinal.Name = "txtFinal";
            txtFinal.PlaceholderText = "Número final...";
            txtFinal.Size = new Size(179, 23);
            txtFinal.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(87, 49);
            label2.Name = "label2";
            label2.Size = new Size(206, 17);
            label2.TabIndex = 2;
            label2.Text = "Insira um número inicial e um final.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(38, 70);
            label3.Name = "label3";
            label3.Size = new Size(305, 17);
            label3.TabIndex = 2;
            label3.Text = "Dentro deste intervalo, será exibido todos os números";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(135, 87);
            label4.Name = "label4";
            label4.Size = new Size(113, 17);
            label4.TabIndex = 2;
            label4.Text = " pares e ímpares.";
            // 
            // btnDescobrir
            // 
            btnDescobrir.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDescobrir.Location = new Point(101, 188);
            btnDescobrir.Name = "btnDescobrir";
            btnDescobrir.Size = new Size(179, 28);
            btnDescobrir.TabIndex = 2;
            btnDescobrir.Text = "DESCOBRIR";
            btnDescobrir.UseVisualStyleBackColor = true;
            btnDescobrir.Click += btnDescobrir_Click;
            // 
            // txtResultado
            // 
            txtResultado.BorderStyle = BorderStyle.FixedSingle;
            txtResultado.Enabled = false;
            txtResultado.Location = new Point(12, 235);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(353, 211);
            txtResultado.TabIndex = 1;
            txtResultado.TextAlign = HorizontalAlignment.Center;
            // 
            // frmParOuImpar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(377, 458);
            Controls.Add(txtResultado);
            Controls.Add(btnDescobrir);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(txtFinal);
            Controls.Add(txtInicial);
            Controls.Add(panel1);
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