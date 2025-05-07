namespace ProjetoBimestralCEGC
{
    partial class frmTempo
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
            txtSegundos = new TextBox();
            btnConverter = new Button();
            txtResultado = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(366, 32);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(56, 6);
            label1.Name = "label1";
            label1.Size = new Size(255, 21);
            label1.TabIndex = 0;
            label1.Text = "Conversor de segundos para horas";
            // 
            // txtSegundos
            // 
            txtSegundos.HideSelection = false;
            txtSegundos.Location = new Point(73, 62);
            txtSegundos.Name = "txtSegundos";
            txtSegundos.PlaceholderText = "Quantos segundos?";
            txtSegundos.Size = new Size(221, 23);
            txtSegundos.TabIndex = 2;
            // 
            // btnConverter
            // 
            btnConverter.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConverter.Location = new Point(73, 102);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(221, 29);
            btnConverter.TabIndex = 1;
            btnConverter.Text = "CONVERTER";
            btnConverter.UseVisualStyleBackColor = true;
            btnConverter.Click += btnConverter_Click;
            // 
            // txtResultado
            // 
            txtResultado.Enabled = false;
            txtResultado.Location = new Point(73, 168);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(221, 159);
            txtResultado.TabIndex = 3;
            // 
            // frmTempo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 411);
            Controls.Add(txtResultado);
            Controls.Add(btnConverter);
            Controls.Add(txtSegundos);
            Controls.Add(panel1);
            Name = "frmTempo";
            Text = "Conversor de Tempo";
            Load += frmTempo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtSegundos;
        private Button btnConverter;
        private TextBox txtResultado;
    }
}