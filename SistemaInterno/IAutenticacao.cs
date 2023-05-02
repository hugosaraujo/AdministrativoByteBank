using AdministrativoByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrativoByteBank.SistemaInterno
{
    public interface IAutenticacao
    {
        public bool AutenticarUsuario(string usuario);
        public bool AutenticarSenha(string senha);

    }
}
