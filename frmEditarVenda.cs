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
using static SupplyFlow.frmCadVenda;
using static SupplyFlow.frmEditarItemVenda;

namespace SupplyFlow
{
    public partial class frmEditarVenda : Form
    {
        private Admin admin;
        private int idUsuario;
        private string cargo;
        private int id;
        public frmEditarVenda(Admin admin, int idUsuario, string cargo)
        {
            InitializeComponent();
            this.admin = admin;
            this.idUsuario = idUsuario;
            this.cargo = cargo;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmVendas garcom = new frmVendas(admin, idUsuario, cargo);
            garcom.Show();
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtData.Text == "" || txtHora.Text == "" || lboMesa.SelectedItem == null)
            {
                MessageBox.Show("Campos vazios!. Por favor preencha corretamente!");
                return;
            }
            else
            {
                int id, idMesa = 0, idU;
                DateTime data;
                TimeSpan hora;
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
                    idU = Convert.ToInt32(txtId.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("ID do Usuário preenchido com caracteres! Retire e preencha com números e tente novamente.");
                    return;
                }
                try
                {
                    data = Convert.ToDateTime(txtData.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Data Inválida!");
                    return;
                }
                try
                {
                    hora = Convert.ToDateTime(txtHora.Text).TimeOfDay;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Hora inválida!");
                    return;
                }
                if (lboMesa.SelectedItem is Mesa2 m)
                {
                    idMesa = m.Id;
                }
                try
                {
                    ClasseVenda venda = new ClasseVenda(data, hora, idU, idMesa);
                    admin.editarVenda(venda, id);
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

        private void lboMesa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lboPrato_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lboBebida_SelectedIndexChanged(object sender, EventArgs e)
        {
                
        }

        private void lboSobremesa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
                    admin.excluirVenda(id);
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
            txtData.Clear();
            txtHora.Clear();
            txtId.Clear();
            lboMesa.ClearSelected();
            txtIdUsuario.Clear();
            txtId.Focus();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        public class Mesa2
        {
            public int Id { get; set; }
            public int num { get; set; }
            public override string ToString()
            {
                return $"Mesa {num}";  // Exibe "Mesa 1", "Mesa 2", etc.
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

                        string sql = "SELECT data_venda, hora_venda, idUsuario, idMesa from Venda WHERE idVenda = @id";

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
                                    txtData.Text = Convert.ToString(reader.GetDateTime("data_venda"));
                                    txtHora.Text = Convert.ToString(reader.GetTimeSpan("hora_venda"));
                                    txtIdUsuario.Text = Convert.ToString(reader.GetInt32("idUsuario"));
                                    int idMesa = reader.GetInt32("idMesa");

                                    foreach (Mesa2 m in lboMesa.Items)
                                    {
                                        if (m.Id == idMesa)
                                        {
                                            lboMesa.SelectedItem = m;
                                            break;
                                        }
                                    }
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

        private void frmEditarVenda_Load(object sender, EventArgs e)
        {
            try
            {
                string conexao = @"server=127.0.0.1;uid=root;pwd=1234;database=supplyflow;ConnectionTimeout=1";

                string query = "SELECT idMesa, numero FROM mesa";

                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        lboMesa.Items.Clear();
                        while (reader.Read())
                        {
                            lboMesa.Items.Add(new Mesa2
                            {
                                Id = reader.GetInt32("idMesa"),
                                num = reader.GetInt32("numero")
                            });
                        }
                    }
                }

            }
            catch (MySqlException erro)
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine("Erro Banco!");
                sb.AppendLine(erro.GetType().ToString());
                sb.AppendLine(erro.Message);
                sb.AppendLine("\n" + erro.StackTrace);

                MessageBox.Show(sb.ToString());
            }
            //tratamento dos demais erros que possam ocorrer
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
