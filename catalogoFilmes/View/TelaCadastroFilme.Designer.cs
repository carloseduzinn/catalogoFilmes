namespace catalogoFilmes.View
{
    partial class TelaCadastroFilme
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboxcategoria = new System.Windows.Forms.ComboBox();
            this.txtestreia = new System.Windows.Forms.TextBox();
            this.txboxfilme = new System.Windows.Forms.TextBox();
            this.txboxduracao = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(248, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Filme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(158, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Filme:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(158, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estreia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(427, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Categoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(158, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Duração:";
            // 
            // cboxcategoria
            // 
            this.cboxcategoria.FormattingEnabled = true;
            this.cboxcategoria.Items.AddRange(new object[] {
            "Terror",
            "Romance",
            "Comédia",
            "Ficção ",
            "Animação",
            "Ação",
            "Suspense",
            "Drama"});
            this.cboxcategoria.Location = new System.Drawing.Point(422, 192);
            this.cboxcategoria.Name = "cboxcategoria";
            this.cboxcategoria.Size = new System.Drawing.Size(121, 23);
            this.cboxcategoria.TabIndex = 5;
            // 
            // txtestreia
            // 
            this.txtestreia.Location = new System.Drawing.Point(158, 192);
            this.txtestreia.Name = "txtestreia";
            this.txtestreia.Size = new System.Drawing.Size(100, 23);
            this.txtestreia.TabIndex = 6;
            // 
            // txboxfilme
            // 
            this.txboxfilme.Location = new System.Drawing.Point(158, 131);
            this.txboxfilme.Name = "txboxfilme";
            this.txboxfilme.Size = new System.Drawing.Size(429, 23);
            this.txboxfilme.TabIndex = 7;
            // 
            // txboxduracao
            // 
            this.txboxduracao.Location = new System.Drawing.Point(158, 266);
            this.txboxduracao.Name = "txboxduracao";
            this.txboxduracao.Size = new System.Drawing.Size(100, 23);
            this.txboxduracao.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(422, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "REGISTRAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TelaCadastroFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1005, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txboxduracao);
            this.Controls.Add(this.txboxfilme);
            this.Controls.Add(this.txtestreia);
            this.Controls.Add(this.cboxcategoria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "TelaCadastroFilme";
            this.ShowIcon = false;
            this.Text = "Sistema de Catálofo de Filmes - SCF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cboxcategoria;
        private TextBox txtestreia;
        private TextBox txboxfilme;
        private TextBox txboxduracao;
        private Button button1;
    }
}