using AdministrativoByteBank.Funcionarios;
using AdministrativoByteBank.Utilitario;

Funcionario f = new Funcionario();

f.Nome = "Josep Guardiola";
f.Cpf = "123.456.789-43";
f.Salario = 2200.00;

Console.WriteLine($"Nome: {f.Nome}");
Console.WriteLine(f.GetBonificacao());  

Diretor cg = new Diretor();
cg.Nome = "Carlos Gilberto Nascimento Silva";
cg.Cpf = "999.998.765-21";
cg.Salario = 7500;

Console.WriteLine($"Nome: {cg.Nome}");
Console.WriteLine(cg.GetBonificacao());

GerenciadorDeSolucoes gerenciador = new GerenciadorDeSolucoes();

gerenciador.Registrar(cg);
gerenciador.Registrar(f);

Console.WriteLine($"Total de Beficios pagos: R${gerenciador.BeneficiacaoTotal}");
