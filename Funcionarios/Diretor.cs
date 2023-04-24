using AdministrativoByteBank.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrativoByteBank.Funcionarios
{
    public class Diretor:Autenticacao
    {

        public Diretor(string cpf):base(cpf, 5000)
        {
            //Console.WriteLine("Criando um diretor");
        }
        public override double GetBonificacao()
        {
            return this.Salario *= 0.50;
        }
        public override double PremiacaoSemestral()
        {
            return this.Salario *= 1;
        }
        public override void AcrescimoDeSalario()
        {
            this.Salario *= 1.15; 
        }

        public override bool AutenticarUsuario(string usuario)
        {
            return this.Usuario == usuario;
        }

        public override bool AutenticarSenha(string senha) 
        {
            return this.Senha == senha; 
        }
    }
}
