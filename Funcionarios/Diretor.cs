using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrativoByteBank.Funcionarios
{
    public class Diretor:Funcionario
    {
        public Diretor(string cpf):base(cpf, 5000)
        {
            //Console.WriteLine("Criando um diretor");
        }
        public override double GetBonificacao()
        {
            return this.Salario *= 0.50;
        }
        public override double PremiacaoSemestral()
        {
            return this.Salario *= 1;
        }
        public override void AcrescimoDeSalario()
        {
            this.Salario *= 1.15; 
        }
    }
}
