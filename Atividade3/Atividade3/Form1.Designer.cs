namespace Atividade3
{
    partial class Calcular_IMC
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtIMC = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblImc = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtObes = new System.Windows.Forms.TextBox();
            this.mskbxAlt = new System.Windows.Forms.MaskedTextBox();
            this.mskbxPeso = new System.Windows.Forms.MaskedTextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Palatino Linotype", 20F);
            this.btnCalcular.Location = new System.Drawing.Point(584, 137);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(211, 81);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular IMC";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtIMC
            // 
            this.txtIMC.Enabled = false;
            this.txtIMC.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIMC.Location = new System.Drawing.Point(476, 335);
            this.txtIMC.Name = "txtIMC";
            this.txtIMC.Size = new System.Drawing.Size(138, 34);
            this.txtIMC.TabIndex = 3;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(213, 126);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(71, 27);
            this.lblAltura.TabIndex = 4;
            this.lblAltura.Text = "Altura";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(213, 200);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(53, 27);
            this.lblPeso.TabIndex = 5;
            this.lblPeso.Text = "Peso";
            // 
            // lblImc
            // 
            this.lblImc.AutoSize = true;
            this.lblImc.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImc.Location = new System.Drawing.Point(290, 338);
            this.lblImc.Name = "lblImc";
            this.lblImc.Size = new System.Drawing.Size(52, 27);
            this.lblImc.TabIndex = 6;
            this.lblImc.Text = "IMC";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(290, 388);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(127, 27);
            this.lblClass.TabIndex = 8;
            this.lblClass.Text = "Classificação";
            // 
            // txtClass
            // 
            this.txtClass.Enabled = false;
            this.txtClass.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClass.Location = new System.Drawing.Point(476, 385);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(138, 34);
            this.txtClass.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(290, 445);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "Obesidade(Grau)";
            // 
            // txtObes
            // 
            this.txtObes.Enabled = false;
            this.txtObes.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObes.Location = new System.Drawing.Point(476, 442);
            this.txtObes.Name = "txtObes";
            this.txtObes.Size = new System.Drawing.Size(138, 34);
            this.txtObes.TabIndex = 5;
            // 
            // mskbxAlt
            // 
            this.mskbxAlt.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxAlt.Location = new System.Drawing.Point(327, 123);
            this.mskbxAlt.Mask = "0.00";
            this.mskbxAlt.Name = "mskbxAlt";
            this.mskbxAlt.Size = new System.Drawing.Size(138, 34);
            this.mskbxAlt.TabIndex = 1;
            this.mskbxAlt.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            this.mskbxAlt.Validated += new System.EventHandler(this.mskbxAlt_Validated);
            // 
            // mskbxPeso
            // 
            this.mskbxPeso.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxPeso.Location = new System.Drawing.Point(327, 197);
            this.mskbxPeso.Mask = "900.00";
            this.mskbxPeso.Name = "mskbxPeso";
            this.mskbxPeso.Size = new System.Drawing.Size(138, 34);
            this.mskbxPeso.TabIndex = 2;
            this.mskbxPeso.Validated += new System.EventHandler(this.mskbxPeso_Validated);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(734, 496);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(157, 48);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Palatino Linotype", 20F);
            this.lblTitulo.Location = new System.Drawing.Point(362, 38);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(176, 36);
            this.lblTitulo.TabIndex = 12;
            this.lblTitulo.Text = "Calcular IMC";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(734, 388);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(157, 48);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Calcular_IMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Atividade3.Properties.Resources._1814a5d9fc59a86b50b1fdbfa412287f;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(917, 565);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.mskbxPeso);
            this.Controls.Add(this.mskbxAlt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtObes);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.lblImc);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.txtIMC);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Calcular_IMC";
            this.Text = "Calcular IMC";
            this.Load += new System.EventHandler(this.Calcular_IMC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtIMC;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblImc;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtObes;
        private System.Windows.Forms.MaskedTextBox mskbxAlt;
        private System.Windows.Forms.MaskedTextBox mskbxPeso;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnLimpar;
    }
}

