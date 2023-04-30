using AdministrativoByteBank.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrativoByteBank.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, Autenticacao
    {
        public string Usuario { get; set; }
        public string Senha { get; set; }

        protected FuncionarioAutenticavel(string cpf, double salario) : base(cpf, salario)
        {
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
