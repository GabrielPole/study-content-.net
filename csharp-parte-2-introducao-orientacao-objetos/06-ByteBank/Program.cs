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

            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.Nome = "Guilherme";
            cliente.CPF = "434.564.879-20";
            cliente.Profissao = "Desenvolvedor";
             
            conta.Saldo = -10; // usando o set saldo e atribuindo o valor, e deixando o copilador resolver por baixo dos panos 
            conta.Titular = cliente;
             
            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(conta.Saldo); // usando o get, está sendo feito por baixo dos panos um metodo que retorna o saldo 
             
            Console.ReadLine(); 
        }
    }
}
