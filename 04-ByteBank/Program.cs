using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCliente = new ContaCorrente();

            contaCliente.titular = "Nome cliente";

            Console.WriteLine(contaCliente.saldo);
            bool resultadoSaque = contaCliente.Sacar(50);
            Console.WriteLine(contaCliente.saldo);
            Console.WriteLine(resultadoSaque);

            contaCliente.Depositar(500);
            Console.WriteLine(contaCliente.saldo);

            ContaCorrente contaCliente2 = new ContaCorrente();
            contaCliente2.titular = "Cliente 02";

            bool resultadoTransferencia = contaCliente.Transferir(100, contaCliente2);

            Console.WriteLine("Saldo Cliente 1: " + contaCliente.saldo);
            Console.WriteLine("Slado Cliente 2: " + contaCliente2.saldo);

            Console.WriteLine("Resultado da transferência: " + resultadoTransferencia);

            Console.ReadLine();
        }
    }
}
