namespace PTesteMetodos
{
    partial class frmExercicio2
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
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.btnCompara = new System.Windows.Forms.Button();
            this.btnInserir1 = new System.Windows.Forms.Button();
            this.btnInserir2 = new System.Windows.Forms.Button();
            this.lblPalavra1 = new System.Windows.Forms.Label();
            this.lblPalavra2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPalavra1.Location = new System.Drawing.Point(189, 73);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(150, 32);
            this.txtPalavra1.TabIndex = 0;
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPalavra2.Location = new System.Drawing.Point(189, 150);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(150, 32);
            this.txtPalavra2.TabIndex = 1;
            // 
            // btnCompara
            // 
            this.btnCompara.Location = new System.Drawing.Point(158, 314);
            this.btnCompara.Name = "btnCompara";
            this.btnCompara.Size = new System.Drawing.Size(156, 54);
            this.btnCompara.TabIndex = 2;
            this.btnCompara.Text = "Comparar";
            this.btnCompara.UseVisualStyleBackColor = true;
            this.btnCompara.Click += new System.EventHandler(this.btnCompara_Click);
            // 
            // btnInserir1
            // 
            this.btnInserir1.Location = new System.Drawing.Point(332, 314);
            this.btnInserir1.Name = "btnInserir1";
            this.btnInserir1.Size = new System.Drawing.Size(156, 54);
            this.btnInserir1.TabIndex = 3;
            this.btnInserir1.Text = "Inserir Texto 1 no Texto 2";
            this.btnInserir1.UseVisualStyleBackColor = true;
            this.btnInserir1.Click += new System.EventHandler(this.btnInserir1_Click);
            // 
            // btnInserir2
            // 
            this.btnInserir2.Location = new System.Drawing.Point(506, 314);
            this.btnInserir2.Name = "btnInserir2";
            this.btnInserir2.Size = new System.Drawing.Size(156, 54);
            this.btnInserir2.TabIndex = 4;
            this.btnInserir2.Text = "Inserir Asterisco";
            this.btnInserir2.UseVisualStyleBackColor = true;
            this.btnInserir2.Click += new System.EventHandler(this.btnInserir2_Click);
            // 
            // lblPalavra1
            // 
            this.lblPalavra1.AutoSize = true;
            this.lblPalavra1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPalavra1.Location = new System.Drawing.Point(93, 76);
            this.lblPalavra1.Name = "lblPalavra1";
            this.lblPalavra1.Size = new System.Drawing.Size(88, 25);
            this.lblPalavra1.TabIndex = 5;
            this.lblPalavra1.Text = "Palavra 1";
            // 
            // lblPalavra2
            // 
            this.lblPalavra2.AutoSize = true;
            this.lblPalavra2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPalavra2.Location = new System.Drawing.Point(93, 153);
            this.lblPalavra2.Name = "lblPalavra2";
            this.lblPalavra2.Size = new System.Drawing.Size(88, 25);
            this.lblPalavra2.TabIndex = 6;
            this.lblPalavra2.Text = "Palavra 2";
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPalavra2);
            this.Controls.Add(this.lblPalavra1);
            this.Controls.Add(this.btnInserir2);
            this.Controls.Add(this.btnInserir1);
            this.Controls.Add(this.btnCompara);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.txtPalavra1);
            this.Name = "frmExercicio2";
            this.Text = "frmExercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtPalavra1;
        private TextBox txtPalavra2;
        private Button btnCompara;
        private Button btnInserir1;
        private Button btnInserir2;
        private Label lblPalavra1;
        private Label lblPalavra2;
    }
}