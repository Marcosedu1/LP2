namespace PTesteMetodos
{
    partial class frmExercicio3
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
            this.lblPalavra1 = new System.Windows.Forms.Label();
            this.lblPalavra2 = new System.Windows.Forms.Label();
            this.btnRemoveOcorrencia = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnReverte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPalavra1.Location = new System.Drawing.Point(153, 115);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(336, 41);
            this.txtPalavra1.TabIndex = 0;
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPalavra2.Location = new System.Drawing.Point(153, 182);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(336, 41);
            this.txtPalavra2.TabIndex = 1;
            // 
            // lblPalavra1
            // 
            this.lblPalavra1.AutoSize = true;
            this.lblPalavra1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPalavra1.Location = new System.Drawing.Point(33, 118);
            this.lblPalavra1.Name = "lblPalavra1";
            this.lblPalavra1.Size = new System.Drawing.Size(114, 35);
            this.lblPalavra1.TabIndex = 2;
            this.lblPalavra1.Text = "Palavra 1";
            // 
            // lblPalavra2
            // 
            this.lblPalavra2.AutoSize = true;
            this.lblPalavra2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPalavra2.Location = new System.Drawing.Point(33, 185);
            this.lblPalavra2.Name = "lblPalavra2";
            this.lblPalavra2.Size = new System.Drawing.Size(114, 35);
            this.lblPalavra2.TabIndex = 3;
            this.lblPalavra2.Text = "Palavra 2";
            // 
            // btnRemoveOcorrencia
            // 
            this.btnRemoveOcorrencia.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveOcorrencia.Location = new System.Drawing.Point(107, 370);
            this.btnRemoveOcorrencia.Name = "btnRemoveOcorrencia";
            this.btnRemoveOcorrencia.Size = new System.Drawing.Size(254, 87);
            this.btnRemoveOcorrencia.TabIndex = 4;
            this.btnRemoveOcorrencia.Text = "Remove Ocorrência";
            this.btnRemoveOcorrencia.UseVisualStyleBackColor = true;
            this.btnRemoveOcorrencia.Click += new System.EventHandler(this.btnRemoveOcorrencia_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReplace.Location = new System.Drawing.Point(379, 370);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(254, 87);
            this.btnReplace.TabIndex = 5;
            this.btnReplace.Text = "Remove Ocorrência (replace)";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnReverte
            // 
            this.btnReverte.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReverte.Location = new System.Drawing.Point(654, 370);
            this.btnReverte.Name = "btnReverte";
            this.btnReverte.Size = new System.Drawing.Size(254, 87);
            this.btnReverte.TabIndex = 6;
            this.btnReverte.Text = "Inverte (Reverse)";
            this.btnReverte.UseVisualStyleBackColor = true;
            this.btnReverte.Click += new System.EventHandler(this.btnReverte_Click);
            // 
            // frmExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 589);
            this.Controls.Add(this.btnReverte);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnRemoveOcorrencia);
            this.Controls.Add(this.lblPalavra2);
            this.Controls.Add(this.lblPalavra1);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.txtPalavra1);
            this.Name = "frmExercicio3";
            this.Text = "\'";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtPalavra1;
        private TextBox txtPalavra2;
        private Label lblPalavra1;
        private Label lblPalavra2;
        private Button btnRemoveOcorrencia;
        private Button btnReplace;
        private Button btnReverte;
    }
}