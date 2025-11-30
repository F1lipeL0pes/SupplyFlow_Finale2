using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupplyFlow
{
    public partial class frmEstoque : Form
    {
        private Admin admin;
        private int idUsuario;
        private string cargo;
        public frmEstoque(Admin admin, int idUsuario, string cargo)
        {
            InitializeComponent();
            this.admin = admin;
            this.idUsuario = idUsuario;
            this.cargo = cargo;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadProd_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            frmCadastroProduto cadastroProduto = new frmCadastroProduto(admin, idUsuario, cargo);
            cadastroProduto.Show();
            this.Close();
        }

        private void btnEditarProd_Click_1(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            frmEditarProduto editarProduto = new frmEditarProduto(admin, idUsuario, cargo);
            editarProduto.Show();
            this.Close();
        }

        private void btnRelatórios_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            frmRelatoriosEst relatorio = new frmRelatoriosEst(admin, idUsuario, cargo);
            relatorio.Show();
            this.Close();
        }

        private void frmEstoque_Load(object sender, EventArgs e)
        {
            if (cargo == "gerente")
            {
                btnVoltarGerente.Visible = true;
            }
        }

        private void btnVoltarGerente_Click(object sender, EventArgs e)
        {
            frmGerente gerente = new frmGerente(admin, idUsuario, cargo);
            gerente.Show();
            this.Close();
        }

        private void btnProdQuant_Click(object sender, EventArgs e)
        {
            frmRelQuantidade prodQuant = new frmRelQuantidade();
            prodQuant.ShowDialog();
        }
    }
}
