namespace DesafiosRocketseat;

public class Desafio2
{
    public void show()
    {
        string nome;
        string sobreNome;

        Console.WriteLine("\nDigite seu primeiro nome:");
        nome = Console.ReadLine() ?? " ";
        Console.WriteLine("\nDigite seu sobrenome:");
        sobreNome = Console.ReadLine() ?? " ";
        
        Console.WriteLine($"\nBem-vindo, {nome} {sobreNome}!");

        Console.WriteLine("\nDigite '1' para executar novamente ou '0' para voltar ao menu principal.");
        string opcao = Console.ReadLine() ?? " ";
        if (opcao == "1")
        {
            show();
        }
        else if (opcao == "0")
        {
            Menu menu = new();
            menu.show();
        }
    }
}