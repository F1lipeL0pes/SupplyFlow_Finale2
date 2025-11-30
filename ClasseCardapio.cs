using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyFlow
{
    public class ClasseCardapio
    {
        private string nome, desc, categoria;
        private double preco;

        public ClasseCardapio(string nome, string desc, string categoria, double preco)
        {
            this.nome = nome;
            this.desc = desc;
            this.categoria = categoria;
            this.preco = preco;
        }
        public string getNome() { return nome; }
        public string getDesc() { return desc; }
        public double getPreco() { return preco; }
        public string getCategoria() { return categoria; }

    }
}
