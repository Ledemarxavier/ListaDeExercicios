namespace ListaDeExercicios.Exercicio15
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("*** Programa FizzBuzz de 1 a 100 ***");

                for (int i = 1; i <= 100; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }

                Console.WriteLine("Aperte ENTER para sair...");
                Console.ReadKey();
                break;
            }
        }
    }
}