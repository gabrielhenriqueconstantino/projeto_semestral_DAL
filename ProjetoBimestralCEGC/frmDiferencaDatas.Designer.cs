namespace ProjetoBimestralCEGC
{
    partial class frmDiferencaDatas
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
            btnCalcular = new Button();
            txtNumeroUM = new TextBox();
            txtNumeroDois = new TextBox();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(332, 233);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular:";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtNumeroUM
            // 
            txtNumeroUM.Location = new Point(279, 153);
            txtNumeroUM.Name = "txtNumeroUM";
            txtNumeroUM.PlaceholderText = "DIgite a Primeira Data:";
            txtNumeroUM.Size = new Size(206, 27);
            txtNumeroUM.TabIndex = 3;
            // 
            // txtNumeroDois
            // 
            txtNumeroDois.Location = new Point(279, 200);
            txtNumeroDois.Name = "txtNumeroDois";
            txtNumeroDois.PlaceholderText = "Digite a Segunda Data:";
            txtNumeroDois.Size = new Size(206, 27);
            txtNumeroDois.TabIndex = 4;
            // 
            // frmDiferencaDatas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNumeroDois);
            Controls.Add(txtNumeroUM);
            Controls.Add(btnCalcular);
            Name = "frmDiferencaDatas";
            Text = "frmDiferencaDatas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCalcular;
        private TextBox txtNumeroUM;
        private TextBox txtNumeroDois;
    }
}