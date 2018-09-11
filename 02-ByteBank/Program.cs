using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCorrente = new ContaCorrente();

            contaCorrente.titular = "Nome do titular";
            Console.WriteLine(contaCorrente.titular);
            Console.WriteLine(contaCorrente.agencia);
            Console.WriteLine(contaCorrente.saldo);

            contaCorrente.saldo = 200;

            Console.WriteLine(contaCorrente.saldo);

            Console.ReadLine();
        }
    }
}
