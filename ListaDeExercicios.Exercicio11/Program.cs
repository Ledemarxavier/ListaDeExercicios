namespace ListaDeExercicios.Exercicio11
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("*** Verificador de número par ou ímpar ***\n");

                Console.Write("Digite um número inteiro: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    Console.WriteLine($"\nO número {numero} é PAR.");
                }
                else
                {
                    Console.WriteLine($"\nO número {numero} é ÍMPAR.");
                }

                Console.Write("\nDeseja testar novamente? (S/N): ");
                string opcao = Console.ReadLine().ToUpper();

                if (opcao != "S")
                    break;
            }
        }
    }
}