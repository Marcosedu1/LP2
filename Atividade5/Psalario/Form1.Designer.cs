namespace Psalario
{
    partial class Atividade5
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSalBruto = new System.Windows.Forms.Label();
            this.lblFilhos = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.mskbxSalBruto = new System.Windows.Forms.MaskedTextBox();
            this.cbxNumFilhos = new System.Windows.Forms.ComboBox();
            this.btnVerifica = new System.Windows.Forms.Button();
            this.grpbxSexo = new System.Windows.Forms.GroupBox();
            this.rbtnMas = new System.Windows.Forms.RadioButton();
            this.rbtnFem = new System.Windows.Forms.RadioButton();
            this.pnlCasado = new System.Windows.Forms.Panel();
            this.ckbxCasado = new System.Windows.Forms.CheckBox();
            this.lblnss = new System.Windows.Forms.Label();
            this.lblIrpf = new System.Windows.Forms.Label();
            this.lblSalFam = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDescInss = new System.Windows.Forms.Label();
            this.lblDescIrpf = new System.Windows.Forms.Label();
            this.txtDescInss = new System.Windows.Forms.TextBox();
            this.txtDescIrpf = new System.Windows.Forms.TextBox();
            this.txtInss = new System.Windows.Forms.TextBox();
            this.txtIrpf = new System.Windows.Forms.TextBox();
            this.txtSalFamilia = new System.Windows.Forms.TextBox();
            this.txtSalLiquido = new System.Windows.Forms.TextBox();
            this.lblDados = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.grpbxSexo.SuspendLayout();
            this.pnlCasado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNome.Location = new System.Drawing.Point(81, 85);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(140, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome funcionário";
            // 
            // lblSalBruto
            // 
            this.lblSalBruto.AutoSize = true;
            this.lblSalBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSalBruto.Location = new System.Drawing.Point(81, 156);
            this.lblSalBruto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalBruto.Name = "lblSalBruto";
            this.lblSalBruto.Size = new System.Drawing.Size(107, 20);
            this.lblSalBruto.TabIndex = 1;
            this.lblSalBruto.Text = "Salario Bruto";
            // 
            // lblFilhos
            // 
            this.lblFilhos.AutoSize = true;
            this.lblFilhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFilhos.Location = new System.Drawing.Point(81, 228);
            this.lblFilhos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilhos.Name = "lblFilhos";
            this.lblFilhos.Size = new System.Drawing.Size(136, 20);
            this.lblFilhos.TabIndex = 2;
            this.lblFilhos.Text = "Número de filhos";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNome.Location = new System.Drawing.Point(260, 81);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(151, 26);
            this.txtNome.TabIndex = 1;
            this.txtNome.Validated += new System.EventHandler(this.txtNome_Validated);
            // 
            // mskbxSalBruto
            // 
            this.mskbxSalBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mskbxSalBruto.Location = new System.Drawing.Point(260, 153);
            this.mskbxSalBruto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mskbxSalBruto.Mask = "99999.00";
            this.mskbxSalBruto.Name = "mskbxSalBruto";
            this.mskbxSalBruto.Size = new System.Drawing.Size(151, 26);
            this.mskbxSalBruto.TabIndex = 2;
            this.mskbxSalBruto.Validated += new System.EventHandler(this.mskbxSalBruto_Validated);
            // 
            // cbxNumFilhos
            // 
            this.cbxNumFilhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbxNumFilhos.FormattingEnabled = true;
            this.cbxNumFilhos.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cbxNumFilhos.Location = new System.Drawing.Point(260, 224);
            this.cbxNumFilhos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxNumFilhos.Name = "cbxNumFilhos";
            this.cbxNumFilhos.Size = new System.Drawing.Size(151, 28);
            this.cbxNumFilhos.TabIndex = 3;
            this.cbxNumFilhos.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnVerifica
            // 
            this.btnVerifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnVerifica.Location = new System.Drawing.Point(176, 286);
            this.btnVerifica.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVerifica.Name = "btnVerifica";
            this.btnVerifica.Size = new System.Drawing.Size(303, 58);
            this.btnVerifica.TabIndex = 4;
            this.btnVerifica.Text = "Verificar Desconto";
            this.btnVerifica.UseVisualStyleBackColor = true;
            this.btnVerifica.Click += new System.EventHandler(this.btnVerifica_Click);
            // 
            // grpbxSexo
            // 
            this.grpbxSexo.Controls.Add(this.rbtnMas);
            this.grpbxSexo.Controls.Add(this.rbtnFem);
            this.grpbxSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grpbxSexo.Location = new System.Drawing.Point(629, 48);
            this.grpbxSexo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpbxSexo.Name = "grpbxSexo";
            this.grpbxSexo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpbxSexo.Size = new System.Drawing.Size(309, 194);
            this.grpbxSexo.TabIndex = 7;
            this.grpbxSexo.TabStop = false;
            this.grpbxSexo.Text = "Sexo";
            // 
            // rbtnMas
            // 
            this.rbtnMas.AutoSize = true;
            this.rbtnMas.Location = new System.Drawing.Point(95, 112);
            this.rbtnMas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnMas.Name = "rbtnMas";
            this.rbtnMas.Size = new System.Drawing.Size(106, 24);
            this.rbtnMas.TabIndex = 1;
            this.rbtnMas.Text = "Masculino";
            this.rbtnMas.UseVisualStyleBackColor = true;
            // 
            // rbtnFem
            // 
            this.rbtnFem.AutoSize = true;
            this.rbtnFem.Checked = true;
            this.rbtnFem.Location = new System.Drawing.Point(95, 60);
            this.rbtnFem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnFem.Name = "rbtnFem";
            this.rbtnFem.Size = new System.Drawing.Size(98, 24);
            this.rbtnFem.TabIndex = 0;
            this.rbtnFem.TabStop = true;
            this.rbtnFem.Text = "Feminino";
            this.rbtnFem.UseVisualStyleBackColor = true;
            this.rbtnFem.CheckedChanged += new System.EventHandler(this.rbtnFem_CheckedChanged);
            // 
            // pnlCasado
            // 
            this.pnlCasado.Controls.Add(this.ckbxCasado);
            this.pnlCasado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pnlCasado.Location = new System.Drawing.Point(629, 250);
            this.pnlCasado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlCasado.Name = "pnlCasado";
            this.pnlCasado.Size = new System.Drawing.Size(308, 132);
            this.pnlCasado.TabIndex = 8;
            // 
            // ckbxCasado
            // 
            this.ckbxCasado.AutoSize = true;
            this.ckbxCasado.Location = new System.Drawing.Point(101, 57);
            this.ckbxCasado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbxCasado.Name = "ckbxCasado";
            this.ckbxCasado.Size = new System.Drawing.Size(88, 24);
            this.ckbxCasado.TabIndex = 0;
            this.ckbxCasado.Text = "Casado";
            this.ckbxCasado.UseVisualStyleBackColor = true;
            // 
            // lblnss
            // 
            this.lblnss.AutoSize = true;
            this.lblnss.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblnss.Location = new System.Drawing.Point(81, 428);
            this.lblnss.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnss.Name = "lblnss";
            this.lblnss.Size = new System.Drawing.Size(112, 20);
            this.lblnss.TabIndex = 9;
            this.lblnss.Text = "Aliquota INSS";
            // 
            // lblIrpf
            // 
            this.lblIrpf.AutoSize = true;
            this.lblIrpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblIrpf.Location = new System.Drawing.Point(81, 497);
            this.lblIrpf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIrpf.Name = "lblIrpf";
            this.lblIrpf.Size = new System.Drawing.Size(111, 20);
            this.lblIrpf.TabIndex = 10;
            this.lblIrpf.Text = "Aliquota IRPF";
            // 
            // lblSalFam
            // 
            this.lblSalFam.AutoSize = true;
            this.lblSalFam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSalFam.Location = new System.Drawing.Point(81, 567);
            this.lblSalFam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalFam.Name = "lblSalFam";
            this.lblSalFam.Size = new System.Drawing.Size(120, 20);
            this.lblSalFam.TabIndex = 11;
            this.lblSalFam.Text = "Salário Familia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(81, 639);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Salário Liquido";
            // 
            // lblDescInss
            // 
            this.lblDescInss.AutoSize = true;
            this.lblDescInss.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDescInss.Location = new System.Drawing.Point(588, 428);
            this.lblDescInss.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescInss.Name = "lblDescInss";
            this.lblDescInss.Size = new System.Drawing.Size(124, 20);
            this.lblDescInss.TabIndex = 13;
            this.lblDescInss.Text = "Desconto INSS";
            this.lblDescInss.Click += new System.EventHandler(this.lblDescInss_Click);
            // 
            // lblDescIrpf
            // 
            this.lblDescIrpf.AutoSize = true;
            this.lblDescIrpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDescIrpf.Location = new System.Drawing.Point(589, 494);
            this.lblDescIrpf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescIrpf.Name = "lblDescIrpf";
            this.lblDescIrpf.Size = new System.Drawing.Size(123, 20);
            this.lblDescIrpf.TabIndex = 14;
            this.lblDescIrpf.Text = "Desconto IRPF";
            this.lblDescIrpf.Click += new System.EventHandler(this.lblDescIrpf_Click);
            // 
            // txtDescInss
            // 
            this.txtDescInss.Enabled = false;
            this.txtDescInss.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDescInss.Location = new System.Drawing.Point(733, 425);
            this.txtDescInss.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescInss.Name = "txtDescInss";
            this.txtDescInss.Size = new System.Drawing.Size(152, 26);
            this.txtDescInss.TabIndex = 15;
            this.txtDescInss.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtDescIrpf
            // 
            this.txtDescIrpf.Enabled = false;
            this.txtDescIrpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDescIrpf.Location = new System.Drawing.Point(733, 494);
            this.txtDescIrpf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescIrpf.Name = "txtDescIrpf";
            this.txtDescIrpf.Size = new System.Drawing.Size(152, 26);
            this.txtDescIrpf.TabIndex = 16;
            this.txtDescIrpf.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtInss
            // 
            this.txtInss.Enabled = false;
            this.txtInss.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtInss.Location = new System.Drawing.Point(259, 425);
            this.txtInss.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInss.Name = "txtInss";
            this.txtInss.Size = new System.Drawing.Size(152, 26);
            this.txtInss.TabIndex = 17;
            this.txtInss.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtIrpf
            // 
            this.txtIrpf.Enabled = false;
            this.txtIrpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtIrpf.Location = new System.Drawing.Point(260, 494);
            this.txtIrpf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIrpf.Name = "txtIrpf";
            this.txtIrpf.Size = new System.Drawing.Size(152, 26);
            this.txtIrpf.TabIndex = 18;
            this.txtIrpf.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtSalFamilia
            // 
            this.txtSalFamilia.Enabled = false;
            this.txtSalFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSalFamilia.Location = new System.Drawing.Point(260, 564);
            this.txtSalFamilia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSalFamilia.Name = "txtSalFamilia";
            this.txtSalFamilia.Size = new System.Drawing.Size(152, 26);
            this.txtSalFamilia.TabIndex = 19;
            this.txtSalFamilia.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txtSalLiquido
            // 
            this.txtSalLiquido.Enabled = false;
            this.txtSalLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSalLiquido.Location = new System.Drawing.Point(259, 635);
            this.txtSalLiquido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSalLiquido.Name = "txtSalLiquido";
            this.txtSalLiquido.Size = new System.Drawing.Size(152, 26);
            this.txtSalLiquido.TabIndex = 20;
            this.txtSalLiquido.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDados.Location = new System.Drawing.Point(81, 366);
            this.lblDados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(58, 20);
            this.lblDados.TabIndex = 21;
            this.lblDados.Text = "Dados";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(720, 567);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(217, 42);
            this.btnLimpar.TabIndex = 22;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(720, 628);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(217, 42);
            this.btnSair.TabIndex = 23;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Atividade5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 697);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblDados);
            this.Controls.Add(this.txtSalLiquido);
            this.Controls.Add(this.txtSalFamilia);
            this.Controls.Add(this.txtIrpf);
            this.Controls.Add(this.txtInss);
            this.Controls.Add(this.txtDescIrpf);
            this.Controls.Add(this.txtDescInss);
            this.Controls.Add(this.lblDescIrpf);
            this.Controls.Add(this.lblDescInss);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblSalFam);
            this.Controls.Add(this.lblIrpf);
            this.Controls.Add(this.lblnss);
            this.Controls.Add(this.pnlCasado);
            this.Controls.Add(this.grpbxSexo);
            this.Controls.Add(this.btnVerifica);
            this.Controls.Add(this.cbxNumFilhos);
            this.Controls.Add(this.mskbxSalBruto);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblFilhos);
            this.Controls.Add(this.lblSalBruto);
            this.Controls.Add(this.lblNome);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Atividade5";
            this.Text = "Verificar Desconto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpbxSexo.ResumeLayout(false);
            this.grpbxSexo.PerformLayout();
            this.pnlCasado.ResumeLayout(false);
            this.pnlCasado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalBruto;
        private System.Windows.Forms.Label lblFilhos;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox mskbxSalBruto;
        private System.Windows.Forms.ComboBox cbxNumFilhos;
        private System.Windows.Forms.Button btnVerifica;
        private System.Windows.Forms.GroupBox grpbxSexo;
        private System.Windows.Forms.RadioButton rbtnMas;
        private System.Windows.Forms.RadioButton rbtnFem;
        private System.Windows.Forms.Panel pnlCasado;
        private System.Windows.Forms.CheckBox ckbxCasado;
        private System.Windows.Forms.Label lblnss;
        private System.Windows.Forms.Label lblIrpf;
        private System.Windows.Forms.Label lblSalFam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDescInss;
        private System.Windows.Forms.Label lblDescIrpf;
        private System.Windows.Forms.TextBox txtDescInss;
        private System.Windows.Forms.TextBox txtDescIrpf;
        private System.Windows.Forms.TextBox txtInss;
        private System.Windows.Forms.TextBox txtIrpf;
        private System.Windows.Forms.TextBox txtSalFamilia;
        private System.Windows.Forms.TextBox txtSalLiquido;
        private System.Windows.Forms.Label lblDados;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

