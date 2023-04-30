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
        public string Usuario { get; set; }
        public string Senha { get;  set; }
        public bool AutenticarUsuario(string usuario);
        public bool AutenticarSenha(string senha);



    }
}
