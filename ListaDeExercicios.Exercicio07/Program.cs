namespace ListaDeExercicios.Exercicio07
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("*** Verificador de número primo ***");

                Console.WriteLine("\nDigite um número inteiro positivo: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                bool ehPrimo = true;

                if (numero == 1)
                {
                    ehPrimo = false;
                }
                else
                {
                    for (int i = 2; i < numero; i++)
                    {
                        if (numero % i == 0)
                        {
                            ehPrimo = false;
                            break;
                        }
                    }
                }

                if (ehPrimo)
                    Console.WriteLine($"\n{numero} é um número primo.");
                else
                    Console.WriteLine($"\n{numero} não é um número primo.");

                Console.Write("\nDeseja calcular outra média ponderada? (S/N): ");
                string opcao = Console.ReadLine().ToUpper();

                if (opcao != "S")
                    break;
            }
        }
    }
}