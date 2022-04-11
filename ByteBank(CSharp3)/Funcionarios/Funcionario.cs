using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_CSharp3_.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }
        public static int TotalDeFuncionarios { get; private set; }

        public Funcionario(double salario ,string cpf)
        {
            Console.WriteLine("Construtor de FUNCIONARIO");

            CPF = cpf;
            Salario = salario;

            TotalDeFuncionarios++;

        }

        public abstract void AumentarSalario();

        public abstract double GetBonificacao();
    }
}
