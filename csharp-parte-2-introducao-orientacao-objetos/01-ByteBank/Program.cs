using System;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {


            // "new ContaCorrente();" Com a palavra-chave "new" nós criamos um novo objeto do tipo especificado.

            //Criando o objeto e inicializando a instancia "ContaDaGabriela"
            ContaCorrente contaDaGabriela = new ContaCorrente();

            // Acessando o objeto atravez da instacia e populando com dados
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;
            contaDaGabriela.saldo = 100;

            Console.WriteLine(contaDaGabriela.titular);
            Console.WriteLine("Agência: " + contaDaGabriela.agencia);
            Console.WriteLine("Número: " + contaDaGabriela.numero);
            Console.WriteLine("Saldo: " + contaDaGabriela.saldo);

            contaDaGabriela.saldo += 200;
            Console.WriteLine("Saldo: " + contaDaGabriela.saldo);

            Console.ReadLine();
        }
    }
}
