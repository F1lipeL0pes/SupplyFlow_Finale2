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
    public partial class frmEditarVenda : Form
    {
        private Admin admin;
        private int idUsuario;
        private string cargo;
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
    }
}
