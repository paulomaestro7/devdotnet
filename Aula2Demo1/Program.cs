using System;

namespace Aula2Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exemplo break");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Contador: " + i.ToString());
                if (i == 3)
                    break;
            }
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Exemplo continue");

            for (int i = 0; i < 10; i++)
            {
                if (i == 3)
                    continue;
                Console.WriteLine("Contador: " + i.ToString());
            }

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Exemplo do while");

            var count = new char[4] { '0', '1', '2', '3'};

            do
            {
                Console.WriteLine("Contador: " + count[0]);
            }
            while (count.Length != 4);

            Console.WriteLine("Precione ENTER para sair...");
            Console.Read();
        }
    }
}
