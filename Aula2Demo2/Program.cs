using System;
using System.Collections.Generic;
using System.IO;

namespace Aula2Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exemplo try catch finally");

            Console.WriteLine("Qual a sua idade?");

            var idade = Console.ReadLine();

            try
            {
                Console.WriteLine("Sua idade * 2 é: " + (int.Parse(idade) * 2));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Aconteceu algo de errado: " + ex.Message);
                throw;
            }
            finally
            {
                Console.WriteLine("Finalizado com sucesso!");
            }
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Exemplo using");

            var caminho = @"C:\temp\teste.txt";
            if (!File.Exists(caminho))
                File.WriteAllText(caminho, "Exemplo using");

            using (var file = new StreamWriter(caminho))
            {
                file.WriteLine("Primeira linha");
                file.WriteLine("Segunda linha");
            }

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Exemplo return");

            if (int.Parse(idade) < 18)
            {
                Console.WriteLine("Você é menor de 18 anos e não pode continuar");
                return;
            }
            else
                Console.WriteLine("Você tem mais de 18 anos e pode continuar");

            Console.WriteLine("Precione ENTER para sair...");
            Console.Read();
        }
    }
}
