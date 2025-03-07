namespace DesafiosRocketseat
{
    public class Desafio3
    {
        public void show()
        {
            double a;
            double b;

            a = GetValidDouble("\nDigite o valor de A: ");
            b = GetValidDouble("\nDigite o valor de B: ");

            soma(a, b);
            subtracao(a, b);
            multiplicacao(a, b);
            divisao(a, b);
            media(a, b);

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

        private double GetValidDouble(string messagem)
        {
            double num;
            while (true)
            {
                Console.WriteLine(messagem);
                string input = Console.ReadLine() ?? " ";
                if (double.TryParse(input, out num))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Por favor, digite um número válido.");
                }
            }
            return num;
        }

        public void soma(double a, double b)
        {
            Console.WriteLine("\nA soma dos valores A e B é: " + (a + b));
        }

        public void subtracao(double a, double b)
        {
            Console.WriteLine("\nA subtração dos valores A e B é: " + (a - b));
        }

        public void multiplicacao(double a, double b)
        {
            Console.WriteLine("\nA multiplicação dos valores A e B é: " + (a * b));
        }

        public void divisao(double a, double b)
        {
            if (b != 0)
            {
                Console.WriteLine("\nA divisão dos valores A e B é: " + (a / b));
            }
            else
            {
                Console.WriteLine("\nNão é possível dividir por zero.");
            }
        }

        public void media(double a, double b)
        {
            Console.WriteLine("\nA média dos valores A e B é: " + ((a + b) / 2));
        }
    }
}