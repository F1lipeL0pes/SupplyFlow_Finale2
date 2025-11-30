namespace SupplyFlow
{
    partial class frmRelatoriosVenda
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
            this.btnRelatorioG = new System.Windows.Forms.Button();
            this.btnRelatorioGarcom = new System.Windows.Forms.Button();
            this.btnRelatorioData = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblTela = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRelatorioG
            // 
            this.btnRelatorioG.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRelatorioG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelatorioG.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRelatorioG.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorioG.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRelatorioG.Location = new System.Drawing.Point(211, 333);
            this.btnRelatorioG.Name = "btnRelatorioG";
            this.btnRelatorioG.Size = new System.Drawing.Size(256, 46);
            this.btnRelatorioG.TabIndex = 23;
            this.btnRelatorioG.Text = "Relatório Geral";
            this.btnRelatorioG.UseVisualStyleBackColor = false;
            this.btnRelatorioG.Click += new System.EventHandler(this.btnRelatorioG_Click);
            // 
            // btnRelatorioGarcom
            // 
            this.btnRelatorioGarcom.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRelatorioGarcom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelatorioGarcom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRelatorioGarcom.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorioGarcom.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRelatorioGarcom.Location = new System.Drawing.Point(211, 215);
            this.btnRelatorioGarcom.Name = "btnRelatorioGarcom";
            this.btnRelatorioGarcom.Size = new System.Drawing.Size(256, 46);
            this.btnRelatorioGarcom.TabIndex = 22;
            this.btnRelatorioGarcom.Text = "Relatório por Garçom";
            this.btnRelatorioGarcom.UseVisualStyleBackColor = false;
            this.btnRelatorioGarcom.Click += new System.EventHandler(this.btnRelatorioGarcom_Click);
            // 
            // btnRelatorioData
            // 
            this.btnRelatorioData.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRelatorioData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelatorioData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRelatorioData.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorioData.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRelatorioData.Location = new System.Drawing.Point(211, 113);
            this.btnRelatorioData.Name = "btnRelatorioData";
            this.btnRelatorioData.Size = new System.Drawing.Size(256, 46);
            this.btnRelatorioData.TabIndex = 21;
            this.btnRelatorioData.Text = "Relatório por Data";
            this.btnRelatorioData.UseVisualStyleBackColor = false;
            this.btnRelatorioData.Click += new System.EventHandler(this.btnRelatorioData_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Controls.Add(this.lblTela);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 54);
            this.panel1.TabIndex = 20;
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
            this.lblTela.Size = new System.Drawing.Size(211, 24);
            this.lblTela.TabIndex = 2;
            this.lblTela.Text = "Relatórios de Venda";
            // 
            // frmRelatoriosVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.ControlBox = false;
            this.Controls.Add(this.btnRelatorioG);
            this.Controls.Add(this.btnRelatorioGarcom);
            this.Controls.Add(this.btnRelatorioData);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmRelatoriosVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatórios de Venda";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRelatorioG;
        private System.Windows.Forms.Button btnRelatorioGarcom;
        private System.Windows.Forms.Button btnRelatorioData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblTela;
    }
}