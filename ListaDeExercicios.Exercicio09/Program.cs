namespace ListaDeExercicios.Exercicio09
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                int[] numeros = new int[3];
                Console.Clear();
                Console.WriteLine("*** Comparação e ordenação ***");
                Console.WriteLine("\nDigite três números inteiros diferentes:");
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine($"Número {i + 1}: ");
                    numeros[i] = Convert.ToInt32(Console.ReadLine());
                }

                if (numeros[0] == numeros[1] || numeros[0] == numeros[2] || numeros[1] == numeros[2])
                {
                    Console.WriteLine("\nOs números devem ser diferentes entre si.");

                    Console.ReadLine();
                    continue;
                }

                Array.Reverse(numeros);
                Console.WriteLine("\nOrdem decrescente:");
                for (int i = 0; i < numeros.Length; i++)
                {
                    Console.WriteLine(numeros[i]);
                }
                Console.Write("\nDeseja continuar o teste? (S/N): ");
                string opcao = Console.ReadLine().ToUpper();

                if (opcao != "S")
                    break;
            }
        }
    }
}