using MySql.Data.MySqlClient;
using Mysqlx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SupplyFlow.frmCadInsumo;

namespace SupplyFlow
{
    public partial class frmCadVenda : Form
    {
        private Admin admin;
        private int idUsuario;
        private string cargo;
        public frmCadVenda(Admin admin, int idUsuario, string cargo)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtData.Text = DateTime.Now.Date.ToString();
            txtHora.Text = DateTime.Now.TimeOfDay.ToString();
        }
        public class Mesa
        {
            public int Id { get; set; }
            public int num { get; set; }
            public override string ToString()
            {
                return $"Mesa {num}";  // Exibe "Mesa 1", "Mesa 2", etc.
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            int idMesa = 1;
            DateTime data;
            TimeSpan hora;
            data = DateTime.Now.Date;
            hora = DateTime.Now.TimeOfDay;

            if (lboMesa.SelectedItem == null)
            {
                MessageBox.Show("Não foi selecionada nenhuma mesa!");
                return;
            }

            if (lboMesa.SelectedItem is Mesa m)
            {
                idMesa = m.Id;
            }
            try
            {
                ClasseVenda venda = new ClasseVenda(data, hora, idUsuario, idMesa);
                admin.cadastrarVenda(venda);
                MessageBox.Show("Venda cadastrada com sucesso!");
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
            lboMesa.ClearSelected();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lboMesa.ClearSelected();
        }

        private void frmCadVenda_Load(object sender, EventArgs e)
        {
            txtID.Text = idUsuario.ToString();

            try
            {
                string conexao = @"server=127.0.0.1;uid=root;pwd=ifsp;database=supplyflow;ConnectionTimeout=1";

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
                            lboMesa.Items.Add(new Mesa
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
