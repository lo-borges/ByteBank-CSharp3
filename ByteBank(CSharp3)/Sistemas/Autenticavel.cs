using ByteBank_CSharp3_.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_CSharp3_.Sistemas
{
    public abstract class Autenticavel : Funcionario
    {
        public string Senha { get; set; }
        public Autenticavel(double salario, string cpf) : base (salario, cpf)
        { 
        }
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
