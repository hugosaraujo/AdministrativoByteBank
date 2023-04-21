using AdministrativoByteBank.Funcionarios;
using AdministrativoByteBank.Utilitario;

Funcionario pep = new Funcionario("123.456.789-43", 2200.00);

pep.Nome = "Josep Guardiola";

Console.WriteLine($"Nome: {pep.Nome}");
Console.WriteLine($"Benefício: R$ {String.Format("{0:00.00}", pep.GetBonificacao())}");
Console.WriteLine($"Premiação Semestral: R$ {String.Format("{0:00.00}", pep.PremiacaoSemestral())}");

Diretor cg = new Diretor("999.998.765-21", 7500.00);
cg.Nome = "Carlos Gilberto Nascimento Silva";

Console.WriteLine($"Nome: {cg.Nome}");
Console.WriteLine($"Benefício: R$ {String.Format("{0:00.00}", cg.GetBonificacao())}");
Console.WriteLine($"Premiacão Semestral: R$ {String.Format("{0:00.00}", cg.PremiacaoSemestral())}");


var gerenciador = new GerenciadorDeSolucoes();

gerenciador.Registrar(cg);
gerenciador.Registrar(pep);

Console.WriteLine($"Total de Benefícios pagos: R$ {String.Format("{0:00.00}", gerenciador.BeneficiacaoTotal)}");
Console.WriteLine($"Total de Funcionários: {Funcionario.TotalDeFuncionarios}");
    
cg.AcrescimoDeSalario();
pep.AcrescimoDeSalario();

Console.WriteLine($"Novo salário do Josep: R${string.Format("{0:00.00}", cg.Salario)}");
Console.WriteLine($"Novo salário do Carlos Gilberto: R${string.Format("{0:00.00}", pep.Salario)}");







