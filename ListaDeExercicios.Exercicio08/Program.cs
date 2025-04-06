namespace ListaDeExercicios.Exercicio08
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("*** Verificador de A + B < C ***");

                Console.WriteLine("\nDigite o valor de A: ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o valor de B: ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o valor de C: ");
                int c = Convert.ToInt32(Console.ReadLine());

                double soma = a + b;

                if (soma < c)
                {
                    Console.WriteLine($"\n A soma de A + B ({soma})\n É MENOR que C ({c}).");
                }
                else if (soma > c)
                {
                    Console.WriteLine($"\nA soma de A + B ({soma})\nNÃO é menor que C ({c}).");
                }
                else
                {
                    Console.WriteLine($"\nA soma de A + B ({soma})\nÉ igual a C ({c}).");
                }
                Console.Write("\nDeseja testar novamente? (S/N): ");
                string opcao = Console.ReadLine().ToUpper();

                if (opcao != "S")
                    break;
            }
        }
    }
}