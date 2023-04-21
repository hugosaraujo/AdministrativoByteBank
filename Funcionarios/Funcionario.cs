using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AdministrativoByteBank.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }
        public static int TotalDeFuncionarios { get; private set; }

        public Funcionario(string cpf, double salario)
        {
            this.Cpf = cpf;
            this.Salario = salario;
            TotalDeFuncionarios++;
            Console.WriteLine("Criando um funcionário");
        }
        public virtual double GetBonificacao ()
        {   
            return this.Salario * 0.10;
        }

        public virtual double PremiacaoSemestral() 
        {
            return this.Salario * 0.20;
        }

        public virtual void AcrescimoDeSalario()
        {
            this.Salario *= 1.10; 
        }
    
    }
}
