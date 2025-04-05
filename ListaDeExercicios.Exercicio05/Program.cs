using System.Drawing;

namespace ListaDeExercicios.Exercicio05
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("**** Cálculo de Salário do Vendedor ****");

                Console.WriteLine("\nDigite o salário base: R$ ");
                decimal salarioBase = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Digite o total de vendas: R$ ");
                decimal totalVendas = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Digite o percentual de comissão (%): ");
                decimal percentualComissao = Convert.ToDecimal(Console.ReadLine());

                decimal valorComissao = totalVendas * (percentualComissao / 100);
                decimal salarioTotal = salarioBase + valorComissao;

                Console.WriteLine($"\nValor da comissão: R$ {valorComissao:F2}");
                Console.WriteLine($"Salário total: R$ {salarioTotal:F2}");

                Console.Write("\nDeseja calcular outro salário? (S/N): ");
                string opcao = Console.ReadLine().ToUpper();

                if (opcao != "S")
                    break;
            }
        }
    }
}