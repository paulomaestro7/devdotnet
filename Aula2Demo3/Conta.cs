using System;
using System.Collections.Generic;
using System.Text;

namespace Aula2Demo3
{
    public class Conta
    {
        private const string Banco = "DevDotNet Banking";

        public decimal Saldo { get; set; }
        public int Numero { get; set; }
        public string Nome { get; set; }

        public Conta()
        {
            this.Saldo = 10000;
        }

        public virtual void Sacar(decimal Valor)
        {
            this.Saldo -= Valor;
        }

        public void Depositar(decimal Valor)
        {
            this.Saldo += Valor;
        }

        protected string GetBanking()
        {
            return Banco;
        }
    }
}
