namespace ListaDeExercicios.Exercicio10
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("*** Calcule seu IMC (Índice de Massa Corporal) ***");

                Console.WriteLine("\nDigite seu peso (Kg): ");
                double peso = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite sua altura: ");
                double altura = Convert.ToDouble(Console.ReadLine());

                double imc = peso / (altura * altura);

                Console.WriteLine($"\nSeu IMC é: {imc:F2}");

                Console.WriteLine("Condição: ");

                switch (imc)
                {
                    case < 18.5:
                        Console.WriteLine("Abaixo do peso");
                        break;

                    case >= 18.5 and < 25:
                        Console.WriteLine("Peso normal");
                        break;

                    case >= 25 and < 30:
                        Console.WriteLine("Acima do peso");
                        break;

                    default:
                        Console.WriteLine("Obeso");
                        break;
                }

                Console.Write("\nDeseja calcular novamente? (S/N): ");
                string opcao = Console.ReadLine().ToUpper();

                if (opcao != "S")
                    break;
            }
        }
    }
}