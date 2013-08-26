namespace CalculoDeImc
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radMasculino = new System.Windows.Forms.RadioButton();
            this.radFeminino = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudAltura = new System.Windows.Forms.NumericUpDown();
            this.nudPeso = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblValorImc = new System.Windows.Forms.Label();
            this.lblObsImc = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAltura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeso)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radFeminino);
            this.groupBox1.Controls.Add(this.radMasculino);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // radMasculino
            // 
            this.radMasculino.AutoSize = true;
            this.radMasculino.Location = new System.Drawing.Point(41, 28);
            this.radMasculino.Name = "radMasculino";
            this.radMasculino.Size = new System.Drawing.Size(73, 17);
            this.radMasculino.TabIndex = 0;
            this.radMasculino.TabStop = true;
            this.radMasculino.Text = "Masculino";
            this.radMasculino.UseVisualStyleBackColor = true;
            this.radMasculino.CheckedChanged += new System.EventHandler(this.radMasculino_CheckedChanged);
            // 
            // radFeminino
            // 
            this.radFeminino.AutoSize = true;
            this.radFeminino.Location = new System.Drawing.Point(186, 28);
            this.radFeminino.Name = "radFeminino";
            this.radFeminino.Size = new System.Drawing.Size(67, 17);
            this.radFeminino.TabIndex = 1;
            this.radFeminino.TabStop = true;
            this.radFeminino.Text = "Feminino";
            this.radFeminino.UseVisualStyleBackColor = true;
            this.radFeminino.CheckedChanged += new System.EventHandler(this.radFeminino_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.nudPeso);
            this.groupBox2.Controls.Add(this.nudAltura);
            this.groupBox2.Location = new System.Drawing.Point(13, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 82);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Medidas";
            // 
            // nudAltura
            // 
            this.nudAltura.DecimalPlaces = 2;
            this.nudAltura.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudAltura.Location = new System.Drawing.Point(58, 42);
            this.nudAltura.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            65536});
            this.nudAltura.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAltura.Name = "nudAltura";
            this.nudAltura.Size = new System.Drawing.Size(56, 20);
            this.nudAltura.TabIndex = 0;
            this.nudAltura.Value = new decimal(new int[] {
            150,
            0,
            0,
            131072});
            this.nudAltura.ValueChanged += new System.EventHandler(this.nudAltura_ValueChanged);
            // 
            // nudPeso
            // 
            this.nudPeso.DecimalPlaces = 1;
            this.nudPeso.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudPeso.Location = new System.Drawing.Point(197, 42);
            this.nudPeso.Name = "nudPeso";
            this.nudPeso.Size = new System.Drawing.Size(56, 20);
            this.nudPeso.TabIndex = 1;
            this.nudPeso.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudPeso.ValueChanged += new System.EventHandler(this.nudPeso_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Altura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Peso";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblObsImc);
            this.groupBox3.Controls.Add(this.lblValorImc);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(13, 172);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(306, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Índice de Massa Corporal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Observação";
            // 
            // lblValorImc
            // 
            this.lblValorImc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblValorImc.Location = new System.Drawing.Point(103, 36);
            this.lblValorImc.Name = "lblValorImc";
            this.lblValorImc.Size = new System.Drawing.Size(150, 20);
            this.lblValorImc.TabIndex = 5;
            this.lblValorImc.Text = "22,2";
            // 
            // lblObsImc
            // 
            this.lblObsImc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblObsImc.Location = new System.Drawing.Point(103, 66);
            this.lblObsImc.Name = "lblObsImc";
            this.lblObsImc.Size = new System.Drawing.Size(150, 20);
            this.lblObsImc.TabIndex = 6;
            this.lblObsImc.Text = "Peso Normal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 291);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Calculo de IMC";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAltura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeso)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radFeminino;
        private System.Windows.Forms.RadioButton radMasculino;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudPeso;
        private System.Windows.Forms.NumericUpDown nudAltura;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblObsImc;
        private System.Windows.Forms.Label lblValorImc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

