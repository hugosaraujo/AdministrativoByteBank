using AdministrativoByteBank.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AdministrativoByteBank.Parceiros
{
    public class ParceiroComercial : IAutenticacao
    {
        public string Usuario { get ; private set ; }
        public string Senha { get ; private set ; }

        public ParceiroComercial(string usuario, string senha)
        {
            this.Usuario = usuario;
            this.Senha = senha;
        }

        public bool AutenticarSenha(string senha)
        {
            return this.Senha == senha; 
        }

        public bool AutenticarUsuario(string usuario)
        {
            return this.Usuario == usuario; 
        }
    }
}
