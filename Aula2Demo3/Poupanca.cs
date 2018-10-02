using System;
using System.Collections.Generic;
using System.Text;

namespace Aula2Demo3
{
    public class Poupanca : Conta
    {
        public Poupanca()
        {
            Numero = 17;
        }
        public override void Sacar(decimal Valor)
        {
            this.Saldo -= (Valor + 0.10M);
        }
        public List<string> GetDados()
        {
            var list = new List<string>()
            {
                "Conta Poupança",
                "Banco: " + GetBanking(),
                "Numero da conta: " + Numero.ToString(),
                "Saldo: " + Saldo
            };
            return list;
        }
    }
}
