namespace ListaDeExercicios.Exercicio03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("**** Calculadora de consumo Km/l ****");

                Console.WriteLine("Digite a quilometragem inicial: ");
                double kmInicial = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite a quilometragem final: ");
                double kmFinal = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite a quantidade de combustível consumida (litros): ");
                double combustivelConsumido = Convert.ToDouble(Console.ReadLine());

                double distanciaPercorrida = kmFinal - kmInicial;

                double consumoPorKm = distanciaPercorrida / combustivelConsumido;

                Console.WriteLine($"\nDistância percorrida: {distanciaPercorrida} km");
                Console.WriteLine($"Consumo médio: {consumoPorKm:F2} km/l");
                break;

                Console.Write("\nDeseja continuar? (S/N)");
                string opcaoContinuar = Console.ReadLine().ToUpper();

                if (opcaoContinuar != "S")
                    break;
            }
        }
    }
}