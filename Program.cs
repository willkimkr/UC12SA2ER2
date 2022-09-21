using CadastroPessoa.Classes;
Console.Clear();
Console.WriteLine(@$"
============================================
|    Bem vindo ao sistema de cadastro de   |
|       Pessoas Fisicas e Juridicas        |
============================================
");

Utils.BarraCarregamento("Iniciando", 100, 40);

string? opcao;
do
{
    Console.Clear();
    Console.WriteLine(@$"
============================================
|      Escolha uma das opcoes abaixo       |
|------------------------------------------|
|           1 - Pessoa Fisica              |
|           2 - Pessoa Juridica            |
|                                          |
|           0 - sair                       |
============================================
");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            PessoaFisica novaPf = new PessoaFisica();
            PessoaFisica metodosPf = new PessoaFisica();
            Endereco novoEndPf = new Endereco();

            novaPf.Nome = "willian";
            novaPf.dataNasc = new DateTime(2000, 01, 01);
            novaPf.Cpf = "1234567890";
            novaPf.Rendimento = 3500.5f;

            novoEndPf.logradouro = "Alameda barao de limeira";
            novoEndPf.numero = 593;
            novoEndPf.complemento = "SENAI informatica";
            novoEndPf.endComercial = true;

            novaPf.Endereco = novoEndPf;


            Console.Clear();
            Console.WriteLine(@$"
Nome: {novaPf.Nome}
Endereco: {novaPf.Endereco.logradouro}, {novaPf.Endereco.numero}
Maior de idade: {(metodosPf.ValidarDataNasc(novaPf.dataNasc)? "sim":"nao")}
Imposto a ser pago: {metodosPf.PagarImposto(novaPf.Rendimento).ToString("C")}
");
            // condicao ? "sim" : "nao"
            // Console.WriteLine($"Nome: {novaPf.Nome} Nome: {novaPf.Nome}");
            // Console.WriteLine("Nome: " + novaPf.Nome + " Nome: " + novaPf.Nome);

            Console.WriteLine($"Aperte ENTER para continuar");
            Console.ReadLine();



            break;

        case "2":
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
            Console.Clear();
            Console.WriteLine(@$"
Nome: {novaPj.Nome}
Razao social: {novaPj.RazaoSocial}
CNPJ: {novaPj.Cnpj}, Valido: {(metodosPj.ValidarCnpj(novaPj.Cnpj)? "sim" : "nao")}
Endereco: {novaPj.Endereco.logradouro}, Nº: {novaPj.Endereco.numero}
Complemento: {novaPj.Endereco.complemento}
");
            Console.WriteLine($"Aperte ENTER para continuar");
            Console.ReadLine();

            break;

        case "0":
            Console.Clear();
            Console.WriteLine($"Obrigado por utilizar nosso sistema!");
            Thread.Sleep(3000);

            Utils.BarraCarregamento("Finalizando", 500, 6);
            

            break;

        default:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Opcao Invalida, por favor digite uma opcao valida");
            Console.ResetColor();
            Thread.Sleep(3000);
            break;
    }

} while (opcao != "0");
// static void BarraCarregamento(string texto, int tempo, int quantidade)
// {
//     Console.BackgroundColor = ConsoleColor.Green;
//     Console.ForegroundColor = ConsoleColor.DarkBlue;

//     Console.WriteLine(texto);
//     for (var contador = 0; contador < quantidade; contador++)
//     {
//         Console.WriteLine(".");
//         Thread.Sleep(500);
//     }
//     Console.ResetColor();
// }


//Console.WriteLine(metodosPf.ValidarDataNasc(novaPf.dataNasc));

//Console.WriteLine(novaPf.Nome);



