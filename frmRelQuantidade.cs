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
    public partial class frmRelQuantidade : Form
    {
        public frmRelQuantidade()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public class Produto
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public int QuantidadeAtual { get; set; }
            public int QuantidadeAdequada { get; set; }
        }

        private void frmRelQuantidade_Load(object sender, EventArgs e)
        {
            string conexao = @"server=127.0.0.1;uid=root;pwd=ifsp;database=supplyflow;ConnectionTimeout=1";

            string query = @"SELECT idProduto, descrição, quantidade_atual, quantidade_adequada
                         FROM Produto
                         WHERE quantidade_atual < quantidade_adequada";

            List<Produto> produtos = new List<Produto>();

            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        produtos.Add(new Produto
                        {
                            Id = reader.GetInt32("idProduto"),
                            Nome = reader.GetString("descrição"),
                            QuantidadeAtual = reader.GetInt32("quantidade_atual"),
                            QuantidadeAdequada = reader.GetInt32("quantidade_adequada")
                        });
                    }
                }
            }

            foreach (var p in produtos)
            {
                lboProdutos.Items.Add($"{p.Id} - {p.Nome} | Qtd: {p.QuantidadeAtual} / Ideal: {p.QuantidadeAdequada}");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
