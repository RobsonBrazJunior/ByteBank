using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCliente01 = new ContaCorrente();

            contaCliente01.titular = "Cliente01";
            contaCliente01.agencia = 863;
            contaCliente01.numero = 863452;
            contaCliente01.saldo = 100;

            Console.WriteLine(contaCliente01.titular);
            Console.WriteLine("Agência: " + contaCliente01.agencia);
            Console.WriteLine("Número: " + contaCliente01.numero);
            Console.WriteLine("Saldo: " + contaCliente01.saldo);

            contaCliente01.saldo += 200;
            Console.WriteLine("Saldo: " + contaCliente01.saldo);

            Console.ReadLine();
        }
    }
}
