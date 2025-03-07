using System.Diagnostics.Metrics;

namespace DesafiosRocketseat;

public class Desafio4
{    public void show()
    {
        string palavras;

        Console.WriteLine("\nDigite uma palavra:");
        palavras = Console.ReadLine() ?? " ";

        int charCount = palavras.Length;

        Console.WriteLine("\nA palavra digitada tem " + charCount + " caracteres.");

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