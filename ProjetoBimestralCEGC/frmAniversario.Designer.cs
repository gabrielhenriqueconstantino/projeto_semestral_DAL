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
            txtIdade.Location = new Point(311, 172);
            txtIdade.Name = "txtIdade";
            txtIdade.PlaceholderText = "Digite sua idade:";
            txtIdade.Size = new Size(125, 27);
            txtIdade.TabIndex = 0;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(321, 249);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "Calcular:";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // frmAniversario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcular);
            Controls.Add(txtIdade);
            Name = "frmAniversario";
            Text = "frmAniversario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdade;
        private Button btnCalcular;
    }
}