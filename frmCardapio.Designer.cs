namespace SupplyFlow
{
    partial class frmCardapio
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
            this.pnlCardapio = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblTelaC = new System.Windows.Forms.Label();
            this.lboCardapio = new System.Windows.Forms.ListBox();
            this.pnlCardapio.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCardapio
            // 
            this.pnlCardapio.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlCardapio.Controls.Add(this.btnVoltar);
            this.pnlCardapio.Controls.Add(this.lblTelaC);
            this.pnlCardapio.Location = new System.Drawing.Point(1, -2);
            this.pnlCardapio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlCardapio.Name = "pnlCardapio";
            this.pnlCardapio.Size = new System.Drawing.Size(1080, 71);
            this.pnlCardapio.TabIndex = 16;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Teal;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoltar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVoltar.Location = new System.Drawing.Point(883, 0);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(197, 71);
            this.btnVoltar.TabIndex = 10;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblTelaC
            // 
            this.lblTelaC.AutoSize = true;
            this.lblTelaC.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelaC.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTelaC.Location = new System.Drawing.Point(4, 21);
            this.lblTelaC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelaC.Name = "lblTelaC";
            this.lblTelaC.Size = new System.Drawing.Size(134, 32);
            this.lblTelaC.TabIndex = 2;
            this.lblTelaC.Text = "Cardápio";
            // 
            // lboCardapio
            // 
            this.lboCardapio.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboCardapio.FormattingEnabled = true;
            this.lboCardapio.ItemHeight = 27;
            this.lboCardapio.Location = new System.Drawing.Point(16, 76);
            this.lboCardapio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lboCardapio.Name = "lboCardapio";
            this.lboCardapio.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lboCardapio.Size = new System.Drawing.Size(768, 382);
            this.lboCardapio.TabIndex = 23;
            // 
            // frmCardapio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 476);
            this.Controls.Add(this.lboCardapio);
            this.Controls.Add(this.pnlCardapio);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCardapio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cardápio";
            this.Load += new System.EventHandler(this.frmCardapio_Load);
            this.pnlCardapio.ResumeLayout(false);
            this.pnlCardapio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCardapio;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblTelaC;
        private System.Windows.Forms.ListBox lboCardapio;
    }
}