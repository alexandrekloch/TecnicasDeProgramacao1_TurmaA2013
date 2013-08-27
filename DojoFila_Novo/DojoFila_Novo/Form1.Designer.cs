namespace DojoFila_Novo
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMandaFim = new System.Windows.Forms.Button();
            this.btnInsereFim = new System.Windows.Forms.Button();
            this.lstFila = new System.Windows.Forms.ListBox();
            this.txtNovoNome = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAleatorio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMandaFim
            // 
            this.btnMandaFim.Location = new System.Drawing.Point(241, 12);
            this.btnMandaFim.Name = "btnMandaFim";
            this.btnMandaFim.Size = new System.Drawing.Size(125, 23);
            this.btnMandaFim.TabIndex = 0;
            this.btnMandaFim.Text = "Manda para o Fim";
            this.btnMandaFim.UseVisualStyleBackColor = true;
            this.btnMandaFim.Click += new System.EventHandler(this.btnMandaFim_Click);
            // 
            // btnInsereFim
            // 
            this.btnInsereFim.Location = new System.Drawing.Point(241, 344);
            this.btnInsereFim.Name = "btnInsereFim";
            this.btnInsereFim.Size = new System.Drawing.Size(125, 23);
            this.btnInsereFim.TabIndex = 1;
            this.btnInsereFim.Text = "Insere no fim da fila";
            this.btnInsereFim.UseVisualStyleBackColor = true;
            this.btnInsereFim.Click += new System.EventHandler(this.btnInsereFim_Click);
            // 
            // lstFila
            // 
            this.lstFila.FormattingEnabled = true;
            this.lstFila.Location = new System.Drawing.Point(12, 12);
            this.lstFila.Name = "lstFila";
            this.lstFila.Size = new System.Drawing.Size(223, 355);
            this.lstFila.TabIndex = 2;
            // 
            // txtNovoNome
            // 
            this.txtNovoNome.Location = new System.Drawing.Point(242, 318);
            this.txtNovoNome.Name = "txtNovoNome";
            this.txtNovoNome.Size = new System.Drawing.Size(124, 20);
            this.txtNovoNome.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAleatorio
            // 
            this.btnAleatorio.Location = new System.Drawing.Point(242, 70);
            this.btnAleatorio.Name = "btnAleatorio";
            this.btnAleatorio.Size = new System.Drawing.Size(124, 61);
            this.btnAleatorio.TabIndex = 5;
            this.btnAleatorio.Text = "Número Aleatório";
            this.btnAleatorio.UseVisualStyleBackColor = true;
            this.btnAleatorio.Click += new System.EventHandler(this.btnAleatorio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 392);
            this.Controls.Add(this.btnAleatorio);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNovoNome);
            this.Controls.Add(this.lstFila);
            this.Controls.Add(this.btnInsereFim);
            this.Controls.Add(this.btnMandaFim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMandaFim;
        private System.Windows.Forms.Button btnInsereFim;
        private System.Windows.Forms.ListBox lstFila;
        private System.Windows.Forms.TextBox txtNovoNome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAleatorio;
    }
}

