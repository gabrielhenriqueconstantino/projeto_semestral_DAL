namespace ProjetoBimestralCEGC
{
    partial class frmFaixasNumericas
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtNumero = new TextBox();
            btnAdicionar = new Button();
            listBoxNumeros = new ListBox();
            btnConferir = new Button();
            SuspendLayout();
            // 
            // txtNumero
            // 
            txtNumero.Cursor = Cursors.IBeam;
            txtNumero.Font = new Font("Century Gothic", 9F);
            txtNumero.Location = new Point(73, 38);
            txtNumero.Name = "txtNumero";
            txtNumero.PlaceholderText = "Insira um número entre 0 e 100...";
            txtNumero.Size = new Size(218, 22);
            txtNumero.TabIndex = 1;
            txtNumero.KeyPress += txtNumero_KeyPress;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Font = new Font("Century Gothic", 9F);
            btnAdicionar.Location = new Point(125, 66);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(121, 29);
            btnAdicionar.TabIndex = 0;
            btnAdicionar.Text = "ADICIONAR";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // listBoxNumeros
            // 
            listBoxNumeros.Font = new Font("Century Gothic", 9F);
            listBoxNumeros.FormattingEnabled = true;
            listBoxNumeros.ItemHeight = 17;
            listBoxNumeros.Location = new Point(94, 101);
            listBoxNumeros.Name = "listBoxNumeros";
            listBoxNumeros.SelectionMode = SelectionMode.None;
            listBoxNumeros.Size = new Size(185, 157);
            listBoxNumeros.TabIndex = 2;
            // 
            // btnConferir
            // 
            btnConferir.Font = new Font("Century Gothic", 9F);
            btnConferir.Location = new Point(125, 274);
            btnConferir.Name = "btnConferir";
            btnConferir.Size = new Size(121, 28);
            btnConferir.TabIndex = 2;
            btnConferir.Text = "CONFERIR";
            btnConferir.UseVisualStyleBackColor = true;
            btnConferir.Click += btnConferir_Click;
            // 
            // frmFaixasNumericas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 341);
            Controls.Add(listBoxNumeros);
            Controls.Add(btnConferir);
            Controls.Add(btnAdicionar);
            Controls.Add(txtNumero);
            Name = "frmFaixasNumericas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Classificador de Faixas Numéricas";
            Load += frmFaixasNumericas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumero;
        private Button btnAdicionar;
        private ListBox listBoxNumeros;
        private Button btnConferir;
    }
}