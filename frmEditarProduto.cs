using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SupplyFlow.frmEditarItemVenda;

namespace SupplyFlow
{
    public partial class frmEditarProduto : Form
    {
        private Admin admin;
        private bool isEditing = false;
        private int idUsuario;
        private string cargo;
        private int id;
        public frmEditarProduto(Admin admin, int idusuario, string cargo)
        {
            this.admin = new Admin();
            InitializeComponent();

            this.idUsuario = idusuario;
            this.cargo = cargo;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmEstoque estoque = new frmEstoque(admin, idUsuario, cargo);
            estoque.Show();
            this.Close();
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Campo ID vazio. Digite o campo e tente novamente!");
                return;
            }
            else
            {
                try
                {
                    id = Convert.ToInt32(txtId.Text);
                    admin.excluirProduto(id);
                    Limpar();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Preenchida o ID com caracteres.\nRemova os caracteres e preencha com números!");
                    return;
                }
            }
        }

        public void Limpar()
        {
            txtDesc.Clear();
            txtCategoria.Clear();
            txtId.Clear();
            txtPreco.Clear();
            txtQtd.Clear();
            txtQtdIdeal.Clear();
            txtUniMed.Clear();
            txtId.Focus();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtDesc.Text == "" || txtCategoria.Text == "" || txtPreco.Text == "" || txtQtd.Text == "" || txtQtdIdeal.Text == "" || txtUniMed.Text == "")
            {
                MessageBox.Show("Campos vazios! Por favor preencha corretamente!");
                return;
            }
            else
            {
                int id, qtd, qtdIdeal;
                string desc, categoria, uniMed;
                double preco;
                desc = txtDesc.Text.Trim();
                categoria = txtCategoria.Text.Trim();
                uniMed = txtUniMed.Text.Trim();
                try
                {
                    id = Convert.ToInt32(txtId.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("ID preenchido com caracteres! Retire e preencha com números e tente novamente.");
                    return;
                }

                try
                {
                    qtd = Convert.ToInt32(txtQtd.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Quantidade preenchida com caracteres! Retire e preencha com números e tente novamente.");
                    return;
                }
                try
                {
                    qtdIdeal = Convert.ToInt32(txtQtdIdeal.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Quantidade Adequada preenchida com caracteres! Retire e preencha com números e tente novamente.");
                    return;
                }
                try
                {
                    preco = Convert.ToDouble(txtPreco.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Preço preenchido com caracteres! Retire e preencha com números e tente novamente.");
                    return;
                }

                try
                {
                    ClasseProduto produto = new ClasseProduto(desc, categoria, uniMed, qtd, qtdIdeal, preco);
                    admin.editarProduto(produto, id);
                    Limpar();
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
            }

        }

        private void btnId_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("O ID do produto está vazio. por favor preencha corretamente!");
                return;
            }
            else
            {
                try
                {
                    id = Convert.ToInt32(txtId.Text);

                    string conexao = @"server=127.0.0.1;uid=root;pwd=ifsp;database=supplyflow;ConnectionTimeout=1";
                    using (var connection = new MySqlConnection(conexao))
                    {
                        connection.Open();

                        string sql = "SELECT descrição, categoria, quantidade_atual, quantidade_adequada, unidade_medida, preço_compra from Produto WHERE idProduto = @id";

                        using (var cmd = new MySqlCommand(sql, connection))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader == null)
                                {
                                    throw new idNaoEncontradoException();
                                }
                                while (reader.Read())
                                {
                                    txtDesc.Text = reader.GetString("descrição");
                                    txtCategoria.Text = reader.GetString("categoria");
                                    txtQtd.Text = reader.GetInt32("quantidade_atual").ToString();
                                    txtQtdIdeal.Text = reader.GetInt32("quantidade_adequada").ToString();
                                    txtUniMed.Text = reader.GetString("unidade_medida");
                                    txtPreco.Text = reader.GetDouble("preço_compra").ToString();
                                }
                            }
                        }
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Preenchida o ID com caracteres.\nRemova os caracteres e preencha com números!");
                    return;
                }
                catch (idNaoEncontradoException)
                {
                    MessageBox.Show("ID não encontrado no Banco de Dados.\nPreencha com outro ID existente!");
                    return;
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void frmEditarProduto_Load(object sender, EventArgs e)
        {

        }
    }
}
