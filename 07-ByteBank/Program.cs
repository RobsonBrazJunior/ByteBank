using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCorrente = new ContaCorrente(852, 897564213);

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            Console.WriteLine(contaCorrente.Agencia);
            Console.WriteLine(contaCorrente.Numero);

            ContaCorrente contaCorrente2 = new ContaCorrente(845, 2314679);

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            Console.ReadLine();
        }
    }
}
