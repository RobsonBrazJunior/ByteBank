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


            Console.ReadLine();
        }
    }
}
