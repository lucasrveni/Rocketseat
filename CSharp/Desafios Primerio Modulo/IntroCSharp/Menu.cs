namespace DesafiosRocketseat;

public class Menu
{
    public void show()
    {
        Console.WriteLine("\nBem-vindo aos desafios do primeiro modulo!\n");
        Console.WriteLine("Escolha um dos desafios abaixo para executar:\n");
        Console.WriteLine("--------------------------------------\n");
        Console.WriteLine("1 - Mensagem personalizada\n");
        Console.WriteLine("2 - Concatenar nome e sobrenome\n");
        Console.WriteLine("3 - Calcular A e B\n");
        Console.WriteLine("4 - Contar caracteres\n");
        Console.WriteLine("5 - Verificar placa\n");
        Console.WriteLine("6 - Datas formatadas\n");
        Console.WriteLine("0 - Encerrar\n");
        Console.WriteLine("--------------------------------------\n");

        var escolha = Console.ReadLine() ?? " ";

        switch (escolha)
        {
            case "1":
                new Desafio1().show();
                break;
            case "2":
                new Desafio2().show();
                break;
            case "3":
                new Desafio3().show();
                break;
            case "4":
                new Desafio4().show();
                break;
            case "5":
                new Desafio5().show();
                break;
            case "6":
                new Desafio6().show();
                break;
            case "0":
                if (escolha == "0")
                {
                    Console.WriteLine("Encerrando...");
                }
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    } 
}
