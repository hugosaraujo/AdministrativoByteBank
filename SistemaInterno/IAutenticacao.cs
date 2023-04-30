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
        public string Usuario { get; protected set; }
        public string Senha { get; protected set; }
        public abstract bool AutenticarUsuario(string usuario);
        public abstract bool AutenticarSenha(string senha);


    }
}
