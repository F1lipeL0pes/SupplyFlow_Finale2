using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Org.BouncyCastle.Math.EC;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace SupplyFlow
{
    public partial class frmRelatoriosEst : Form
    {
        private Admin admin;
        private int idUsuario;
        private string cargo;
        public frmRelatoriosEst(Admin admin, int idUsuario, string cargo)
        {
            this.admin = admin;
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.cargo = cargo;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmEstoque estoque = new frmEstoque(admin, idUsuario, cargo);
            estoque.Show();
            this.Close();
        }

        private void btnRelatorioNome_Click(object sender, EventArgs e)
        {
           
            try
            {
                string nome = BoxText("Pesquisa por Nome do produto", "Digite o nome do produto:");

                DataTable tabela = admin.RelatorioNome(nome);

                if (tabela == null || tabela.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum produto encontrado no banco de dados.", "Relatório por Nome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                ShowDataTableInGrid(tabela, "Relatório por Nome - Produtos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar relatório por nome: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRelatorioG_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tabela = admin.RelatoriaGeral();

                if (tabela == null || tabela.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum produto encontrado no banco de dados.", "Relatório Geral", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                ShowDataTableInGrid(tabela, "Relatório Geral - Produtos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar relatório geral: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

            var dge = new DataGridView
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AutoGenerateColumns = true,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                DataSource = tabela
            };

            frm.Controls.Add(dge);
            frm.ShowDialog(this);
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


        private void btnRelatorioCat_Click(object sender, EventArgs e)
        {
            try
            {
                string categoria = BoxText("Pesquisa por Categoria", "Digite a categoria do produto:");

                DataTable tabela = admin.RelatorioCategoria(categoria);

                if (tabela == null || tabela.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum produto encontrado para essa categoria.", "Pesquisa por Categoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                ShowDataTableInGrid(tabela, $"Resultados da Categoria: {categoria}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao pesquisar por categoria: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }
    



           

