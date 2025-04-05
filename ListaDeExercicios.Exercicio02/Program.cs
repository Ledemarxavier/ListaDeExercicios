namespace ListaDeExercicios.Exercicio02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.Write("*** Calculadora de volume de cilindro ***");
                Console.Write("\nDigite o raio do cilindro: ");
                double raio = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a altura do cilindro: ");
                double altura = Convert.ToDouble(Console.ReadLine());

                double volume = Math.PI * Math.Pow(raio, 2) * altura;

                Console.WriteLine($"O volume do cilindro é de: {volume} m³.");

                Console.Write("\nDeseja continuar? (S/N)");
                string opcaoContinuar = Console.ReadLine().ToUpper();

                if (opcaoContinuar != "S")
                    break;
            }
        }
    }
}