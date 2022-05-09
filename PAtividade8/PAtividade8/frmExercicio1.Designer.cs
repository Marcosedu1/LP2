namespace PAtividade8
{
    partial class frmExercicio1
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
            this.txtTexto = new System.Windows.Forms.RichTextBox();
            this.btnContarBranco = new System.Windows.Forms.Button();
            this.btnContarR = new System.Windows.Forms.Button();
            this.btnContarPares = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(225, 158);
            this.txtTexto.MaxLength = 100;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(549, 120);
            this.txtTexto.TabIndex = 0;
            this.txtTexto.Text = "";
            // 
            // btnContarBranco
            // 
            this.btnContarBranco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnContarBranco.Location = new System.Drawing.Point(78, 409);
            this.btnContarBranco.Name = "btnContarBranco";
            this.btnContarBranco.Size = new System.Drawing.Size(253, 129);
            this.btnContarBranco.TabIndex = 1;
            this.btnContarBranco.Text = "Contar espaços em branco";
            this.btnContarBranco.UseVisualStyleBackColor = true;
            this.btnContarBranco.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnContarR
            // 
            this.btnContarR.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnContarR.Location = new System.Drawing.Point(391, 409);
            this.btnContarR.Name = "btnContarR";
            this.btnContarR.Size = new System.Drawing.Size(253, 129);
            this.btnContarR.TabIndex = 2;
            this.btnContarR.Text = "Contar letras \"R\"";
            this.btnContarR.UseVisualStyleBackColor = true;
            this.btnContarR.Click += new System.EventHandler(this.btnContarR_Click);
            // 
            // btnContarPares
            // 
            this.btnContarPares.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnContarPares.Location = new System.Drawing.Point(702, 409);
            this.btnContarPares.Name = "btnContarPares";
            this.btnContarPares.Size = new System.Drawing.Size(253, 129);
            this.btnContarPares.TabIndex = 3;
            this.btnContarPares.Text = "Contar pares de letras";
            this.btnContarPares.UseVisualStyleBackColor = true;
            this.btnContarPares.Click += new System.EventHandler(this.btnContarPares_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(859, 30);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(128, 47);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(237, 331);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 28);
            this.lblResultado.TabIndex = 5;
            // 
            // frmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 618);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnContarPares);
            this.Controls.Add(this.btnContarR);
            this.Controls.Add(this.btnContarBranco);
            this.Controls.Add(this.txtTexto);
            this.Name = "frmExercicio1";
            this.Text = "frmExercicio1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox txtTexto;
        private Button btnContarBranco;
        private Button btnContarR;
        private Button btnContarPares;
        private Button btnFechar;
        private Label lblResultado;
    }
}