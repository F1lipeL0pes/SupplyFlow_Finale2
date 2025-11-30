using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupplyFlow
{
    public partial class frmVendasGarcom : Form
    {
        private Admin admin;
        private int idUsuario;
        private string cargo;
        public frmVendasGarcom(Admin admin, int idUsuario, string cargo)
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

        public class FVMP
        {
            public int idUsuario;
            public string nome;
            public int idVenda;
            public int numero;
            public DateTime data_venda;
            public TimeSpan hora_venda;
            public double? valor;
        }

        private void frmVendasGarcom_Load(object sender, EventArgs e)
        {
            try
            {
                string conexao = @"server=127.0.0.1;uid=root;pwd=1234;database=supplyflow;ConnectionTimeout=1";

                string query = @"SELECT f.idUsuario, f.nome, v.idVenda, v.data_venda, v.hora_venda, m.numero, p.valor
                            from Funcionario as f INNER JOIN Venda as v ON f.idUsuario = v.idUsuario
                            INNER JOIN Mesa as m ON v.idMesa = m.idMesa
                            LEFT JOIN Pagamento as p ON v.idVenda = p.idVenda
                            WHERE v.data_venda = CURDATE() AND f.idUsuario = @id";

                List<FVMP> fvmp = new List<FVMP>();

                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idUsuario);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                double? val = null;
                                int idxValor = reader.GetOrdinal("valor");
                                if (!reader.IsDBNull(idxValor))
                                    val = reader.GetDouble(idxValor);
                                fvmp.Add(new FVMP
                                {
                                    idUsuario = reader.GetInt32("idUsuario"),
                                    nome = reader.GetString("nome"),
                                    idVenda = reader.GetInt32("idVenda"),
                                    numero = reader.GetInt32("numero"),
                                    data_venda = reader.GetDateTime("data_venda"),
                                    hora_venda = reader.GetTimeSpan("hora_venda"),
                                    valor = val
                                });
                            }
                            foreach (var rel in fvmp)
                            {
                                lboVendas.Items.Add($"Id: {rel.idUsuario} - Nome: {rel.nome} | idVenda: {rel.idVenda} | Número da Mesa: {rel.numero} | Data da Venda: {rel.data_venda.ToString("dd/MM/yyyy")} | Hora da Venda: {rel.hora_venda} | Valor: {rel.valor}");
                            }
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
