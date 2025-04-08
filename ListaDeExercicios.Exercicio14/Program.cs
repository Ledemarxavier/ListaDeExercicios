namespace ListaDeExercicios.Exercicio14
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("*** Sequência de Fibonacci ***");
                Console.WriteLine("\nDigite um número limite: ");
                int numeroLimite = Convert.ToInt32(Console.ReadLine());

                int a = 0, b = 1;

                for (int i = 0; a <= numeroLimite; i++)
                {
                    Console.Write(a + " ");
                    int proximoNumero = a + b;
                    a = b;
                    b = proximoNumero;
                }
                Console.WriteLine("\nDeseja continuar? (S/N): ");
                string opcao = Console.ReadLine().ToUpper();

                if (opcao != "S")
                    break;
            }
        }
    }
}