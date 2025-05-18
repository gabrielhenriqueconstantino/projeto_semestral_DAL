namespace ProjetoBimestralCEGC
{
    partial class frmArray
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
            lblResultado = new Label();
            txtNumero = new TextBox();
            btnAdicionar = new Button();
            btnConferir = new Button();
            lstNumeros = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 84);
            label1.Name = "label1";
            label1.Size = new Size(136, 20);
            label1.TabIndex = 0;
            label1.Text = "Numero ( 0 a 100 ):";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(422, 87);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(75, 20);
            lblResultado.TabIndex = 1;
            lblResultado.Text = "Resultado";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(239, 84);
            txtNumero.Name = "txtNumero";
            txtNumero.PlaceholderText = "Digite o Numero:";
            txtNumero.Size = new Size(160, 27);
            txtNumero.TabIndex = 2;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(239, 134);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(113, 29);
            btnAdicionar.TabIndex = 3;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnConferir
            // 
            btnConferir.Location = new Point(239, 169);
            btnConferir.Name = "btnConferir";
            btnConferir.Size = new Size(113, 29);
            btnConferir.TabIndex = 4;
            btnConferir.Text = "Conferir";
            btnConferir.UseVisualStyleBackColor = true;
            btnConferir.Click += btnConferir_Click;
            // 
            // lstNumeros
            // 
            lstNumeros.FormattingEnabled = true;
            lstNumeros.Location = new Point(65, 123);
            lstNumeros.Name = "lstNumeros";
            lstNumeros.Size = new Size(150, 104);
            lstNumeros.TabIndex = 5;
            // 
            // frmArray
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 370);
            Controls.Add(lstNumeros);
            Controls.Add(btnConferir);
            Controls.Add(btnAdicionar);
            Controls.Add(txtNumero);
            Controls.Add(lblResultado);
            Controls.Add(label1);
            Name = "frmArray";
            Text = "frmArray";
            Load += frmArray_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblResultado;
        private TextBox txtNumero;
        private Button btnAdicionar;
        private Button btnConferir;
        private ListBox lstNumeros;
    }
}