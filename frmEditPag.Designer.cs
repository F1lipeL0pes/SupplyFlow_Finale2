namespace SupplyFlow
{
    partial class frmEditPag
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
            this.btnId = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblTela = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lboTipo = new System.Windows.Forms.ListBox();
            this.lblVenda = new System.Windows.Forms.Label();
            this.lboStatus = new System.Windows.Forms.ListBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtDataHora = new System.Windows.Forms.MaskedTextBox();
            this.lblDataHora = new System.Windows.Forms.Label();
            this.txtIDVenda = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnId
            // 
            this.btnId.BackColor = System.Drawing.Color.Teal;
            this.btnId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnId.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnId.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnId.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnId.Location = new System.Drawing.Point(288, 75);
            this.btnId.Margin = new System.Windows.Forms.Padding(4);
            this.btnId.Name = "btnId";
            this.btnId.Size = new System.Drawing.Size(197, 66);
            this.btnId.TabIndex = 94;
            this.btnId.Text = "Buscar ID";
            this.btnId.UseVisualStyleBackColor = false;
            this.btnId.Click += new System.EventHandler(this.btnId_Click);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(106, 71);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(137, 30);
            this.txtId.TabIndex = 93;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.Black;
            this.lblId.Location = new System.Drawing.Point(49, 71);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(52, 32);
            this.lblId.TabIndex = 92;
            this.lblId.Text = "ID:";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.CadetBlue;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluir.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExcluir.Location = new System.Drawing.Point(702, 355);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(197, 66);
            this.btnExcluir.TabIndex = 91;
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
            this.btnEditar.Location = new System.Drawing.Point(126, 355);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(197, 66);
            this.btnEditar.TabIndex = 90;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpar.Location = new System.Drawing.Point(418, 355);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(197, 66);
            this.btnLimpar.TabIndex = 89;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Controls.Add(this.lblTela);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 66);
            this.panel1.TabIndex = 88;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Teal;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoltar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVoltar.Location = new System.Drawing.Point(716, 0);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4);
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
            this.lblTela.Size = new System.Drawing.Size(249, 32);
            this.lblTela.TabIndex = 2;
            this.lblTela.Text = "Editar Pagamento";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(590, 183);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(245, 30);
            this.txtValor.TabIndex = 97;
            // 
            // lboTipo
            // 
            this.lboTipo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboTipo.FormattingEnabled = true;
            this.lboTipo.ItemHeight = 23;
            this.lboTipo.Items.AddRange(new object[] {
            "Dinheiro",
            "Cartão de Débito",
            "Cartão de Crédito",
            "Pix"});
            this.lboTipo.Location = new System.Drawing.Point(582, 77);
            this.lboTipo.Margin = new System.Windows.Forms.Padding(4);
            this.lboTipo.Name = "lboTipo";
            this.lboTipo.Size = new System.Drawing.Size(277, 96);
            this.lboTipo.TabIndex = 95;
            // 
            // lblVenda
            // 
            this.lblVenda.AutoSize = true;
            this.lblVenda.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenda.ForeColor = System.Drawing.Color.Black;
            this.lblVenda.Location = new System.Drawing.Point(493, 253);
            this.lblVenda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVenda.Name = "lblVenda";
            this.lblVenda.Size = new System.Drawing.Size(141, 32);
            this.lblVenda.TabIndex = 104;
            this.lblVenda.Text = "ID Venda:";
            // 
            // lboStatus
            // 
            this.lboStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboStatus.FormattingEnabled = true;
            this.lboStatus.ItemHeight = 23;
            this.lboStatus.Items.AddRange(new object[] {
            "Pago",
            "Não Pago"});
            this.lboStatus.Location = new System.Drawing.Point(154, 256);
            this.lboStatus.Margin = new System.Windows.Forms.Padding(4);
            this.lboStatus.Name = "lboStatus";
            this.lboStatus.Size = new System.Drawing.Size(277, 27);
            this.lboStatus.TabIndex = 98;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(37, 253);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(107, 32);
            this.lblStatus.TabIndex = 103;
            this.lblStatus.Text = "Status:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.Color.Black;
            this.lblValor.Location = new System.Drawing.Point(493, 185);
            this.lblValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(92, 32);
            this.lblValor.TabIndex = 102;
            this.lblValor.Text = "Valor:";
            // 
            // txtDataHora
            // 
            this.txtDataHora.Enabled = false;
            this.txtDataHora.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataHora.Location = new System.Drawing.Point(224, 183);
            this.txtDataHora.Margin = new System.Windows.Forms.Padding(4);
            this.txtDataHora.Mask = "00/00/0000 00:00";
            this.txtDataHora.Name = "txtDataHora";
            this.txtDataHora.Size = new System.Drawing.Size(187, 30);
            this.txtDataHora.TabIndex = 96;
            // 
            // lblDataHora
            // 
            this.lblDataHora.AutoSize = true;
            this.lblDataHora.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataHora.ForeColor = System.Drawing.Color.Black;
            this.lblDataHora.Location = new System.Drawing.Point(37, 183);
            this.lblDataHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(177, 32);
            this.lblDataHora.TabIndex = 101;
            this.lblDataHora.Text = "Data e Hora:";
            // 
            // txtIDVenda
            // 
            this.txtIDVenda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDVenda.Location = new System.Drawing.Point(641, 251);
            this.txtIDVenda.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDVenda.Name = "txtIDVenda";
            this.txtIDVenda.Size = new System.Drawing.Size(245, 30);
            this.txtIDVenda.TabIndex = 99;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.Black;
            this.lblTipo.Location = new System.Drawing.Point(493, 93);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(84, 32);
            this.lblTipo.TabIndex = 100;
            this.lblTipo.Text = "Tipo:";
            // 
            // frmEditPag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(915, 444);
            this.ControlBox = false;
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lboTipo);
            this.Controls.Add(this.lblVenda);
            this.Controls.Add(this.lboStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtDataHora);
            this.Controls.Add(this.lblDataHora);
            this.Controls.Add(this.txtIDVenda);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.btnId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.panel1);
            this.Name = "frmEditPag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Pagamento";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblTela;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.ListBox lboTipo;
        private System.Windows.Forms.Label lblVenda;
        private System.Windows.Forms.ListBox lboStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.MaskedTextBox txtDataHora;
        private System.Windows.Forms.Label lblDataHora;
        private System.Windows.Forms.TextBox txtIDVenda;
        private System.Windows.Forms.Label lblTipo;
    }
}