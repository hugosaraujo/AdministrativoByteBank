﻿using AdministrativoByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrativoByteBank.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(Autenticacao funcionario,string usuario, string senha) 
        {
            bool senhaAutenticada = funcionario.AutenticarSenha(senha);
            bool usuarioAutenticado = funcionario.AutenticarUsuario(usuario);
            
            if (usuarioAutenticado && senhaAutenticada)
            {
                Console.WriteLine("Bem vindo ao sistema!");
                return true;
            }
            else
            {
                Console.WriteLine("Não foi possível reconhecer senha ou usuário. Por favor, tente novamente...");
                return false; 
            }
        }
    }
}
