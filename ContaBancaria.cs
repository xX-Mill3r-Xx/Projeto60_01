using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Projeto60_01
{
    class ContaBancaria
    {
        public int NumeroDaConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numeroDaConta, string titular)
        {
            NumeroDaConta = numeroDaConta;
            Titular = titular;
        }

        public ContaBancaria(int numeroDaConta, string titular, double depositoInicial) : this(numeroDaConta, titular)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            double taxa = 5.00;
            Saldo -= quantia + taxa;
        }

        public override string ToString()
        {
            return $"Numero da conta: {NumeroDaConta}," +
                $"Titular: {Titular}, " +
                $"Saldo: ${Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
