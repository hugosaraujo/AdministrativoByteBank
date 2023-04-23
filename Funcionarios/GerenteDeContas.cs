﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrativoByteBank.Funcionarios
{
    public class GerenteDeContas:Funcionario
    {
        public GerenteDeContas(string cpf):base(cpf, 4000)
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
