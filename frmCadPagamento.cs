using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupplyFlow
{
    public partial class frmCadPagamento : Form
    {
        private Admin admin;
        private int idUsuario;
        private string cargo;
        public frmCadPagamento(Admin admin, int idUsuario, string cargo)
        {
            InitializeComponent();
            this.admin = admin;
            this.idUsuario = idUsuario;
            this.cargo = cargo;
        }

        public void limpar()
        {
            txtIDVenda.Clear();
            txtValor.Clear();
            lboStatus.ClearSelected();
            lboTipo.ClearSelected();
            txtValor.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int idVenda;
            string tipo, status;
            double valor;
            DateTime dataHora;

            if (txtIDVenda.Text == null || txtValor.Text == null || lboStatus.SelectedItem == null || lboTipo.SelectedItem == null)
            {
                MessageBox.Show("Alguns dados não foram preenchidos.\nPreencha todos os dados");
                return;
            }

            try
            {
                dataHora = Convert.ToDateTime(txtDataHora.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Data incompatível.\nPreencha corretamente!");
                return;
            }

            try
            {
                valor = Convert.ToDouble(txtValor.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Preenchido o valor com caracteres.\nRemova os caracteres e preencha com números!");
                return;
            }
            try
            {
                idVenda = Convert.ToInt32(txtIDVenda.Text);

                string conexao = @"server=127.0.0.1;uid=root;pwd=1234;database=supplyflow;ConnectionTimeout=1";
                using (var connection = new MySqlConnection(conexao))
                {
                    connection.Open();

                    string sql = "SELECT idPagamento FROM pagamento WHERE idPagamento = @id";

                    using (var cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", idVenda);

                        object result = cmd.ExecuteScalar();

                        if (result == null)
                        {
                            throw new idNaoEncontradoException();
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

            tipo = Convert.ToString(lboTipo.SelectedItem);
            status = Convert.ToString(lboStatus.SelectedItem);
            try
            {
                ClassePagamento pagamento = new ClassePagamento(idVenda, tipo, status, valor, dataHora);
                admin.cadastrarPagamento(pagamento);

                MessageBox.Show("Pagamento realizado com sucesso!");

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

        private void frmCadPagamento_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtDataHora.Text = Convert.ToString(DateTime.Now);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmVendas garcom = new frmVendas(admin, idUsuario, cargo);
            garcom.Show();
            this.Close();
        }

    }
}
