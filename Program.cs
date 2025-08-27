//Screen Sound

string mensagemDeBoasVindas = "Bem vindo ao Flavio Sound";

void ExibirBoasVindas()
{
    Console.WriteLine(@"
    
███████╗██╗░░░░░░█████╗░██╗░░░██╗██╗░█████╗░  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██║░░░░░██╔══██╗██║░░░██║██║██╔══██╗  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
█████╗░░██║░░░░░███████║╚██╗░██╔╝██║██║░░██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
██╔══╝░░██║░░░░░██╔══██║░╚████╔╝░██║██║░░██║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██║░░░░░███████╗██║░░██║░░╚██╔╝░░██║╚█████╔╝  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═╝░░░░░╚══════╝╚═╝░░╚═╝░░░╚═╝░░░╚═╝░╚════╝░  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);
}


void ExibirOpcoesMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 0 para sair");

    Console.WriteLine("Digite a sua opção : ");
    Console.ReadLine();
}


ExibirBoasVindas();
ExibirOpcoesMenu();