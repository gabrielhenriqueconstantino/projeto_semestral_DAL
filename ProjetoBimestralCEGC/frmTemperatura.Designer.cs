namespace ProjetoBimestralCEGC
{
    partial class frmTemperatura
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
            label1 = new Label();
            txtCelscius = new TextBox();
            radioFahrenheit = new RadioButton();
            radioKelvin = new RadioButton();
            btnCalcular = new Button();
            label2 = new Label();
            txtResultado = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 23.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(91, 3);
            label1.Name = "label1";
            label1.Size = new Size(190, 37);
            label1.TabIndex = 0;
            label1.Text = "Cº ⮀ F° ⮀ K°";
            // 
            // txtCelscius
            // 
            txtCelscius.Location = new Point(91, 66);
            txtCelscius.Name = "txtCelscius";
            txtCelscius.PlaceholderText = "Temperatura em Celcius...";
            txtCelscius.Size = new Size(190, 23);
            txtCelscius.TabIndex = 1;
            // 
            // radioFahrenheit
            // 
            radioFahrenheit.AutoSize = true;
            radioFahrenheit.BackColor = Color.Transparent;
            radioFahrenheit.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioFahrenheit.ForeColor = SystemColors.ButtonHighlight;
            radioFahrenheit.Location = new Point(91, 118);
            radioFahrenheit.Name = "radioFahrenheit";
            radioFahrenheit.Size = new Size(104, 24);
            radioFahrenheit.TabIndex = 2;
            radioFahrenheit.TabStop = true;
            radioFahrenheit.Text = "Fahrenheit";
            radioFahrenheit.UseVisualStyleBackColor = false;
            // 
            // radioKelvin
            // 
            radioKelvin.AutoSize = true;
            radioKelvin.BackColor = Color.Transparent;
            radioKelvin.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioKelvin.ForeColor = SystemColors.ButtonHighlight;
            radioKelvin.Location = new Point(208, 118);
            radioKelvin.Name = "radioKelvin";
            radioKelvin.Size = new Size(71, 24);
            radioKelvin.TabIndex = 2;
            radioKelvin.TabStop = true;
            radioKelvin.Text = "Kelvin";
            radioKelvin.UseVisualStyleBackColor = false;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(126, 148);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(125, 33);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(126, 92);
            label2.Name = "label2";
            label2.Size = new Size(125, 18);
            label2.TabIndex = 4;
            label2.Text = "Converter para:";
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(91, 206);
            txtResultado.Name = "txtResultado";
            txtResultado.PlaceholderText = "Resultado aparecerá aqui...";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(190, 23);
            txtResultado.TabIndex = 5;
            txtResultado.TextAlign = HorizontalAlignment.Center;
            // 
            // frmTemperatura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 351);
            Controls.Add(txtResultado);
            Controls.Add(label2);
            Controls.Add(btnCalcular);
            Controls.Add(radioKelvin);
            Controls.Add(radioFahrenheit);
            Controls.Add(txtCelscius);
            Controls.Add(label1);
            Name = "frmTemperatura";
            Text = "frmTemperatura";
            Load += frmTemperatura_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCelscius;
        private RadioButton radioFahrenheit;
        private RadioButton radioKelvin;
        private Button btnCalcular;
        private Label label2;
        private TextBox txtResultado;
    }
}