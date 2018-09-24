using System;
using System.Collections.Generic;

namespace Aula1Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("O que deseja apresentar?");
            Console.WriteLine("[1] - String");
            Console.WriteLine("[2] - Char");
            Console.WriteLine("[3] - Int");
            Console.WriteLine("[4] - Decimal");
            Console.WriteLine("[5] - Boolean");
            Console.WriteLine("[6] - List");
            Console.WriteLine("[7] - Enum");
            Console.WriteLine("[8] - Date");

            string comum = "Essa variável é ";
            string VarString = comum + "String";

            char[] VarChar = new char[4];
            VarChar[0] = 'C';
            VarChar[1] = 'h';
            VarChar[2] = 'a';
            VarChar[3] = 'r';

            int VarInt = 1;

            decimal VarDecimal = 1.2M;

            Boolean VarBoolean = true;

            List<string> VarList = new List<string>()
            {
                "Lista 1",
                "Lista 2",
                "Lista 3",
            };

            DateTime VarDate = DateTime.Now;

            Console.WriteLine("");
            Console.WriteLine("Precione a opção desejada...");
            Console.WriteLine("");
            var opcao = Console.ReadLine();

            if (opcao == "1" || opcao == "2" || opcao == "3" || opcao == "4" || opcao == "5" || opcao == "6" || opcao == "7" || opcao == "8")
            {
                if (opcao == "1")
                {
                    Console.WriteLine(VarString);
                }
                if (opcao == "2")
                {
                    var item = "";
                    for (int i = 0; i < VarChar.Length; i++)
                    {
                        item += VarChar[i].ToString();
                    }
                    Console.WriteLine(comum + item);

                }
                if (opcao == "3")
                {
                    Console.WriteLine(comum + "Int: " + VarInt);
                }
                if (opcao == "4")
                {
                    Console.WriteLine(comum + "Decimal: " + VarDecimal);
                }
                if (opcao == "5")
                {
                    Console.WriteLine(comum + "Boolean: " + VarBoolean);
                }
                if (opcao == "6")
                {
                    foreach (var item in VarList)
                    {
                        Console.WriteLine(comum + "List: " + item);
                    }
                }
                if (opcao == "7")
                {
                    Console.WriteLine(comum + "Enum: " + Enumerador.Enum1);
                    Console.WriteLine(comum + "Enum: " + Enumerador.Enum2);
                    Console.WriteLine(comum + "Enum: " + Enumerador.Enum3);
                }
                if (opcao == "8")
                {
                    Console.WriteLine(comum + "Date " + VarDate.ToShortDateString());
                }
            }
            else
            {
                Console.WriteLine("Opção inválida!");
            }
            Console.Read();
        }
    }
    public enum Enumerador
    {
        Enum1,
        Enum2,
        Enum3
    }

}
