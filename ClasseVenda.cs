using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyFlow
{
    public class ClasseVenda
    {
        private DateTime data;
        private TimeSpan hora;
        private int idUsuario, idMesa;
        public ClasseVenda(DateTime data, TimeSpan hora, int idUsuario, int idMesa) 
        {
            this.data = data;
            this.hora = hora;
            this.idUsuario = idUsuario;
            this.idMesa = idMesa;
        }
        public DateTime getData() { return data; }
        public int getIdUsuario() { return idUsuario; }
        public int getIdMesa() { return idMesa; }
        public TimeSpan getHora() { return hora; }

    }
}
