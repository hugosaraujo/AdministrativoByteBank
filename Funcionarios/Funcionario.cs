using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AdministrativoByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }
        public static int TotalDeFuncionarios { get; private set; }
        public string Senha { get; set; }

        public Funcionario(string cpf, double salario)
        {
            this.Cpf = cpf;
            this.Salario = salario;
            TotalDeFuncionarios++;
            //Console.WriteLine("Criando um funcionário");
        }
        public abstract double GetBonificacao();

        public abstract double PremiacaoSemestral();

        public abstract void AcrescimoDeSalario();

        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }


    }
}
