using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace SupplyFlow
{
    public partial class frmCadCardapio : Form
    {
        private Admin admin;
        private int idUsuario;
        private string cargo;
        public frmCadCardapio(Admin admin, int idUsuario, string cargo)
        {
            InitializeComponent();
            this.admin = admin;
            this.idUsuario = idUsuario;
            this.cargo = cargo;
        }

        private void limpar()
        {
            txtDesc.Clear();
            txtNome.Clear();
            txtPreco.Clear();
            lboProduto.ClearSelected();
            txtNome.Focus();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome, desc, categoria;
            double preco;

            if (txtNome.Text == "" || txtDesc.Text == "" || txtPreco.Text == "" || Convert.ToString(lboProduto.SelectedItem) == "")
            {
                MessageBox.Show("Alguns dados não foram preenchidos.\nPreencha todos os dados");
                return;
            }

            nome = txtNome.Text.Trim();
            desc = txtDesc.Text.Trim();
            categoria = Convert.ToString(lboProduto.SelectedItem);

            try
            {
                preco = Convert.ToDouble(txtPreco.Text.Trim());
            }
            catch (FormatException)
            {
                MessageBox.Show("Preenchido o preço do produto com caracteres.\nRemova os caracteres e preencha com números!");
                return;
            }

            try
            {
                ClasseCardapio cardapio = new ClasseCardapio(nome, desc, categoria, preco);
                admin.cadastrarCardapio(cardapio);
                MessageBox.Show("Item do cardápio cadastrado com sucesso!");

            }
            catch (Exception erro)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Exceção Desconhecida !!!");
                sb.AppendLine(erro.GetType().ToString());
                sb.AppendLine(erro.Message);
                sb.AppendLine("\n" + erro.StackTrace);

                MessageBox.Show(sb.ToString());
            }
            limpar();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmGerente gerente = new frmGerente(admin, idUsuario, cargo);
            gerente.Show();
            this.Close();
        }

        private void lblDesc_Click(object sender, EventArgs e)
        {

        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
