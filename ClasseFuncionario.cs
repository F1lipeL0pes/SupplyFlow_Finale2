using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyFlow
{
    public class ClasseFuncionario
    {   
        private string nome, cargo, cpf, login, senha, telefone;
        private double salario;
        private DateTime dataAdm;

        public ClasseFuncionario(string nome, string cargo, string cpf, string login, string senha, string telefone, double salario, DateTime dataAdm)
        {
            this.nome = nome;
            this.cargo = cargo;
            this.cpf = cpf;
            this.login = login;
            this.senha = senha;
            this.telefone = telefone;
            this.salario = salario;
            this.dataAdm = dataAdm;
        }

        public string getNome() { return nome; }
        public string getCargo() { return cargo; }
        public DateTime getDataAdm() { return dataAdm; }
        public string getLogin() { return login; }
        public string getSenha() { return senha; }
        public string getTelefone() { return telefone; }
        public double getSalario() { return salario; }
        public string getCpf() { return cpf; }
    }
}
