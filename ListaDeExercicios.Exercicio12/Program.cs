namespace ListaDeExercicios.Exercicio12
{
    internal class Program
    {
        // Escrever um algoritmo que gera e escreve os números ímpares entre 100 e 200.
        private static void Main(string[] args)
        {
            Console.WriteLine("Números ímpares entre 100 e 200:\n");
            for (int i = 101; i < 200; i += 2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Aperte ENTER para sair...");
            Console.ReadKey();
        }
    }
}