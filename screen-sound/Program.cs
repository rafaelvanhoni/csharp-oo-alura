/* Alura - Aprenda a programar em C# com Orientação a Objetos
 * 
 * Projeto: 01 - Screen Sound
 * 
 * Rafael Vanhoni 07/2023 */


string mensagemDeBoasVindas = "Boas vindas ao Screen Sound!";

//List<string> listaDasBandas = new List<string> { "Ratos de Porão", "No Fun At All" } ;
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();

bandasRegistradas.Add("NOFX", new List<int> { 10, 10, 9 });
bandasRegistradas.Add("Ratos de Porão", new List<int> { 10, 10, 9, 9 });
bandasRegistradas.Add("Iron Maiden", new List<int>());

//List<string> listaDasBandas = List<string>;

void ExibirLogo()
{
    // caracteres especiais retirados do site https://fsymbols.com
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);

    Console.WriteLine();
}

void ExibirOpcoesDoMenu()
{

    ExibirLogo();

    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarAsBandasRegistradas();
            break;
        case 3:
            AvaliarUmaBanda();
            break;
        case 4:
            ExibirMediaDaBanda();
            break;
        case -1:
            Console.WriteLine("Você escolheu a opção -1");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }


}

void ExibirTituloDaOpcao(string titulo)
{

    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');

    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void RegistrarBanda()
{

    Console.Clear();

    ExibirTituloDaOpcao("Registro de bandas");

    Console.Write("Digite o nome da banda que deseja registrar: ");

    string nomeDaBanda = Console.ReadLine()!;

    //listaDasBandas.Add(nomeDaBanda);
    bandasRegistradas.Add(nomeDaBanda, new List<int>());

    Console.WriteLine($"\nA banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);

    Console.Clear();

    ExibirOpcoesDoMenu();
}

void MostrarAsBandasRegistradas()
{

    Console.Clear();

    ExibirTituloDaOpcao("Exibindo todas as bandas registradas");


    //    for (int i = 0; i < listaDasBandas.Count; i++)
    //    {
    //        Console.WriteLine($"Banda: {listaDasBandas[i]}.");
    //    }

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}.");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal.");
    Console.ReadKey();
    Console.Clear();

    ExibirOpcoesDoMenu();
}

void AvaliarUmaBanda()
{
    // digite qual banda deseja avaliar
    // se a banda existir no dicionário
    // atribuir uma nota
    // senão, volta ao menu principal

    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);

        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }


}

void ExibirMediaDaBanda()
{
    Console.Clear();

    ExibirTituloDaOpcao("Exibir média da Banda");

    Console.WriteLine("Digite o nome da banda que deseja Exibir a Média");

    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"\n A média da banda {nomeDaBanda} é {notasDaBanda.Average()}.");
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
    }

    Console.WriteLine("Digite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();

}

ExibirOpcoesDoMenu();