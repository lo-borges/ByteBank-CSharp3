using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_CSharp3_.Funcionarios
{
    public class Diretor : Funcionario
    {
        public override double GetBonificacao()
        {
            return Salario + base.GetBonificacao();
        }

        public Diretor(string cpf) : base(5000, cpf)
        {
            Console.WriteLine("Construtor de DIRETOR");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
    }
}
