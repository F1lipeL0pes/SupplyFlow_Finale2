namespace SupplyFlow
{
    partial class frmRelatoriosEst
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblTela = new System.Windows.Forms.Label();
            this.btnRelatorioNome = new System.Windows.Forms.Button();
            this.btnRelatorioCat = new System.Windows.Forms.Button();
            this.btnRelatorioG = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Controls.Add(this.lblTela);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 54);
            this.panel1.TabIndex = 16;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Teal;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoltar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVoltar.Location = new System.Drawing.Point(537, 0);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(148, 54);
            this.btnVoltar.TabIndex = 12;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblTela
            // 
            this.lblTela.AutoSize = true;
            this.lblTela.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTela.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTela.Location = new System.Drawing.Point(3, 15);
            this.lblTela.Name = "lblTela";
            this.lblTela.Size = new System.Drawing.Size(233, 24);
            this.lblTela.TabIndex = 2;
            this.lblTela.Text = "Relatórios de Estoque";
            // 
            // btnRelatorioNome
            // 
            this.btnRelatorioNome.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRelatorioNome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelatorioNome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRelatorioNome.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorioNome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRelatorioNome.Location = new System.Drawing.Point(211, 106);
            this.btnRelatorioNome.Name = "btnRelatorioNome";
            this.btnRelatorioNome.Size = new System.Drawing.Size(256, 46);
            this.btnRelatorioNome.TabIndex = 17;
            this.btnRelatorioNome.Text = "Relatório por Nome";
            this.btnRelatorioNome.UseVisualStyleBackColor = false;
            this.btnRelatorioNome.Click += new System.EventHandler(this.btnRelatorioNome_Click);
            // 
            // btnRelatorioCat
            // 
            this.btnRelatorioCat.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRelatorioCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelatorioCat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRelatorioCat.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorioCat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRelatorioCat.Location = new System.Drawing.Point(211, 205);
            this.btnRelatorioCat.Name = "btnRelatorioCat";
            this.btnRelatorioCat.Size = new System.Drawing.Size(256, 46);
            this.btnRelatorioCat.TabIndex = 18;
            this.btnRelatorioCat.Text = "Relatório por Categoria";
            this.btnRelatorioCat.UseVisualStyleBackColor = false;
            this.btnRelatorioCat.Click += new System.EventHandler(this.btnRelatorioCat_Click);
            // 
            // btnRelatorioG
            // 
            this.btnRelatorioG.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRelatorioG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelatorioG.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRelatorioG.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorioG.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRelatorioG.Location = new System.Drawing.Point(211, 301);
            this.btnRelatorioG.Name = "btnRelatorioG";
            this.btnRelatorioG.Size = new System.Drawing.Size(256, 46);
            this.btnRelatorioG.TabIndex = 19;
            this.btnRelatorioG.Text = "Relatório Geral";
            this.btnRelatorioG.UseVisualStyleBackColor = false;
            this.btnRelatorioG.Click += new System.EventHandler(this.btnRelatorioG_Click);
            // 
            // frmRelatoriosEst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.ControlBox = false;
            this.Controls.Add(this.btnRelatorioG);
            this.Controls.Add(this.btnRelatorioCat);
            this.Controls.Add(this.btnRelatorioNome);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmRelatoriosEst";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatórios de Estoque";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblTela;
        private System.Windows.Forms.Button btnRelatorioNome;
        private System.Windows.Forms.Button btnRelatorioCat;
        private System.Windows.Forms.Button btnRelatorioG;
    }
}