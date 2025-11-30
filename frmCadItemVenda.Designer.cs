namespace SupplyFlow
{
    partial class frmCadItemVenda
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
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.lblQtd = new System.Windows.Forms.Label();
            this.txtIDVenda = new System.Windows.Forms.TextBox();
            this.lblIdVenda = new System.Windows.Forms.Label();
            this.lboCardapio = new System.Windows.Forms.ListBox();
            this.lblCardapio = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdbPrato = new System.Windows.Forms.RadioButton();
            this.rdbAperitivo = new System.Windows.Forms.RadioButton();
            this.rdbEntrada = new System.Windows.Forms.RadioButton();
            this.rdbBebida = new System.Windows.Forms.RadioButton();
            this.rdbSobremesa = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.btnVoltar.TabIndex = 10;
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
            this.lblTela.Size = new System.Drawing.Size(281, 24);
            this.lblTela.TabIndex = 2;
            this.lblTela.Text = "Cadastro de Item da Venda";
            // 
            // txtQtd
            // 
            this.txtQtd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtd.Location = new System.Drawing.Point(151, 80);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(101, 26);
            this.txtQtd.TabIndex = 32;
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtd.ForeColor = System.Drawing.Color.Black;
            this.lblQtd.Location = new System.Drawing.Point(12, 82);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(133, 24);
            this.lblQtd.TabIndex = 33;
            this.lblQtd.Text = "Quantidade:";
            // 
            // txtIDVenda
            // 
            this.txtIDVenda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDVenda.Location = new System.Drawing.Point(151, 144);
            this.txtIDVenda.Name = "txtIDVenda";
            this.txtIDVenda.Size = new System.Drawing.Size(101, 26);
            this.txtIDVenda.TabIndex = 34;
            // 
            // lblIdVenda
            // 
            this.lblIdVenda.AutoSize = true;
            this.lblIdVenda.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdVenda.ForeColor = System.Drawing.Color.Black;
            this.lblIdVenda.Location = new System.Drawing.Point(40, 146);
            this.lblIdVenda.Name = "lblIdVenda";
            this.lblIdVenda.Size = new System.Drawing.Size(105, 24);
            this.lblIdVenda.TabIndex = 35;
            this.lblIdVenda.Text = "ID Venda:";
            // 
            // lboCardapio
            // 
            this.lboCardapio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboCardapio.FormattingEnabled = true;
            this.lboCardapio.ItemHeight = 18;
            this.lboCardapio.Location = new System.Drawing.Point(280, 161);
            this.lboCardapio.Name = "lboCardapio";
            this.lboCardapio.Size = new System.Drawing.Size(392, 238);
            this.lboCardapio.TabIndex = 36;
            // 
            // lblCardapio
            // 
            this.lblCardapio.AutoSize = true;
            this.lblCardapio.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardapio.ForeColor = System.Drawing.Color.Black;
            this.lblCardapio.Location = new System.Drawing.Point(276, 68);
            this.lblCardapio.Name = "lblCardapio";
            this.lblCardapio.Size = new System.Drawing.Size(189, 24);
            this.lblCardapio.TabIndex = 37;
            this.lblCardapio.Text = "Item do Carpápio:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpar.Location = new System.Drawing.Point(44, 310);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(148, 54);
            this.btnLimpar.TabIndex = 39;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Teal;
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCadastrar.Location = new System.Drawing.Point(44, 210);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(148, 54);
            this.btnCadastrar.TabIndex = 38;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdbSobremesa);
            this.panel2.Controls.Add(this.rdbBebida);
            this.panel2.Controls.Add(this.rdbEntrada);
            this.panel2.Controls.Add(this.rdbAperitivo);
            this.panel2.Controls.Add(this.rdbPrato);
            this.panel2.Location = new System.Drawing.Point(281, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(390, 60);
            this.panel2.TabIndex = 40;
            // 
            // rdbPrato
            // 
            this.rdbPrato.AutoSize = true;
            this.rdbPrato.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPrato.Location = new System.Drawing.Point(122, 3);
            this.rdbPrato.Name = "rdbPrato";
            this.rdbPrato.Size = new System.Drawing.Size(129, 22);
            this.rdbPrato.TabIndex = 0;
            this.rdbPrato.TabStop = true;
            this.rdbPrato.Text = "Prato Principal";
            this.rdbPrato.UseVisualStyleBackColor = true;
            this.rdbPrato.CheckedChanged += new System.EventHandler(this.rdbPrato_CheckedChanged);
            // 
            // rdbAperitivo
            // 
            this.rdbAperitivo.AutoSize = true;
            this.rdbAperitivo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAperitivo.Location = new System.Drawing.Point(3, 3);
            this.rdbAperitivo.Name = "rdbAperitivo";
            this.rdbAperitivo.Size = new System.Drawing.Size(88, 22);
            this.rdbAperitivo.TabIndex = 1;
            this.rdbAperitivo.TabStop = true;
            this.rdbAperitivo.Text = "Aperitivo";
            this.rdbAperitivo.UseVisualStyleBackColor = true;
            this.rdbAperitivo.CheckedChanged += new System.EventHandler(this.rdbAperitivo_CheckedChanged);
            // 
            // rdbEntrada
            // 
            this.rdbEntrada.AutoSize = true;
            this.rdbEntrada.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEntrada.Location = new System.Drawing.Point(3, 31);
            this.rdbEntrada.Name = "rdbEntrada";
            this.rdbEntrada.Size = new System.Drawing.Size(81, 22);
            this.rdbEntrada.TabIndex = 2;
            this.rdbEntrada.TabStop = true;
            this.rdbEntrada.Text = "Entrada";
            this.rdbEntrada.UseVisualStyleBackColor = true;
            this.rdbEntrada.CheckedChanged += new System.EventHandler(this.rdbEntrada_CheckedChanged);
            // 
            // rdbBebida
            // 
            this.rdbBebida.AutoSize = true;
            this.rdbBebida.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbBebida.Location = new System.Drawing.Point(122, 31);
            this.rdbBebida.Name = "rdbBebida";
            this.rdbBebida.Size = new System.Drawing.Size(77, 22);
            this.rdbBebida.TabIndex = 3;
            this.rdbBebida.TabStop = true;
            this.rdbBebida.Text = "Bebida";
            this.rdbBebida.UseVisualStyleBackColor = true;
            this.rdbBebida.CheckedChanged += new System.EventHandler(this.rdbBebida_CheckedChanged);
            // 
            // rdbSobremesa
            // 
            this.rdbSobremesa.AutoSize = true;
            this.rdbSobremesa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSobremesa.Location = new System.Drawing.Point(270, 3);
            this.rdbSobremesa.Name = "rdbSobremesa";
            this.rdbSobremesa.Size = new System.Drawing.Size(108, 22);
            this.rdbSobremesa.TabIndex = 4;
            this.rdbSobremesa.TabStop = true;
            this.rdbSobremesa.Text = "Sobremesa";
            this.rdbSobremesa.UseVisualStyleBackColor = true;
            this.rdbSobremesa.CheckedChanged += new System.EventHandler(this.rdbSobremesa_CheckedChanged);
            // 
            // frmCadItemVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lboCardapio);
            this.Controls.Add(this.lblCardapio);
            this.Controls.Add(this.txtIDVenda);
            this.Controls.Add(this.lblIdVenda);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.lblQtd);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmCadItemVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Item da Venda";
            this.Load += new System.EventHandler(this.frmCadItemVenda_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblTela;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.TextBox txtIDVenda;
        private System.Windows.Forms.Label lblIdVenda;
        private System.Windows.Forms.ListBox lboCardapio;
        private System.Windows.Forms.Label lblCardapio;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdbBebida;
        private System.Windows.Forms.RadioButton rdbEntrada;
        private System.Windows.Forms.RadioButton rdbAperitivo;
        private System.Windows.Forms.RadioButton rdbPrato;
        private System.Windows.Forms.RadioButton rdbSobremesa;
    }
}