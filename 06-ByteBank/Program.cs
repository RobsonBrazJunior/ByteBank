using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCorrente = new ContaCorrente();

            contaCorrente.Saldo = -10;

            Console.WriteLine(contaCorrente.Saldo);

            Console.ReadLine();
        }
    }
}
