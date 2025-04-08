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
                string calculo = "";
                for (int i = n; i >= 1; i--)
                {
                    fatorial *= i;
                    calculo += (i != 1) ? $"{i} x " : $"{i}";
                }

                Console.WriteLine($"\n{calculo} = {fatorial}");

                Console.Write("\nDeseja calcular novamente? (S/N): ");
                string opcao = Console.ReadLine().ToUpper();

                if (opcao != "S")
                    break;
            }
        }
    }
}