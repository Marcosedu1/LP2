namespace PTesteMetodos
{
    partial class frmExercicio4
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
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.btnContarNum = new System.Windows.Forms.Button();
            this.btnLocalizarEspaco = new System.Windows.Forms.Button();
            this.ContarLetras = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(122, 67);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(753, 257);
            this.txtTexto.TabIndex = 0;
            this.txtTexto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnContarNum
            // 
            this.btnContarNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnContarNum.Location = new System.Drawing.Point(95, 433);
            this.btnContarNum.Name = "btnContarNum";
            this.btnContarNum.Size = new System.Drawing.Size(234, 73);
            this.btnContarNum.TabIndex = 1;
            this.btnContarNum.Text = "Contar caracteres numéricos";
            this.btnContarNum.UseVisualStyleBackColor = true;
            this.btnContarNum.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLocalizarEspaco
            // 
            this.btnLocalizarEspaco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLocalizarEspaco.Location = new System.Drawing.Point(379, 433);
            this.btnLocalizarEspaco.Name = "btnLocalizarEspaco";
            this.btnLocalizarEspaco.Size = new System.Drawing.Size(234, 73);
            this.btnLocalizarEspaco.TabIndex = 2;
            this.btnLocalizarEspaco.Text = "Localizar o primeiro espaço em branco";
            this.btnLocalizarEspaco.UseVisualStyleBackColor = true;
            this.btnLocalizarEspaco.Click += new System.EventHandler(this.button2_Click);
            // 
            // ContarLetras
            // 
            this.ContarLetras.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ContarLetras.Location = new System.Drawing.Point(659, 433);
            this.ContarLetras.Name = "ContarLetras";
            this.ContarLetras.Size = new System.Drawing.Size(234, 73);
            this.ContarLetras.TabIndex = 3;
            this.ContarLetras.Text = "Contar caracteres alfabéticos";
            this.ContarLetras.UseVisualStyleBackColor = true;
            this.ContarLetras.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(122, 356);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(124, 35);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Resultado";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 603);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.ContarLetras);
            this.Controls.Add(this.btnLocalizarEspaco);
            this.Controls.Add(this.btnContarNum);
            this.Controls.Add(this.txtTexto);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtTexto;
        private Button btnContarNum;
        private Button btnLocalizarEspaco;
        private Button ContarLetras;
        private Label lblResultado;
    }
}