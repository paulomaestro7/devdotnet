using System;

namespace Aula1Demo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a sua idade?");
            var idade = Console.ReadLine();

            if (int.Parse(idade) < 5)
            {
                Console.WriteLine("Você é menor de 5 anos.");
            }
            else if (int.Parse(idade) > 5)
            {
                Console.WriteLine("Você é maior de 5 anos.");
            }
            else
            {
                Console.WriteLine("Você tem 5 anos.");
            }

            switch (int.Parse(idade))
            {
                case 1:
                    Console.WriteLine("Você tem 1 ano.");
                    break;
                case 2:
                    Console.WriteLine("Você tem 2 anos.");
                    break;
                case 3:
                    Console.WriteLine("Você tem 3 anos.");
                    break;
                case 4:
                    Console.WriteLine("Você tem 4 anos.");
                    break;
                case 5:
                    Console.WriteLine("Você tem 5 anos.");
                    break;
                default:
                    Console.WriteLine("Você tem mais de 5 anos.");
                    break;
            }

            if (int.Parse(idade) >= 18)
            {
                if (int.Parse(idade) == 18)
                {
                    Console.WriteLine("Você tem 18 anos.");
                }
                else
                {
                    Console.WriteLine("Você tem mais de 18 anos.");
                }
            }

            if (int.Parse(idade) < 18 && int.Parse(idade) != 10)
            {
                Console.WriteLine("Você tem menos de 18 anos e diferente de 10 anos.");
            }

            if (int.Parse(idade) <= 3 || int.Parse(idade) == 5)
            {
                if (int.Parse(idade) < 3)
                {
                    Console.WriteLine("Você é menor que 3 anos.");
                }
                else if (int.Parse(idade) == 3)
                {
                    Console.WriteLine("Você tem 3 anos.");
                }
                if (int.Parse(idade) == 5)
                {
                    Console.WriteLine("Você tem 5 anos.");
                }
            }

            Console.WriteLine("Sua idade + 2 é igual: " + (int.Parse(idade) + 2));
            Console.WriteLine("Sua idade - 2 é igual: " + (int.Parse(idade) - 2));
            Console.WriteLine("Sua idade * 2 é igual: " + (int.Parse(idade) * 2));
            Console.WriteLine("Sua idade / 2 é igual: " + (int.Parse(idade) / 2));

            Console.WriteLine("Precione ENTER para sair...");
            Console.Read();
        }
    }
}
