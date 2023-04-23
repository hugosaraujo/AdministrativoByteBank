﻿using AdministrativoByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrativoByteBank.SistemaInterno
{
    public abstract class Autenticacao:Funcionario
    {
     
        public string Senha { get; set; }
        public abstract bool Autenticar(string senha);

        protected Autenticacao(string cpf, double salario) : base(cpf, salario)
        {
        }
    }
}
