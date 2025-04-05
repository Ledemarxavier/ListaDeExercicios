namespace ListaDeExercicios.Exercicio04
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("*** Conversor de temperatura ***");

            Console.Write("\nDigite a temperatura em Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            double fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine($"\n{celsius}°C equivale a {fahrenheit}°F");

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}