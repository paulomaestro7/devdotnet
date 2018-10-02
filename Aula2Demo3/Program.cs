using System;
using System.Collections.Generic;

namespace Aula2Demo3
{
    class Program
    {
        private static string Nome;
        private static Poupanca Poupanca;
        private static Corrente Corrente;
        private static decimal ValorMovimentacao;
        private static List<string> Dados;
        static void Main(string[] args)
        {
            Console.WriteLine("Exemplo constantes, propriedades, construtor, métodos, retornos, private, protected, public, new, static e sobrecarga");

            Console.WriteLine("Qual o seu nome?");

            Nome = Console.ReadLine().RemoverAcentos();

            Console.Clear();

            ContaAcesso();

            Console.Clear();

            Console.WriteLine("Operação realizada com sucesso.".RemoverAcentos("ã"));
            Console.WriteLine("_______________________________");
            Console.WriteLine("        Dados da conta");
            foreach (var item in Dados)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Valor da movimentação: " + ValorMovimentacao);
            Console.WriteLine("_______________________________");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Precione qualquer tecla para sair...");

            Console.ReadKey();
        }

        private static void ContaAcesso()
        {
            Console.Clear();

            Console.WriteLine("Sr. " + Nome + ", qual conta deseja acessar?");

            Console.WriteLine("[1] - Poupança");
            Console.WriteLine("[2] - Corrente");

            var tipoConta = Console.ReadLine();

            if (tipoConta == "1" || tipoConta == "2")
            {
                if (tipoConta == "1")
                {
                    Poupanca = new Poupanca();
                }
                else
                {
                    Corrente = new Corrente();
                }
                Operacao();
            }
            else
            {
                ContaAcesso();
            }
        }

        private static void Operacao()
        {
            Console.Clear();
            Console.WriteLine("Sr. " + Nome + ", qual operação deseja realizar?");

            Console.WriteLine("[1] - Saque");
            Console.WriteLine("[2] - Deposito");

            var operacao = Console.ReadLine();

            if (operacao == "1" || operacao == "2")
            {
                Movimentacao(operacao == "1" ? "Saque" : "Deposito");
                if (operacao == "1")
                {
                    if (Poupanca != null)
                    {
                        Poupanca.Sacar(ValorMovimentacao);
                        Dados = Poupanca.GetDados();
                    }
                    else
                    {
                        Corrente.Sacar(ValorMovimentacao);
                        Dados = Corrente.GetDados();
                    }
                }
                else
                {
                    if (Poupanca != null)
                    {
                        Poupanca.Depositar(ValorMovimentacao);
                        Dados = Poupanca.GetDados();
                    }
                    else
                    {
                        Corrente.Depositar(ValorMovimentacao);
                        Dados = Corrente.GetDados();
                    }
                }
            }
            else
            {
                Operacao();
            }
        }

        private static void Movimentacao(string Operacao)
        {
            Console.Clear();

            Console.WriteLine("Sr. " + Nome + ", qual o valor do " + Operacao + "?");
            try
            {
                ValorMovimentacao = decimal.Parse(Console.ReadLine());
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Infelizmente não podemos movimentar o valor desejado, acho que não compreendemos o que disse.");
                Movimentacao(Operacao);
            }
        }
    }
}
