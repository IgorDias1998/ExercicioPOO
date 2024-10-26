using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancariaHeranca
{
    public class ContaInvestimento : Conta
    {
        public override double Juros { get; set; } = 0.009;

        public override decimal Sacar(decimal valor)
        {
            if (Saldo >= valor)
            {
                var imposto = Saldo * 0.001m;
                Saldo -= (valor + imposto);
                return Saldo;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente...");
                return Saldo;
            }
        }
    }
}
