using CadastroPessoa.Classes;

// PessoaFisica novaPf = new PessoaFisica();
// PessoaFisica metodosPf = new PessoaFisica();
// Endereco novoEndPf = new Endereco();

// novaPf.Nome= "willian";
// novaPf.dataNasc = new DateTime(2000,01,01);
// novaPf.Cpf = "1234567890";
// novaPf.Rendimento = 3500.5f;

// novoEndPf.logradouro = "Alameda barao de limeira";
// novoEndPf.numero = 593;
// novoEndPf.complemento = "SENAI informatica";
// novoEndPf.endComercial = true;

// novaPf.Endereco = novoEndPf;


// Console.WriteLine(@$"
// Nome: {novaPf.Nome}
// Endereco: {novaPf.Endereco.logradouro}, {novaPf.Endereco.numero}
// Maior de idade: {metodosPf.ValidarDataNasc(novaPf.dataNasc)}");



//Console.WriteLine(metodosPf.ValidarDataNasc(novaPf.dataNasc));

//Console.WriteLine(novaPf.Nome);

//Console.WriteLine($"Nome: {novaPf.Nome} Nome: {novaPf.Nome}");
//Console.WriteLine("Nome: " + novaPf.Nome +  " Nome: " + novaPf.Nome);

PessoaJuridica novaPj = new PessoaJuridica();
PessoaJuridica metodosPj = new PessoaJuridica();
Endereco novoEndPj = new Endereco();

novaPj.Nome = "Nome Pj";
novaPj.RazaoSocial = "Razao Social Pj";
novaPj.Cnpj = "00000000000100";
novaPj.Rendimento = 10000.5f;

novoEndPj.logradouro = "Alameda barao de Limeira";
novoEndPj.numero = 539;
novoEndPj.complemento = "SENAI Informatica";
novoEndPj.endComercial = true;

novaPj.Endereco = novoEndPj;

// Console.WriteLine(metodosPj.ValidarCnpj(novaPj.Cnpj));
Console.WriteLine(@$"
Nome: {novaPj.Nome}
Razao social: {novaPj.RazaoSocial}
CNPJ: {novaPj.Cnpj}, Valido: {metodosPj.ValidarCnpj(novaPj.Cnpj)}
Endereco: {novaPj.Endereco.logradouro}, Nº: {novaPj.Endereco.numero}
Complemento: {novaPj.Endereco.complemento}
");
