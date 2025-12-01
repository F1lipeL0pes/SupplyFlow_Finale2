namespace SupplyFlow
{
    partial class frmEditarProduto
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
            this.txtUniMed = new System.Windows.Forms.TextBox();
            this.txtQtdIdeal = new System.Windows.Forms.TextBox();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblUniMed = new System.Windows.Forms.Label();
            this.lblQtdIdeal = new System.Windows.Forms.Label();
            this.lblQtd = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.btnId = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Controls.Add(this.lblTela);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 66);
            this.panel1.TabIndex = 15;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Teal;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoltar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVoltar.Location = new System.Drawing.Point(716, 0);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(197, 66);
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
            this.lblTela.Location = new System.Drawing.Point(4, 18);
            this.lblTela.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTela.Name = "lblTela";
            this.lblTela.Size = new System.Drawing.Size(206, 32);
            this.lblTela.TabIndex = 2;
            this.lblTela.Text = "Editar Produto";
            // 
            // txtUniMed
            // 
            this.txtUniMed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUniMed.Location = new System.Drawing.Point(703, 277);
            this.txtUniMed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUniMed.Name = "txtUniMed";
            this.txtUniMed.Size = new System.Drawing.Size(168, 30);
            this.txtUniMed.TabIndex = 42;
            // 
            // txtQtdIdeal
            // 
            this.txtQtdIdeal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdIdeal.Location = new System.Drawing.Point(271, 348);
            this.txtQtdIdeal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQtdIdeal.Name = "txtQtdIdeal";
            this.txtQtdIdeal.Size = new System.Drawing.Size(137, 30);
            this.txtQtdIdeal.TabIndex = 41;
            // 
            // txtQtd
            // 
            this.txtQtd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtd.Location = new System.Drawing.Point(271, 281);
            this.txtQtd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(137, 30);
            this.txtQtd.TabIndex = 40;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.Location = new System.Drawing.Point(271, 218);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(600, 30);
            this.txtCategoria.TabIndex = 39;
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(271, 148);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(600, 30);
            this.txtDesc.TabIndex = 38;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.CadetBlue;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluir.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExcluir.Location = new System.Drawing.Point(675, 425);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(197, 66);
            this.btnExcluir.TabIndex = 37;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Teal;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditar.Location = new System.Drawing.Point(121, 425);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(197, 66);
            this.btnEditar.TabIndex = 30;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.ForeColor = System.Drawing.Color.Black;
            this.lblPreco.Location = new System.Drawing.Point(593, 347);
            this.lblPreco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(100, 32);
            this.lblPreco.TabIndex = 36;
            this.lblPreco.Text = "Preço:";
            // 
            // lblUniMed
            // 
            this.lblUniMed.AutoSize = true;
            this.lblUniMed.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUniMed.ForeColor = System.Drawing.Color.Black;
            this.lblUniMed.Location = new System.Drawing.Point(417, 279);
            this.lblUniMed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUniMed.Name = "lblUniMed";
            this.lblUniMed.Size = new System.Drawing.Size(274, 32);
            this.lblUniMed.TabIndex = 35;
            this.lblUniMed.Text = "Unidade de Medida:";
            // 
            // lblQtdIdeal
            // 
            this.lblQtdIdeal.AutoSize = true;
            this.lblQtdIdeal.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdIdeal.ForeColor = System.Drawing.Color.Black;
            this.lblQtdIdeal.Location = new System.Drawing.Point(15, 347);
            this.lblQtdIdeal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQtdIdeal.Name = "lblQtdIdeal";
            this.lblQtdIdeal.Size = new System.Drawing.Size(246, 32);
            this.lblQtdIdeal.TabIndex = 34;
            this.lblQtdIdeal.Text = "Quantidade Ideal:";
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtd.ForeColor = System.Drawing.Color.Black;
            this.lblQtd.Location = new System.Drawing.Point(60, 283);
            this.lblQtd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(175, 32);
            this.lblQtd.TabIndex = 33;
            this.lblQtd.Text = "Quantidade:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.Black;
            this.lblCategoria.Location = new System.Drawing.Point(73, 217);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(151, 32);
            this.lblCategoria.TabIndex = 32;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.ForeColor = System.Drawing.Color.Black;
            this.lblDesc.Location = new System.Drawing.Point(95, 150);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(155, 32);
            this.lblDesc.TabIndex = 31;
            this.lblDesc.Text = "Descrição:";
            // 
            // btnId
            // 
            this.btnId.BackColor = System.Drawing.Color.Teal;
            this.btnId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnId.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnId.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnId.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnId.Location = new System.Drawing.Point(446, 74);
            this.btnId.Margin = new System.Windows.Forms.Padding(4);
            this.btnId.Name = "btnId";
            this.btnId.Size = new System.Drawing.Size(197, 66);
            this.btnId.TabIndex = 68;
            this.btnId.Text = "Buscar ID";
            this.btnId.UseVisualStyleBackColor = false;
            this.btnId.Click += new System.EventHandler(this.btnId_Click);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(271, 87);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(127, 30);
            this.txtId.TabIndex = 67;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.Black;
            this.lblId.Location = new System.Drawing.Point(145, 87);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(52, 32);
            this.lblId.TabIndex = 66;
            this.lblId.Text = "ID:";
            // 
            // txtPreco
            // 
            this.txtPreco.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.Location = new System.Drawing.Point(701, 349);
            this.txtPreco.Margin = new System.Windows.Forms.Padding(4);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(168, 30);
            this.txtPreco.TabIndex = 69;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpar.Location = new System.Drawing.Point(394, 425);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(197, 66);
            this.btnLimpar.TabIndex = 70;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmEditarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(912, 506);
            this.ControlBox = false;
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.btnId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtUniMed);
            this.Controls.Add(this.txtQtdIdeal);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblUniMed);
            this.Controls.Add(this.lblQtdIdeal);
            this.Controls.Add(this.lblQtd);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmEditarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Produto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblTela;
        private System.Windows.Forms.TextBox txtUniMed;
        private System.Windows.Forms.TextBox txtQtdIdeal;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblUniMed;
        private System.Windows.Forms.Label lblQtdIdeal;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Button btnId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Button btnLimpar;
    }
}