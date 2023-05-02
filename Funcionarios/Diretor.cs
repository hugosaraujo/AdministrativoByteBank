using AdministrativoByteBank.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrativoByteBank.Funcionarios
{
    public class Diretor:FuncionarioAutenticavel
    {
        public Diretor(string cpf, string usuario, string senha ):base(cpf, 5000, usuario, senha)
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
