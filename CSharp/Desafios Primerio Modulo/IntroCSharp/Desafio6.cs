namespace DesafiosRocketseat;
using System.Globalization;

public class Desafio6
{
    public void show()
    {
        DateTime data = DateTime.Now;
        Console.WriteLine("\nom base na data e hora atual, temos as seguintes informações:\n");

        Console.WriteLine("-------------------------------------------------------\n");

        Console.WriteLine("Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos:)");
        Console.WriteLine(data.ToString("dddd, dd 'de' MMMM 'de' yyyy HH:mm:ss", new CultureInfo("pt-BR")));
        Console.WriteLine("\n-------------------------------------------------------\n");

        Console.WriteLine("Apenas a data no formato \"dd/MM/yyyy\": ");
        Console.WriteLine(data.ToString("dd/MM/yyyy"));
        Console.WriteLine("\n-------------------------------------------------------\n");

        Console.WriteLine("Apenas a hora no formato de 24 horas: ");
        Console.WriteLine(data.ToString("HH:mm:ss"));
        Console.WriteLine("\n-------------------------------------------------------\n");

        Console.WriteLine("A data com o mês por extenso: ");
        Console.WriteLine(data.ToString("dd 'de' MMMM 'de' yyyy", new CultureInfo("pt-BR")));
        Console.WriteLine("\n-------------------------------------------------------");

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