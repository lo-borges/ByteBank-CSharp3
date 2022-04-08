using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_CSharp3_.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }
        public static int TotalDeFuncionarios { get; private set; }

        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }

        public Funcionario(double salario ,string cpf)
        {
            TotalDeFuncionarios++;
            CPF = cpf;
            Salario = salario;
            Console.WriteLine("Construtor de FUNCIONARIO");
        }

        public virtual void AumentarSalario()
        {
            Salario *= 1.1;
        }
    }
}
