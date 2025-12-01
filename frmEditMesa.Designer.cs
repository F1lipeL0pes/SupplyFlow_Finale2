namespace SupplyFlow
{
    partial class frmEditMesa
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
            this.lboStatus = new System.Windows.Forms.ListBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtCapacidade = new System.Windows.Forms.TextBox();
            this.lblCapacidade = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.btnId = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 66);
            this.panel1.TabIndex = 16;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Teal;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoltar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVoltar.Location = new System.Drawing.Point(566, 0);
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
            this.lblTela.Location = new System.Drawing.Point(13, 18);
            this.lblTela.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTela.Name = "lblTela";
            this.lblTela.Size = new System.Drawing.Size(166, 32);
            this.lblTela.TabIndex = 2;
            this.lblTela.Text = "Editar Mesa";
            // 
            // lboStatus
            // 
            this.lboStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboStatus.FormattingEnabled = true;
            this.lboStatus.ItemHeight = 23;
            this.lboStatus.Items.AddRange(new object[] {
            "Livre",
            "Ocupada",
            "Reservada"});
            this.lboStatus.Location = new System.Drawing.Point(147, 288);
            this.lboStatus.Margin = new System.Windows.Forms.Padding(4);
            this.lboStatus.Name = "lboStatus";
            this.lboStatus.Size = new System.Drawing.Size(277, 50);
            this.lboStatus.TabIndex = 46;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(30, 285);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(107, 32);
            this.lblStatus.TabIndex = 49;
            this.lblStatus.Text = "Status:";
            // 
            // txtCapacidade
            // 
            this.txtCapacidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacidade.Location = new System.Drawing.Point(570, 178);
            this.txtCapacidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtCapacidade.Name = "txtCapacidade";
            this.txtCapacidade.Size = new System.Drawing.Size(155, 30);
            this.txtCapacidade.TabIndex = 45;
            // 
            // lblCapacidade
            // 
            this.lblCapacidade.AutoSize = true;
            this.lblCapacidade.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacidade.ForeColor = System.Drawing.Color.Black;
            this.lblCapacidade.Location = new System.Drawing.Point(384, 178);
            this.lblCapacidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCapacidade.Name = "lblCapacidade";
            this.lblCapacidade.Size = new System.Drawing.Size(178, 32);
            this.lblCapacidade.TabIndex = 48;
            this.lblCapacidade.Text = "Capacidade:";
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum.Location = new System.Drawing.Point(166, 180);
            this.txtNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(155, 30);
            this.txtNum.TabIndex = 44;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.ForeColor = System.Drawing.Color.Black;
            this.lblNum.Location = new System.Drawing.Point(30, 183);
            this.lblNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(130, 32);
            this.lblNum.TabIndex = 47;
            this.lblNum.Text = "Número:";
            // 
            // btnId
            // 
            this.btnId.BackColor = System.Drawing.Color.Teal;
            this.btnId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnId.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnId.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnId.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnId.Location = new System.Drawing.Point(261, 78);
            this.btnId.Margin = new System.Windows.Forms.Padding(4);
            this.btnId.Name = "btnId";
            this.btnId.Size = new System.Drawing.Size(197, 66);
            this.btnId.TabIndex = 93;
            this.btnId.Text = "Buscar ID";
            this.btnId.UseVisualStyleBackColor = false;
            this.btnId.Click += new System.EventHandler(this.btnId_Click);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(79, 74);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(137, 30);
            this.txtId.TabIndex = 92;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.Black;
            this.lblId.Location = new System.Drawing.Point(22, 74);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(52, 32);
            this.lblId.TabIndex = 91;
            this.lblId.Text = "ID:";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.CadetBlue;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluir.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExcluir.Location = new System.Drawing.Point(555, 366);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(197, 66);
            this.btnExcluir.TabIndex = 90;
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
            this.btnEditar.Location = new System.Drawing.Point(28, 366);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(197, 66);
            this.btnEditar.TabIndex = 89;
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
            this.btnLimpar.Location = new System.Drawing.Point(290, 366);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(197, 66);
            this.btnLimpar.TabIndex = 88;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmEditMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(765, 445);
            this.ControlBox = false;
            this.Controls.Add(this.btnId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lboStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtCapacidade);
            this.Controls.Add(this.lblCapacidade);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmEditMesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Mesa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblTela;
        private System.Windows.Forms.ListBox lboStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtCapacidade;
        private System.Windows.Forms.Label lblCapacidade;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Button btnId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnLimpar;
    }
}