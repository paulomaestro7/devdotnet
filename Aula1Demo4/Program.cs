using System;
using System.Collections.Generic;

namespace Aula1Demo4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> varList = new List<string>()
            {
                "registro 1",
                "registro 2",
                "registro 3",
                "registro 4",
                "registro 5",
            };

            for (int i = 0; i < varList.Count; i++)
            {
                Console.WriteLine("for: " + varList[i]);
            }

            bool VarWhile = true;
            int j = 0;
            while (VarWhile)
            {
                Console.WriteLine("while: " + j);
                if (j == 10)
                {
                    VarWhile = false;
                }
                j++;
            }

            foreach (var item in varList)
            {
                Console.WriteLine("foreach: " + item);
            }

            Console.WriteLine("Precione ENTER para sair...");

            Console.Read();
        }
    }
}
