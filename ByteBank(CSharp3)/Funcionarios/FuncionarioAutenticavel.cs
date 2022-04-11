﻿using ByteBank_CSharp3_.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_CSharp3_.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public string Senha { get; set; }

        public FuncionarioAutenticavel(double salario, string cpf)
            :base(salario, cpf)
        { 

        }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
