using AdministrativoByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrativoByteBank.Utilitario
{
    public class GerenciadorDeSolucoes
    {
        public double BeneficiacaoTotal { get; private set; }

        public void Registrar (Funcionario f)
        {
            this.BeneficiacaoTotal += f.GetBonificacao(); 
        }
        public void Registrar (Diretor d)
        {
            this.BeneficiacaoTotal += d.GetBonificacao();
        }

        public double GetBonificacao() 
        {
            return this.BeneficiacaoTotal;
        }
    }
}
