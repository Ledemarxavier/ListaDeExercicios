namespace ListaDeExercicios.Exercicio06
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("** Cálculo da Média Ponderada **\n");

                Console.WriteLine("Digite a nota da primeira prova: ");
                double notaProva1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o peso da primeira prova: ");
                double pesoProva1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite a nota da segunda prova: ");
                double notaProva2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o peso da segunda prova: ");
                double pesoProva2 = Convert.ToDouble(Console.ReadLine());

                double mediaPonderada = (notaProva1 * pesoProva1 + notaProva2 * pesoProva2) / (pesoProva1 + pesoProva2);

                Console.WriteLine($"\nA média ponderada do aluno é: {mediaPonderada:F2}");

                Console.Write("\nDeseja calcular outra média ponderada? (S/N): ");
                string opcao = Console.ReadLine().ToUpper();

                if (opcao != "S")
                    break;
            }
        }
    }
}