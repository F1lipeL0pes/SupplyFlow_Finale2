using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyFlow
{
    public class ClasseInsumo
    {
        private int qtd, idProd, idCardapio;
        public ClasseInsumo(int qtd, int idProd, int idCardapio)
        {
            this.qtd = qtd;
            this.idProd = idProd;
            this.idCardapio = idCardapio;
        }

        public int getQtd() { return qtd; }
        public int getIdProd() { return idProd; }
        public int getIdCardapio() { return idCardapio; }

    }
}
