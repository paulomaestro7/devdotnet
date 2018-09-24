using System;

namespace Aula1Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Aula1 ");
            Console.Write("Demo1");

            Console.WriteLine("");
            Console.WriteLine("Comunidade Dev Dot Net");
            Console.WriteLine("");

            Console.WriteLine("Qual o seu nome?");

            Console.WriteLine("Bem vindo " + Console.ReadLine());

            Console.WriteLine("Precione ESC apara limpar a tela ou ENTER para sair...");

            var tecla = Console.ReadKey().Key;

            if (tecla == ConsoleKey.Enter)
            {
                Console.WriteLine("By By");
            }
            else if (tecla == ConsoleKey.Escape)
            {
                Console.Clear();
                Console.WriteLine("Precione qualquer tecla para sair...");
                Console.Read();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Você deveria precionar ESC ou ENTER.");
                Console.WriteLine("Precione qualquer tecla para sair...");
                Console.ReadKey();
            }
        }
    }
}
