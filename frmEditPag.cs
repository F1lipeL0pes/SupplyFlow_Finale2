using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SupplyFlow.frmEditarVenda;

namespace SupplyFlow
{
    public partial class frmEditPag : Form
    {
        private Admin admin;
        private int id;
        private int idUsuario;
        private string cargo;
        public frmEditPag(Admin admin, int idUsuario, string cargo)
        {
            InitializeComponent();
            this.admin = admin;
            this.idUsuario = idUsuario;
            this.cargo = cargo;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
        public void Limpar()
        {
            txtDataHora.Clear();
            txtId.Clear();
            txtIDVenda.Clear();
            txtValor.Clear();
            txtId.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmVendas garcom = new frmVendas(admin, idUsuario, cargo);
            garcom.Show();
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
                    admin.excluirPagamento(id);
                    Limpar();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Preenchida o ID com caracteres.\nRemova os caracteres e preencha com números!");
                    return;
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtDataHora.Text == "" || txtIDVenda.Text == "" || txtValor.Text == "" || lboStatus.Text == "" || lboTipo.Text == "")
            {
                MessageBox.Show("Campos vazios!. Por favor preencha corretamente!");
                return;
            }
            else
            {
                int id, idVenda;
                double valor;
                string status, tipo;
                DateTime datah;
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
                    idVenda = Convert.ToInt32(txtIDVenda.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("IDVenda preenchido com caracteres! Retire e preencha com números e tente novamente.");
                    return;
                }
                try
                {
                    datah = Convert.ToDateTime(txtDataHora.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Data inválida!");
                    return;
                }
                try
                {
                    valor = Convert.ToDouble(txtValor.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Valor preenchido com caracteres! Retire e preencha com números e tente novamente.");
                    return;
                }
                status = lboStatus.SelectedItem.ToString();
                tipo = lboTipo.SelectedItem.ToString();
                try
                {
                    ClassePagamento pag = new ClassePagamento(idVenda, tipo, status, valor, datah);
                    admin.editarpagamento(pag, id);
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
                MessageBox.Show("O ID está vazio. por favor preencha corretamente!");
                return;
            }
            else
            {
                try
                {
                    id = Convert.ToInt32(txtId.Text);

                    string conexao = @"server=127.0.0.1;uid=root;pwd=1234;database=supplyflow;ConnectionTimeout=1";
                    using (var connection = new MySqlConnection(conexao))
                    {
                        connection.Open();

                        string sql = "SELECT tipo_pagamento, data_hora, valor, statusPg, idVenda from Pagamento WHERE idPagamento = @id";

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
                                    txtDataHora.Text = reader.GetDateTime("data_hora").ToString();
                                    txtIDVenda.Text = reader.GetInt32("idVenda").ToString();
                                    txtValor.Text = reader.GetDouble("valor").ToString();
                                    lboStatus.SelectedItem = reader.GetString("statusPg");
                                    lboTipo.SelectedItem = reader.GetString("tipo_pagamento");
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
    }
}
