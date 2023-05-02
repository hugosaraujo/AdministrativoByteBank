using AdministrativoByteBank.Bonificacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AdministrativoByteBank.Funcionarios
{
    public abstract class Funcionario : IBonificacao
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; set; }
        public static int TotalDeFuncionarios { get; private set; }

        public Funcionario(string cpf, double salario)
        {
            this.Cpf = cpf;
            this.Salario = salario;
            TotalDeFuncionarios++;
            //Console.WriteLine("Criando um funcionário");
        }

        protected Funcionario()
        {
        }

        public abstract double GetBonificacao();

        public abstract double PremiacaoSemestral();

        public abstract void AcrescimoDeSalario();

    }
}
