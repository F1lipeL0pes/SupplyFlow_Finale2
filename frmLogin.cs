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

namespace SupplyFlow
{
    public partial class frmLogin : Form
    {
        private Admin admin = new Admin();
        private int idUsuario;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario, senha;
            usuario = txtLogin.Text.Trim();
            senha = txtSenha.Text.Trim();
            if (usuario == "" || senha == "")
            {
                MessageBox.Show("Digite um Usuário e Senha!");
                txtLogin.Focus();
            }
            else
            {
                string conexao = @"server=127.0.0.1;uid=root;pwd=1234;database=supplyflow;ConnectionTimeout=1";
                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    conn.Open();

                    string sql = "SELECT idUsuario, cargo FROM funcionario WHERE login = @usuario AND senha = @senha";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@senha", senha);

                        MySqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            MessageBox.Show("Login realizado com sucesso!");

                            string cargo = reader.GetString("cargo");
                            idUsuario = reader.GetInt32("idUsuario");

                            if (cargo == "garçom")
                            {
                                frmVendas garcom = new frmVendas(admin, idUsuario, cargo);
                                garcom.Show();

                                frmRelQuantidade quantProd = new frmRelQuantidade();
                                quantProd.ShowDialog();
                            }
                            else if (cargo == "responsável de estoque")
                            {
                                frmEstoque estoque = new frmEstoque(admin, idUsuario, cargo);
                                estoque.Show();

                                frmRelQuantidade quantProd = new frmRelQuantidade();
                                quantProd.ShowDialog();
                            }
                            else if (cargo == "gerente")
                            {
                                frmGerente gerente = new frmGerente(admin, idUsuario, cargo);
                                gerente.Show();

                                frmRelQuantidade quantProd = new frmRelQuantidade();
                                quantProd.ShowDialog();
                            }
                            this.Hide();
                        }

                        else
                        {
                            MessageBox.Show("Usuário ou senha incorretos.");
                        }
                    }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
