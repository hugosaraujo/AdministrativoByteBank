using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrativoByteBank.Bonificacao
{
    public interface IBonificacao
    {
        public double GetBonificacao();

        public double PremiacaoSemestral();

        public void AcrescimoDeSalario();
    }
}
