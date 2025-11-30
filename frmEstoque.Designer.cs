namespace SupplyFlow
{
    partial class frmEstoque
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
            this.btnSair = new System.Windows.Forms.Button();
            this.lblTela = new System.Windows.Forms.Label();
            this.btnEditarProd = new System.Windows.Forms.Button();
            this.btnRelatórios = new System.Windows.Forms.Button();
            this.btnCadProd = new System.Windows.Forms.Button();
            this.btnVoltarGerente = new System.Windows.Forms.Button();
            this.btnProdQuant = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.lblTela);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 54);
            this.panel1.TabIndex = 14;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Teal;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSair.Location = new System.Drawing.Point(537, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(148, 54);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblTela
            // 
            this.lblTela.AutoSize = true;
            this.lblTela.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTela.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTela.Location = new System.Drawing.Point(3, 15);
            this.lblTela.Name = "lblTela";
            this.lblTela.Size = new System.Drawing.Size(94, 24);
            this.lblTela.TabIndex = 2;
            this.lblTela.Text = "Estoque";
            // 
            // btnEditarProd
            // 
            this.btnEditarProd.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnEditarProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarProd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditarProd.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditarProd.Location = new System.Drawing.Point(22, 207);
            this.btnEditarProd.Name = "btnEditarProd";
            this.btnEditarProd.Size = new System.Drawing.Size(256, 46);
            this.btnEditarProd.TabIndex = 17;
            this.btnEditarProd.Text = "Editar Produto";
            this.btnEditarProd.UseVisualStyleBackColor = false;
            this.btnEditarProd.Click += new System.EventHandler(this.btnEditarProd_Click_1);
            // 
            // btnRelatórios
            // 
            this.btnRelatórios.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRelatórios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelatórios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRelatórios.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatórios.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRelatórios.Location = new System.Drawing.Point(406, 81);
            this.btnRelatórios.Name = "btnRelatórios";
            this.btnRelatórios.Size = new System.Drawing.Size(256, 46);
            this.btnRelatórios.TabIndex = 16;
            this.btnRelatórios.Text = "Relatórios";
            this.btnRelatórios.UseVisualStyleBackColor = false;
            this.btnRelatórios.Click += new System.EventHandler(this.btnRelatórios_Click);
            // 
            // btnCadProd
            // 
            this.btnCadProd.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCadProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadProd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadProd.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadProd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCadProd.Location = new System.Drawing.Point(22, 81);
            this.btnCadProd.Name = "btnCadProd";
            this.btnCadProd.Size = new System.Drawing.Size(256, 46);
            this.btnCadProd.TabIndex = 15;
            this.btnCadProd.Text = "Cadastrar Produto";
            this.btnCadProd.UseVisualStyleBackColor = false;
            this.btnCadProd.Click += new System.EventHandler(this.btnCadProd_Click);
            // 
            // btnVoltarGerente
            // 
            this.btnVoltarGerente.BackColor = System.Drawing.Color.Teal;
            this.btnVoltarGerente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltarGerente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoltarGerente.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarGerente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVoltarGerente.Location = new System.Drawing.Point(0, 357);
            this.btnVoltarGerente.Name = "btnVoltarGerente";
            this.btnVoltarGerente.Size = new System.Drawing.Size(148, 54);
            this.btnVoltarGerente.TabIndex = 18;
            this.btnVoltarGerente.Text = "Voltar";
            this.btnVoltarGerente.UseVisualStyleBackColor = false;
            this.btnVoltarGerente.Visible = false;
            this.btnVoltarGerente.Click += new System.EventHandler(this.btnVoltarGerente_Click);
            // 
            // btnProdQuant
            // 
            this.btnProdQuant.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnProdQuant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProdQuant.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProdQuant.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdQuant.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProdQuant.Location = new System.Drawing.Point(406, 207);
            this.btnProdQuant.Name = "btnProdQuant";
            this.btnProdQuant.Size = new System.Drawing.Size(256, 92);
            this.btnProdQuant.TabIndex = 19;
            this.btnProdQuant.Text = "Produtos com Quantidade Abaixo da Ideal";
            this.btnProdQuant.UseVisualStyleBackColor = false;
            this.btnProdQuant.Click += new System.EventHandler(this.btnProdQuant_Click);
            // 
            // frmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.ControlBox = false;
            this.Controls.Add(this.btnProdQuant);
            this.Controls.Add(this.btnVoltarGerente);
            this.Controls.Add(this.btnEditarProd);
            this.Controls.Add(this.btnRelatórios);
            this.Controls.Add(this.btnCadProd);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.frmEstoque_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblTela;
        private System.Windows.Forms.Button btnEditarProd;
        private System.Windows.Forms.Button btnRelatórios;
        private System.Windows.Forms.Button btnCadProd;
        private System.Windows.Forms.Button btnVoltarGerente;
        private System.Windows.Forms.Button btnProdQuant;
    }
}