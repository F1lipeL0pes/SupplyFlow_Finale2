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
    public partial class frmEditMesa : Form
    {
        private Admin admin;
        private int idUsuario;
        private string cargo;
        private int id;
        public frmEditMesa(Admin admin, int idUsuario, string cargo)
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
            txtCapacidade.Clear();
            txtId.Clear();
            txtNum.Clear();
            lboStatus.ClearSelected();
            txtId.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmGerente gerente = new frmGerente(admin, idUsuario, cargo);
            gerente.Show();
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
                    admin.excluirMesa(id);
                    Limpar();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Preenchida o ID com caracteres.\nRemova os caracteres e preencha com números!");
                    return;
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

                    string conexao = @"server=127.0.0.1;uid=root;pwd=ifsp;database=supplyflow;ConnectionTimeout=1";
                    using (var connection = new MySqlConnection(conexao))
                    {
                        connection.Open();

                        string sql = "SELECT numero, capacidade, status from Mesa WHERE idMesa = @id";

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
                                    txtCapacidade.Text = reader.GetInt32("capacidade").ToString();
                                    txtNum.Text = reader.GetInt32("numero").ToString();
                                    lboStatus.SelectedItem = reader.GetString("status");
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtCapacidade.Text == "" || txtNum.Text == "" || lboStatus.SelectedItem == null)
            {
                MessageBox.Show("Campos vazios!. Por favor preencha corretamente!");
                return;
            }
            else
            {
                int numero, capacidade;
                string status;
                try
                {
                    numero = Convert.ToInt32(txtNum.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Preenchido o numero com caracteres. Retire-os!");
                    return;
                }
                try
                {
                    capacidade = Convert.ToInt32(txtCapacidade.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Preenchida a capacidade com caracteres. Retire-os!");
                    return;
                }
                status = lboStatus.SelectedItem.ToString();
                try
                {
                    ClasseMesa mesa = new ClasseMesa(numero, capacidade, status);
                    admin.editarMesa(mesa, id);

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
    }
}
