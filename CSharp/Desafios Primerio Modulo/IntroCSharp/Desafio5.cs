namespace DesafiosRocketseat;
using System.Text.RegularExpressions;

public class Desafio5
{
    public void show()
    {
        Console.WriteLine("\nDigite a placa do carro (Exemplo: ABC1234):");
        var placa = Console.ReadLine() ?? " ";
        var regex = new Regex(@"^[A-Z]{3}[0-9]{4}$");

        if (regex.IsMatch(placa))
        {
            Console.WriteLine("\nPlaca válida!");
        }
        else
        {
            Console.WriteLine("\nPlaca inválida! Placa deve conter 7 caracteres, sendo os 3 primeiros letras maiúsculas e os 4 últimos números!");
        }

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