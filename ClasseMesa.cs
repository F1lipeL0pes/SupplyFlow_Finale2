using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyFlow
{
    public class ClasseMesa
    {
        private int num, capacidade;
        private string status;
        public ClasseMesa(int num, int capacidade, string status)
        {
            this.num = num;
            this.capacidade = capacidade;
            this.status = status;
        }
        public int getNum() { return num; }
        public int getCapacidade() { return capacidade; }
        public string getStatus() { return status; }
    }
}
