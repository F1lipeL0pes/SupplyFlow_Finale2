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

namespace SupplyFlow
{
    public partial class frmRelatoriosVenda : Form
    {
        private Admin admin;
        private int idUsuario;
        private string cargo;
        public frmRelatoriosVenda(Admin admin, int idUsuario, string cargo)
        {
            InitializeComponent();
            this.admin = admin;
            this.idUsuario = idUsuario;
            this.cargo = cargo;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmGerente Gerente = new frmGerente(admin, idUsuario, cargo);
            Gerente.Show();
            this.Close();
        }

        public string BoxText(string titulo, string mensagem)
        {
            Form form = new Form();
            form.Width = 300;
            form.Height = 150;
            form.Text = titulo;
            form.StartPosition = FormStartPosition.CenterScreen;

            Label lbl = new Label() { Left = 10, Top = 20, Text = mensagem, Width = 260 };
            TextBox txt = new TextBox() { Left = 10, Top = 50, Width = 260 };
            Button btnOk = new Button() { Text = "OK", Left = 200, Width = 70, Top = 80, DialogResult = DialogResult.OK };

            form.Controls.Add(lbl);
            form.Controls.Add(txt);
            form.Controls.Add(btnOk);

            form.AcceptButton = btnOk;

            if (form.ShowDialog() == DialogResult.OK)
            {
                return txt.Text;
            }

            return null;
        }


        private void ShowDataTableInGrid(DataTable tabela, string titulo)
        {
            var frm = new Form
            {
                Text = titulo,
                StartPosition = FormStartPosition.CenterParent,
                Size = new Size(900, 500),
                MinimizeBox = false,
                MaximizeBox = true
            };

            var dgv = new DataGridView
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AutoGenerateColumns = true,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                DataSource = tabela
            };

            frm.Controls.Add(dgv);
            frm.ShowDialog(this);
        }

        

        private void btnRelatorioG_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tabela = admin.RelatoriaGeralV();

                if (tabela == null || tabela.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhuma venda encontrada no banco de dados.", "Relatório Geral", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                ShowDataTableInGrid(tabela, "Relatório Geral - Vendas");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar relatório geral de vendas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRelatorioData_Click(object sender, EventArgs e)
        {
            try
            {
                string input = BoxText("Pesquisa por Data", "Digite a data (dd/MM/yyyy):");
                if (string.IsNullOrWhiteSpace(input))
                    return;

                DateTime data;
                // Primeiro tenta formatos comuns (pt-BR), depois tenta parse genérico
                string[] formatos = new[] { "dd/MM/yyyy", "d/M/yyyy", "yyyy-MM-dd" };
                if (!DateTime.TryParseExact(input.Trim(), formatos, CultureInfo.GetCultureInfo("pt-BR"), DateTimeStyles.None, out data)
                    && !DateTime.TryParse(input.Trim(), CultureInfo.GetCultureInfo("pt-BR"), DateTimeStyles.None, out data))
                {
                    MessageBox.Show("Data inválida. Informe no formato dd/MM/yyyy.", "Data Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataTable tabela = admin.RelatorioPorData(data);

                if (tabela == null || tabela.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhuma venda encontrada para a data informada.", "Pesquisa por Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                ShowDataTableInGrid(tabela, $"Relatório - {data:dd/MM/yyyy}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar relatório por data: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void btnRelatorioGarcom_Click(object sender, EventArgs e)
        {
            try { 
                string garcom = BoxText("Pesquisa por Garçom", "Digite o nome do Garçom:");
                DataTable tabela = admin.RelatorioGarcom(garcom);

                    if (tabela == null || tabela.Rows.Count == 0)
                    {
                        MessageBox.Show("Nenhum Garçom com esse nome encontrado", "Pesquisa por Nome do Garçom", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    ShowDataTableInGrid(tabela, $"Resultados da Pesquisa: {garcom}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao pesquisar por Nome do Garçom: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        

    }
}

