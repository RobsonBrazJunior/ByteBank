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
            Cliente cliente = new Cliente();

            cliente.Nome = "Nome do cliente";
            cliente.CPF = "CPF do cliente";
            cliente.Profissao = "Profissão do cliente";

            contaCorrente.Saldo = -10;
            contaCorrente.Titular = cliente;

            Console.WriteLine(contaCorrente.Titular.Nome);
            Console.WriteLine(contaCorrente.Saldo);

            Console.ReadLine();
        }
    }
}
