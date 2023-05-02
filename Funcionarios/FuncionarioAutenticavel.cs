using AdministrativoByteBank.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrativoByteBank.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticacao
    {
        public string Usuario { get; private set; }
        public string Senha { get; private set; }

        protected FuncionarioAutenticavel(string cpf, double salario, string usuario, string senha) : base(cpf, salario)
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
