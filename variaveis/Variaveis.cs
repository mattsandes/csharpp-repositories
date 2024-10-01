namespace CsharpProject
{
    public class Variaveis
    {
        public void retornaVariaveisInteiras(int val){
            Console.WriteLine("O seu valor é: " + val);
        }

        public void leDadosDoTeclado(){
            var dado = Console.ReadLine();

            Console.WriteLine("O seu valor é: " + dado);
        }
    }
}