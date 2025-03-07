namespace DesafiosRocketseat
{
    public class Desafio1
    {
        public void show()
        {
            string nome;

            Console.WriteLine("\nQual é o seu nome?");
            nome = Console.ReadLine() ?? " ";

            Console.WriteLine($"\nOlá, {nome}! Seja bem-vindo(a)!");

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
}