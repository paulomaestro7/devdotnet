using System;
using System.Collections.Generic;
using System.Text;

namespace Aula2Demo3
{
    public class Corrente : Conta
    {
        public Corrente()
        {
            Numero = 1717;
        }

        public List<string> GetDados()
        {
            var list = new List<string>()
            {
                "Conta Corrente",
                "Banco: " + GetBanking(),
                "Numero da conta: " + Numero.ToString(),
                "Saldo: " + Saldo
            };
            return list;
        }
    }
}
