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
    public partial class frmEditarProduto : Form
    {
        private Admin admin;
        private bool isEditing = false;
        private int idUsuario;
        private string cargo;
        public frmEditarProduto(Admin admin, int idusuario, string cargo)
        {
            this.admin = new Admin();
            InitializeComponent();

            // registra evento: quando o usuário sair do txtId, tenta preencher campos
            this.txtId.Leave += new EventHandler(this.txtId_Leave);
            this.idUsuario = idusuario;
            this.cargo = cargo;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmEstoque estoque = new frmEstoque(admin, idUsuario, cargo);
            estoque.Show();
            this.Close();
        }

        // Ao perder foco do campo ID busca no banco e preenche campos
        private void txtId_Leave(object sender, EventArgs e)
        {
            int id;
            string idText = txtId.Text.Trim();
            if (string.IsNullOrEmpty(idText))
                return;

            if (!int.TryParse(idText, out id) || id <= 0)
            {
                MessageBox.Show("Informe um ID numérico válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataTable dt = admin.GetProdutoById(id);
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("Produto não encontrado para o ID: " + id, "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // opcional: limpar campos se não encontrado
                // LimparCampos();
                return;
            }

            DataRow row = dt.Rows[0];
            txtNome.Text = Convert.ToString(row["Descricao"]);
            txtCategoria.Text = Convert.ToString(row["categoria"]);
            txtQtd.Text = Convert.ToString(row["QuantidadeAtual"]);
            txtQtdIdeal.Text = Convert.ToString(row["QuantidadeAdequada"]);
            txtUniMed.Text = Convert.ToString(row["UnidadeMedida"]);
            mtxtPreco.Text = Convert.ToString(row["PrecoCompra"]);

            isEditing = false;
            btnEditar.Text = "Editar";
            SetFieldsEditable(false);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txtId.Text.Trim(), out id) || id <= 0)
            {
                MessageBox.Show("Informe um ID válido para excluir.", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var confirmar = MessageBox.Show("Confirma exclusão do produto com ID " + id + "?", "Confirmar exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmar == DialogResult.Yes)
            {
                bool excluiu = admin.DeleteProdutoById(id);
                if (excluiu)
                {
                    MessageBox.Show("Produto excluído com sucesso.", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Limpa campos após exclusão
                    txtId.Clear();
                    txtNome.Clear();
                    txtCategoria.Clear();
                    txtQtd.Clear();
                    txtQtdIdeal.Clear();
                    txtUniMed.Clear();
                    mtxtPreco.Clear();
                }
                else
                {
                    MessageBox.Show("Falha ao excluir. Verifique se o produto existe.", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Ativa/desativa edição dos campos do produto
        private void SetFieldsEditable(bool editable)
        {
            txtNome.ReadOnly = !editable;
            txtCategoria.ReadOnly = !editable;
            txtQtd.ReadOnly = !editable;
            txtQtdIdeal.ReadOnly = !editable;
            txtUniMed.ReadOnly = !editable;
            mtxtPreco.ReadOnly = !editable;
            // Se desejar, pode mudar a aparência para indicar bloqueado:
            txtNome.BackColor = editable ? SystemColors.Window : SystemColors.Control;
            txtCategoria.BackColor = editable ? SystemColors.Window : SystemColors.Control;
            txtQtd.BackColor = editable ? SystemColors.Window : SystemColors.Control;
            txtQtdIdeal.BackColor = editable ? SystemColors.Window : SystemColors.Control;
            txtUniMed.BackColor = editable ? SystemColors.Window : SystemColors.Control;
            mtxtPreco.BackColor = editable ? SystemColors.Window : SystemColors.Control;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txtId.Text.Trim(), out id) || id <= 0)
            {
                MessageBox.Show("Informe um ID válido antes de editar.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!isEditing)
            {
                // habilita edição
                isEditing = true;
                btnEditar.Text = "Salvar";
                SetFieldsEditable(true);
                txtNome.Focus();
                return;

                // modo salvar: validar campos e enviar update
                string nome = txtNome.Text.Trim();
                string categoria = txtCategoria.Text.Trim();
                string uniMed = txtUniMed.Text.Trim();
                int qtd, qtdIdeal;
                double preco;

                if (string.IsNullOrWhiteSpace(nome))
                {
                    MessageBox.Show("Nome não pode ficar vazio.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNome.Focus();
                    return;
                }
                if (!int.TryParse(txtQtd.Text.Trim(), out qtd))
                {
                    MessageBox.Show("Quantidade atual inválida.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtQtd.Focus();
                    return;
                }
                if (!int.TryParse(txtQtdIdeal.Text.Trim(), out qtdIdeal))
                {
                    MessageBox.Show("Quantidade ideal inválida.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtQtdIdeal.Focus();
                    return;
                }

                // tenta converter preço, removendo símbolos comuns
                string precoRaw = mtxtPreco.Text.Trim();
                precoRaw = precoRaw.Replace("R$", "").Replace("$", "").Replace(" ", "");
                // aceita vírgula ou ponto como separador
                precoRaw = precoRaw.Replace(",", ".");
                if (!double.TryParse(precoRaw, NumberStyles.Any, CultureInfo.InvariantCulture, out preco))
                {
                    MessageBox.Show("Preço inválido.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mtxtPreco.Focus();
                    return;
                }
                bool atualizado = admin.UpdateProdutoById(id, nome, categoria, qtd, qtdIdeal, uniMed, preco);
                if (atualizado)
                {
                    MessageBox.Show("Produto atualizado com sucesso.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isEditing = false;
                    btnEditar.Text = "Editar";
                    SetFieldsEditable(false);
                }
                else
                {
                    MessageBox.Show("Falha ao atualizar produto. Verifique se o ID existe.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
