using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCorrente = new ContaCorrente();
            contaCorrente.titular = "Nome titular";
            contaCorrente.agencia = 863;
            contaCorrente.numero = 863452;

            ContaCorrente segundaContaCorrente = new ContaCorrente();
            segundaContaCorrente.titular = "Nome titular";
            segundaContaCorrente.agencia = 863;
            segundaContaCorrente.numero = 863452;

            Console.WriteLine("Igualdade de tipo de referência: " + (contaCorrente == segundaContaCorrente));

            int idade = 27;
            int idadeMaisUmaVez = 27;

            Console.WriteLine("Igualdade de tipo de valor: " + (idade == idadeMaisUmaVez));

            contaCorrente = segundaContaCorrente;
            Console.WriteLine(contaCorrente == segundaContaCorrente);

            contaCorrente.saldo = 300;
            Console.WriteLine(contaCorrente);
            Console.WriteLine(segundaContaCorrente);

            Console.ReadLine();
        }
    }
}
