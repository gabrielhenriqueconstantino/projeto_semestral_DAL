namespace ProjetoBimestralCEGC
{
    partial class frmAniversario
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
            txtIdade = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(272, 129);
            txtIdade.Margin = new Padding(3, 2, 3, 2);
            txtIdade.Name = "txtIdade";
            txtIdade.PlaceholderText = "Digite sua idade:";
            txtIdade.Size = new Size(110, 23);
            txtIdade.TabIndex = 0;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(281, 187);
            btnCalcular.Margin = new Padding(3, 2, 3, 2);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(82, 22);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "Calcular:";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // frmAniversario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnCalcular);
            Controls.Add(txtIdade);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmAniversario";
            Text = "frmAniversario";
            Load += frmAniversario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdade;
        private Button btnCalcular;
    }
}