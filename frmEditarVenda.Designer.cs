namespace SupplyFlow
{
    partial class frmEditarVenda
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblTela = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMesa = new System.Windows.Forms.Label();
            this.lblSobremesa = new System.Windows.Forms.Label();
            this.lboSobremesa = new System.Windows.Forms.ListBox();
            this.lblBebida = new System.Windows.Forms.Label();
            this.lboBebida = new System.Windows.Forms.ListBox();
            this.lblPrato = new System.Windows.Forms.Label();
            this.lboPrato = new System.Windows.Forms.ListBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lboMesa = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.lblTela.Size = new System.Drawing.Size(232, 24);
            this.lblTela.TabIndex = 2;
            this.lblTela.Text = "Editar/Cancelar Venda";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Controls.Add(this.lblTela);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 54);
            this.panel1.TabIndex = 12;
            // 
            // lblMesa
            // 
            this.lblMesa.AutoSize = true;
            this.lblMesa.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesa.ForeColor = System.Drawing.Color.Black;
            this.lblMesa.Location = new System.Drawing.Point(88, 81);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(70, 24);
            this.lblMesa.TabIndex = 15;
            this.lblMesa.Text = "Mesa:";
            // 
            // lblSobremesa
            // 
            this.lblSobremesa.AutoSize = true;
            this.lblSobremesa.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobremesa.ForeColor = System.Drawing.Color.Black;
            this.lblSobremesa.Location = new System.Drawing.Point(26, 246);
            this.lblSobremesa.Name = "lblSobremesa";
            this.lblSobremesa.Size = new System.Drawing.Size(132, 24);
            this.lblSobremesa.TabIndex = 23;
            this.lblSobremesa.Text = "Sobremesa:";
            // 
            // lboSobremesa
            // 
            this.lboSobremesa.BackColor = System.Drawing.Color.Azure;
            this.lboSobremesa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lboSobremesa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboSobremesa.FormattingEnabled = true;
            this.lboSobremesa.ItemHeight = 18;
            this.lboSobremesa.Location = new System.Drawing.Point(170, 248);
            this.lboSobremesa.Name = "lboSobremesa";
            this.lboSobremesa.Size = new System.Drawing.Size(325, 20);
            this.lboSobremesa.TabIndex = 24;
            this.lboSobremesa.SelectedIndexChanged += new System.EventHandler(this.lboSobremesa_SelectedIndexChanged);
            // 
            // lblBebida
            // 
            this.lblBebida.AutoSize = true;
            this.lblBebida.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBebida.ForeColor = System.Drawing.Color.Black;
            this.lblBebida.Location = new System.Drawing.Point(72, 193);
            this.lblBebida.Name = "lblBebida";
            this.lblBebida.Size = new System.Drawing.Size(87, 24);
            this.lblBebida.TabIndex = 21;
            this.lblBebida.Text = "Bebida:";
            // 
            // lboBebida
            // 
            this.lboBebida.BackColor = System.Drawing.Color.Azure;
            this.lboBebida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lboBebida.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboBebida.FormattingEnabled = true;
            this.lboBebida.ItemHeight = 18;
            this.lboBebida.Location = new System.Drawing.Point(171, 195);
            this.lboBebida.Name = "lboBebida";
            this.lboBebida.Size = new System.Drawing.Size(325, 20);
            this.lboBebida.TabIndex = 22;
            this.lboBebida.SelectedIndexChanged += new System.EventHandler(this.lboBebida_SelectedIndexChanged);
            // 
            // lblPrato
            // 
            this.lblPrato.AutoSize = true;
            this.lblPrato.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrato.ForeColor = System.Drawing.Color.Black;
            this.lblPrato.Location = new System.Drawing.Point(88, 136);
            this.lblPrato.Name = "lblPrato";
            this.lblPrato.Size = new System.Drawing.Size(71, 24);
            this.lblPrato.TabIndex = 19;
            this.lblPrato.Text = "Prato:";
            // 
            // lboPrato
            // 
            this.lboPrato.BackColor = System.Drawing.Color.Azure;
            this.lboPrato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lboPrato.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboPrato.FormattingEnabled = true;
            this.lboPrato.ItemHeight = 18;
            this.lboPrato.Location = new System.Drawing.Point(171, 138);
            this.lboPrato.Name = "lboPrato";
            this.lboPrato.Size = new System.Drawing.Size(325, 20);
            this.lboPrato.TabIndex = 20;
            this.lboPrato.SelectedIndexChanged += new System.EventHandler(this.lboPrato_SelectedIndexChanged);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluir.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExcluir.Location = new System.Drawing.Point(524, 345);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(148, 54);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Teal;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditar.Location = new System.Drawing.Point(280, 345);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(148, 54);
            this.btnEditar.TabIndex = 25;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lboMesa
            // 
            this.lboMesa.BackColor = System.Drawing.Color.Azure;
            this.lboMesa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lboMesa.Location = new System.Drawing.Point(170, 86);
            this.lboMesa.Name = "lboMesa";
            this.lboMesa.Size = new System.Drawing.Size(325, 20);
            this.lboMesa.TabIndex = 26;
            // 
            // frmEditarVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.ControlBox = false;
            this.Controls.Add(this.lboMesa);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.lblSobremesa);
            this.Controls.Add(this.lboSobremesa);
            this.Controls.Add(this.lblBebida);
            this.Controls.Add(this.lboBebida);
            this.Controls.Add(this.lblPrato);
            this.Controls.Add(this.lboPrato);
            this.Controls.Add(this.lblMesa);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmEditarVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Venda";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblTela;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMesa;
        private System.Windows.Forms.Label lblSobremesa;
        private System.Windows.Forms.ListBox lboSobremesa;
        private System.Windows.Forms.Label lblBebida;
        private System.Windows.Forms.ListBox lboBebida;
        private System.Windows.Forms.Label lblPrato;
        private System.Windows.Forms.ListBox lboPrato;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox lboMesa;
    }
}