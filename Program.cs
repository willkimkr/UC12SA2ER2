using CadastroPessoa.Classes;

Console.Clear();
Console.WriteLine(@$"
============================================
|    Bem vindo ao sistema de cadastro de   |
|       Pessoas Fisicas e Juridicas        |
============================================
");


Utils.BarraCarregamento("Iniciando", 500, 20);

List<PessoaFisica> listaPf = new List<PessoaFisica>();

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
            string? opcaoPf;
            do
            {
                Console.Clear();
                Console.WriteLine(@$"
============================================
|      Escolha uma das opcoes abaixo       |
|------------------------------------------|
|        1 - Cadastrar Pessoa Fisica       |          
|        2 - Listar Pessoa Fisica          |
|                                          |
|        0 - Voltar ao menu anterior       |
============================================
");


                opcaoPf = Console.ReadLine();
                PessoaFisica metodosPf = new PessoaFisica();

                switch (opcaoPf)
                {
                    case "1":
                        PessoaFisica novaPf = new PessoaFisica();
                        Endereco novoEndPf = new Endereco();

                        Console.WriteLine($"Digite o nome da pessoa fisica que deseja cadastrar");
                        novaPf.Nome = Console.ReadLine();

                        bool dataValida;
                        do
                        {
                            Console.WriteLine($"Digite a data de nascimento Ex:DD/MM/AAAA");
                            string? dataNascimento = Console.ReadLine();

                            dataValida = metodosPf.ValidarDataNasc(dataNascimento);

                            if (dataValida)
                            {
                                DateTime DataConvertida;
                                DateTime.TryParse(dataNascimento, out DataConvertida);

                                novaPf.dataNasc = DataConvertida;

                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine($"Data digitada invalida, por favor digite uma data valida");
                                Console.ResetColor();
                                Thread.Sleep(2000);
                            }

                        } while (dataValida == false);

                        Console.WriteLine($"Digite o numero do CPF");
                        novaPf.Cpf = Console.ReadLine();

                        Console.WriteLine($"Digite o rendimento mensal(DIGITE SOMENTE NUMEROS)");
                        novaPf.Rendimento = float.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o logradouro");
                        novoEndPf.logradouro = Console.ReadLine();

                        Console.WriteLine($"Digite o numero");
                        novoEndPf.numero = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o complemento (Aperte ENTER para vazio)");
                        novoEndPf.complemento = Console.ReadLine();

                        Console.WriteLine($"Este endereco e comercial? S/N");
                        string endCom = Console.ReadLine().ToUpper();

                        if (endCom == "S")
                        {
                            novoEndPf.endComercial = true;
                        }
                        else
                        {
                            novoEndPf.endComercial = false;
                        }

                        novaPf.Endereco = novoEndPf;

                        listaPf.Add(novaPf);

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Cadastro realizado com sucesso");
                        Console.ResetColor();
                        Thread.Sleep(2000);

                        break;
                                                                
                    case "2":

                        Console.Clear();

                        if (listaPf.Count > 0)
                        {
                           
                            foreach (PessoaFisica cadaPessoa in listaPf)
                            {
                                Console.Clear();
                                Console.WriteLine(@$"
Nome: {cadaPessoa.Nome}
Endereco: {cadaPessoa.Endereco.logradouro}, {cadaPessoa.Endereco.numero}
Imposto a ser pago: {metodosPf.PagarImposto(cadaPessoa.Rendimento).ToString("C")}
");                            
                                Console.WriteLine($"Aperte 'ENTER' para continuar");
                                Thread.Sleep(2000);
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Lista vazaia");
                            Thread.Sleep(2000);
                        }
                        
                        break;
                   
                    case "0":
                        break;

                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"Opcao Invalida, por favor digite uma opcao valida");
                        Console.ResetColor();
                        Thread.Sleep(2000);
                        break;
                }

            } while (opcaoPf != "0");

            // condicao ? "sim" : "nao"
            // Console.WriteLine($"Nome: {novaPf.Nome} Nome: {novaPf.Nome}");
            // Console.WriteLine("Nome: " + novaPf.Nome + " Nome: " + novaPf.Nome);

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
CNPJ: {novaPj.Cnpj}, Valido: {(metodosPj.ValidarCnpj(novaPj.Cnpj) ? "sim" : "nao")}
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



