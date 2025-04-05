using System.Dynamic;

namespace ListaDeExercicios.Exercicio01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("** Calculo do Volume de uma caixa **");

                Console.WriteLine("Digite a altura da caixa: ");
                decimal altura = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Digite a largura da caixa: ");
                decimal largura = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Digite o comprimento da caixa: ");
                decimal comprimento = Convert.ToDecimal(Console.ReadLine());

                decimal volume = comprimento * largura * altura;

                Console.WriteLine($"O volume da caixa é de: {volume}m³");

                Console.Write("\nDeseja continuar? (S/N)");
                string opcaoContinuar = Console.ReadLine().ToUpper();

                if (opcaoContinuar != "S")
                    break;
            }
        }
    }
}