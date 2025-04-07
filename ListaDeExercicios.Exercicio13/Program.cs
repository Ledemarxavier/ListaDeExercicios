namespace ListaDeExercicios.Exercicio13
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                //Calculo de fatorial de um número
                Console.Clear();
                Console.WriteLine("Digite um número para calcular o fatorial: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int fatorial = 1;

                for (int i = 1; i <= n; i++)
                {
                    fatorial *= i;
                }

                Console.WriteLine($"Fatorial de, {n} é {fatorial}");

                Console.Write("\nDeseja calcular novamente? (S/N): ");
                string opcao = Console.ReadLine().ToUpper();

                if (opcao != "S")
                    break;
            }
        }
    }
}