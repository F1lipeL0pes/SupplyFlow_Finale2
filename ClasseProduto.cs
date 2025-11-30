using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyFlow
{
    public class ClasseProduto
    {
        private string desc, categoria, uniMed;
        private int quantAtual, quantIdeal;
        private double preco;
        public ClasseProduto(string desc, string categoria, string uniMed, int quantAtual, int quantIdeal, double preco)
        {
            this.desc = desc;
            this.categoria = categoria;
            this.uniMed = uniMed;
            this.quantAtual = quantAtual;
            this.quantIdeal = quantIdeal;
            this.preco = preco;
        }
        public string getDesc() {  return desc; }
        public string getCategoria() { return categoria; }
        public int getQuantAtual() { return quantAtual; }
        public int getQuantIdeal() { return quantIdeal; }
        public double getPreco() { return preco; }
        public string getUniMed() { return uniMed; }
    }
}
