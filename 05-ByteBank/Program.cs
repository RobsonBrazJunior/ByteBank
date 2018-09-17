using System;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();

            cliente.nome = "Nome do cliente";
            cliente.profissao = "Profissão do cliente";
            cliente.cpf = "CPF do cliente";

            ContaCorrente contaCorrente = new ContaCorrente();
            contaCorrente.titular = cliente;
            contaCorrente.saldo = 500;
            contaCorrente.agencia = 555;
            contaCorrente.numero = 5634527;

            Console.WriteLine(cliente.nome);
            Console.WriteLine(contaCorrente.titular.nome);

            Console.ReadLine();
        }
    }
}
