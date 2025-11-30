using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyFlow
{
    public class ClassePagamento
    {
        private int idVenda;
        private string tipo, status;
        private double valor;
        private DateTime dataHora;
        public ClassePagamento(int idVenda, string tipo, string status, double valor, DateTime dataHora)
        {
            this.idVenda = idVenda;
            this.tipo = tipo;
            this.status = status;
            this.valor = valor;
            this.dataHora = dataHora;
        }
        public int getIdVenda() { return idVenda; }
        public string getTipo() { return tipo; }
        public double getValor() { return valor; }
        public DateTime getDataHora() { return dataHora; }
        public string getStatus() { return status; }

    }
}
