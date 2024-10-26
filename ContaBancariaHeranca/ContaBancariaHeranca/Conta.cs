using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancariaHeranca
{
    public class Conta
    {
        public int NumeroConta { get; set; }
        public string  NomeCliente { get; set; }
        public decimal Saldo { get; set; } = 0.00m;
        public virtual double Juros { get; set; } = 0.00;

        public decimal CalcularRemunaeracao(double juros)
        {
            return Saldo * (decimal)juros;
        }

        public decimal Depositar(decimal valor)
        {
            Saldo += valor;
            Saldo = Saldo + CalcularRemunaeracao(Juros);
            return Saldo;
        }
        public virtual decimal Sacar(decimal valor)
        {
            Saldo -= valor;
            return Saldo;
        }
    }
}
