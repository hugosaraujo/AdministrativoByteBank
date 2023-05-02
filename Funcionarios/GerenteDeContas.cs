using AdministrativoByteBank.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrativoByteBank.Funcionarios
{
    public class GerenteDeContas:FuncionarioAutenticavel
    {
        public GerenteDeContas(string cpf, string usuario, string senha ):base(cpf, 4000, usuario, senha)
        {
            
        }

        public override double GetBonificacao()
        {
            return this.Salario *= 0.25;
        }

        public override void AcrescimoDeSalario()
        {
            this.Salario *= 1.05;
        }

        public override double PremiacaoSemestral()
        {
            return this.Salario *= 0.25;
        }

    }
}
