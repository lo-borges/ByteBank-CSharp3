using ByteBank_CSharp3_.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_CSharp3_.Sistemas
{
    public interface IAutenticavel
    {
        bool Autenticar(string senha);
    }
}

