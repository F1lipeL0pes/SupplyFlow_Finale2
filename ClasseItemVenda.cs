using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyFlow
{
    public class ClasseItemVenda
    {
        private int idVenda, quantidade, idPrato;
        public ClasseItemVenda(int idVenda, int quantidade, int idPrato)
        {
            this.idVenda = idVenda;
            this.quantidade = quantidade;
            this.idPrato = idPrato;
        }
        public int getIdVenda() { return idVenda; }
        public int getQuantidade() { return quantidade; }
        public int getIdPrato() { return idPrato; }

    }
}