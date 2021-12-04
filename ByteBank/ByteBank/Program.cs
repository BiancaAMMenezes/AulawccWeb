using ByteBank.Extensao;
using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            var conta = new ContaCorrente[5];

            conta[0] = new ContaCorrente(123, 98765);
            conta[1] = new ContaCorrente(132, 76521);
            conta[2] = new ContaCorrente(345, 65432);
            conta[3] = new ContaCorrente(456, 43217);
            conta[4] = new ContaCorrente(987, 54324);

            OrdenarLista(conta);

            Console.WriteLine($"O saldo na conta {conta[0].Numero} é R$ {conta[0].Saldo}");
            conta[0].Sacar(50);
            Console.WriteLine($"O saldo na conta {conta[0].Numero} é R$ {conta[0].Saldo}");

        }

        public static void OrdenarLista(ContaCorrente[] conta)
        {
            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(234, 78912),
                new ContaCorrente(123, 54321)
            };

            contas.AdicionarVarios(conta);

            Console.WriteLine();
            Console.WriteLine("Lista de correntistas ordenada:");
            var contasOrdenadas = contas.Where(conta => conta != null).OrderBy(conta => conta.Agencia);
            foreach (var item in contasOrdenadas)
            {
                Console.WriteLine($"Agencia: { item.Agencia} e Numero: { item.Numero}");
            }
        }

        public static void Saque(ContaCorrente conta, double valor)
        {
            conta.Sacar(valor);
        }

    }
}
