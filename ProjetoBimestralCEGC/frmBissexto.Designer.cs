namespace ProjetoBimestralCEGC
{
    partial class frmBissexto
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
            txtAno = new TextBox();
            label1 = new Label();
            btnDescobrir = new Button();
            txtResultado = new TextBox();
            SuspendLayout();
            // 
            // txtAno
            // 
            txtAno.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAno.Location = new Point(69, 46);
            txtAno.Multiline = true;
            txtAno.Name = "txtAno";
            txtAno.PlaceholderText = "Insira um ano (APENAS NÚMEROS)...";
            txtAno.Size = new Size(245, 27);
            txtAno.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(58, 2);
            label1.Name = "label1";
            label1.Size = new Size(271, 30);
            label1.TabIndex = 1;
            label1.Text = "ESSE ANO É BISSEXTO?";
            // 
            // btnDescobrir
            // 
            btnDescobrir.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDescobrir.Location = new Point(69, 81);
            btnDescobrir.Name = "btnDescobrir";
            btnDescobrir.Size = new Size(245, 31);
            btnDescobrir.TabIndex = 1;
            btnDescobrir.Text = "DESCUBRA";
            btnDescobrir.UseVisualStyleBackColor = true;
            btnDescobrir.Click += btnDescobrir_Click;
            // 
            // txtResultado
            // 
            txtResultado.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResultado.Location = new Point(69, 128);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.PlaceholderText = "Resultado aparecerá aqui...";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(245, 36);
            txtResultado.TabIndex = 3;
            txtResultado.TextAlign = HorizontalAlignment.Center;
            // 
            // frmBissexto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 339);
            Controls.Add(txtResultado);
            Controls.Add(btnDescobrir);
            Controls.Add(label1);
            Controls.Add(txtAno);
            Name = "frmBissexto";
            Text = "frmBissexto";
            Load += frmBissexto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAno;
        private Label label1;
        private Button btnDescobrir;
        private TextBox txtResultado;
    }
}