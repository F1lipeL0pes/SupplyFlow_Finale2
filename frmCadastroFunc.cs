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
    public partial class frmCadastroFunc : Form
    {
        private Admin admin;
        private int idUsuario;
        private string cargo;
        public frmCadastroFunc(Admin admin, int idUsuario, string cargo)
        {
            InitializeComponent();
            this.admin = admin;
            this.idUsuario = idUsuario;
            this.cargo = cargo;
        }
        private void limpar()
        {
            txtNome.Clear();
            lboCargo.ClearSelected();
            txtCPF.Clear();
            txtDataAdm.Clear();
            txtLogin.Clear();
            txtSalario.Clear();
            txtSenha.Clear();
            txtTelefone.Clear();
            txtNome.Focus();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void cbVerSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (cbVerSenha.Checked)
            {
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome, cargo, cpf, login, senha, telefone;
            double salario = 0;
            DateTime dataAdm;

            if (txtNome.Text == "" || Convert.ToString(lboCargo.SelectedItem) == "" || txtCPF.Text == "" || txtSenha.Text == "" || txtTelefone.Text == "" || txtSalario.Text == "" || txtDataAdm.Text == "")
            {
                MessageBox.Show("Alguns dados não foram preenchidos.\nPreencha todos os dados!");
                return;
            }

            nome = txtNome.Text.Trim();
            cargo = Convert.ToString(lboCargo.SelectedItem).ToLower();
            login =  txtLogin.Text.Trim();
            senha = txtSenha.Text.Trim();
            cpf = txtCPF.Text.Trim();
            telefone = txtTelefone.Text.Trim();
            try
            {
                salario = Convert.ToDouble(txtSalario.Text.Trim());
            }
            catch (FormatException)
            {
                MessageBox.Show("Preenchido o salário com caracteres.\nRemova os caracteres e preencha com números!");
                return;
            }
            try
            {
                dataAdm = Convert.ToDateTime(txtDataAdm.Text.Trim());
            }
            catch (FormatException)
            {
                MessageBox.Show("Data incompatível.\nPreencha corretamente!");
                return;
            }

            try
            {
                ClasseFuncionario funcionario = new ClasseFuncionario(nome, cargo, cpf, login, senha, telefone, salario, dataAdm);
                admin.cadastrarFunc(funcionario);
                MessageBox.Show("Funcionário cadastrado com sucesso!");
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmGerente gerente = new frmGerente(admin, idUsuario, cargo);
            gerente.Show();
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
        private void btnEditarFuncionario_Click(object sender, EventArgs e)
        {

        }
    }
}
