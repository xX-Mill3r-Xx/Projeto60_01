using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Projeto60_01
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Entre com o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o Titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá deposito Inicial? (s/n) - ");
            char resp = char.Parse(Console.ReadLine());
            if(resp == 's' || resp == 'S')
            {
                Console.Write("Entre com o valor do deposito Inicial: ");
                double dep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, nome, dep);
            }
            else
            {
                conta = new ContaBancaria(numero, nome);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para deposito: ");
            double ValDep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(ValDep);
            Console.WriteLine();

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saque);
            Console.WriteLine();

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.ReadLine();
        }
    }
}
