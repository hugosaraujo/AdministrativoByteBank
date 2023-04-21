using System;
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
    }
}
