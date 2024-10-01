// using System; Não e necessário usar isso pois
//o name space ja esta importado nesse projeto;

using System.Globalization;

namespace CsharpProject //nome do projeto;
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var variaveis = new Variaveis();
            int valorInteiro = 1234;

            Console.WriteLine("Hello world");

            Console.Write("Hello");
            Console.Write("Wold");

            //lendo dados do usuário;

            var dadoDeEntrada = Console.ReadLine();

            Console.WriteLine(dadoDeEntrada);

            double valorDecimal = 12.890;
            double outroValorDecimal = 47.555;

            //imprimindo 3 casas depois da virgula;
            Console.WriteLine(valorDecimal.ToString("F3"));

            //imprimindo virgula ao invez de ponto;
            Console.WriteLine(valorDecimal.ToString("F3", CultureInfo.InvariantCulture));

            Console.WriteLine("Valor 1: " + valorDecimal + 
            "\nOutro valor decimal: " + outroValorDecimal);

            //usando a classe de variaveis;

            variaveis.retornaVariaveisInteiras(valorInteiro);

            variaveis.leDadosDoTeclado();
        }
    }
}