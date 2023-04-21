using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrativoByteBank.Funcionarios
{
    public class Diretor:Funcionario
    {
        public Diretor(string cpf, double salario):base(cpf, salario)
        {
            //Console.WriteLine("Criando um diretor");
        }
        public override double GetBonificacao()
        {
            return this.Salario + base.GetBonificacao();
        }
        public override double PremiacaoSemestral()
        {
            return this.Salario + base.PremiacaoSemestral();
        }
        public override void AcrescimoDeSalario()
        {
            this.Salario *= 1.15; 
        }

    }
}
