using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyFlow
{
    public class idNaoEncontradoException : Exception
    {
        public idNaoEncontradoException() { }
        public idNaoEncontradoException(string message) : base(message) { }
    }
}
