using AdministrativoByteBank.Funcionarios;
using AdministrativoByteBank.Utilitario;
using System.ComponentModel;
using System.Data.Common;


#region
//Funcionario pep = new Funcionario("123.456.789-43", 2200.00);

//pep.Nome = "Josep Guardiola";

//Console.WriteLine($"Nome: {pep.Nome}");
//Console.WriteLine($"Benefício: R$ {String.Format("{0:00.00}", pep.GetBonificacao())}");
//Console.WriteLine($"Premiação Semestral: R$ {String.Format("{0:00.00}", pep.PremiacaoSemestral())}");

//Diretor cg = new Diretor("999.998.765-21", 7500.00);
//cg.Nome = "Carlos Gilberto Nascimento Silva";

//Console.WriteLine($"Nome: {cg.Nome}");
//Console.WriteLine($"Benefício: R$ {String.Format("{0:00.00}", cg.GetBonificacao())}");
//Console.WriteLine($"Premiacão Semestral: R$ {String.Format("{0:00.00}", cg.PremiacaoSemestral())}");

//var gerenciador = new GerenciadorDeSolucoes();

//gerenciador.Registrar(cg);
//gerenciador.Registrar(pep);

//Console.WriteLine($"Total de Benefícios pagos: R$ {String.Format("{0:00.00}", gerenciador.BeneficiacaoTotal)}");
//Console.WriteLine($"Total de Funcionários: {Funcionario.TotalDeFuncionarios}");

//cg.AcrescimoDeSalario();
//pep.AcrescimoDeSalario();

//Console.WriteLine($"Novo salário do Josep: R${string.Format("{0:00.00}", cg.Salario)}");
//Console.WriteLine($"Novo salário do Carlos Gilberto: R${string.Format("{0:00.00}", pep.Salario)}");
#endregion
void CalcularBonificacao()
{
    GerenciadorDeSolucoes gerenciador = new GerenciadorDeSolucoes();

    Diretor gz = new Diretor("998.102.460-10");
    gz.Nome = "Gabriela Maria Zanotti Demoner";

    Designer t = new Designer("201.980.160-36");
    t.Nome = "Tamires Cássia Dias Gomes";

    GerenteDeContas fs = new GerenteDeContas("067.160.311-06");
    fs.Nome = "Fabio Santos Romeu";

    Auxiliar r = new Auxiliar("290.538.641-29");

    r.Nome = "Roni Medeiros de Moura";

    //gerenciador.Registrar(gz);
    //gerenciador.Registrar(t);
    //gerenciador.Registrar(fs);
    //gerenciador.Registrar(r);

    //Console.WriteLine($"Total pago em bonificações pela empresa: " +
    //    $" R$ {String.Format("{0:00.00}", gerenciador.BeneficiacaoTotal)}")

    Auxiliar.

}




Console.ReadLine();








