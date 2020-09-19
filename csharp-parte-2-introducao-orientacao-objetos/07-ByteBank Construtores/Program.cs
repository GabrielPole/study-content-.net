using _07_ByteBank;
using System;

namespace _07_ByteBank_Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            // crindo o objeto com os dois argumento que precisa para ser criado
            ContaCorrente conta = new ContaCorrente(8888,0000);

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas); // mostrando um atributo da classe na tela


            //ContaCorrente.TotalDeContasCriadas = 10; => não pode ser alterado poque o metodo set é privado

            conta.Numero = 4444444;
            conta.Agencia = 875;

            conta.Agencia = -10; // não vai passar por causa da validação feita no na classe 

            ContaCorrente contaDoPole = new ContaCorrente(111, 111);

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);



            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            Console.ReadLine();

        }
    }
}
