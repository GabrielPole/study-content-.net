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
            ContaCorrente contaDoBruno = new ContaCorrente();
            
            contaDoBruno.titular = "Bruno";
            
            Console.WriteLine(contaDoBruno.saldo);
            
            //chamando a função sacar e pegando o valor retornado pela função
            bool resultadoSaque = contaDoBruno.Sacar(500); //"500" vai ser o valor passado para a função como parametro
            
            Console.WriteLine(resultadoSaque);
            Console.WriteLine(contaDoBruno.saldo); 
             
            contaDoBruno.Depositar(500); // usando um metodo 
            Console.WriteLine(contaDoBruno.saldo);
            
            ContaCorrente contaDaGabriela = new ContaCorrente();
            
            contaDaGabriela.titular = "Gabriela";
            
            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo do Gabriela: " + contaDaGabriela.saldo);
            
            bool resultadoTransferencia = contaDoBruno.Transferir(2000, contaDaGabriela); // chamando uma função e recebendo como paramentro um valor int e uma referencia 
            
            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo do Gabriela: " + contaDaGabriela.saldo);

            Console.WriteLine("Resultado transferência: " + resultadoTransferencia);

            contaDaGabriela.Transferir(100, contaDoBruno); 

            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo do Gabriela: " + contaDaGabriela.saldo);

            Console.ReadLine();
        }
    }
}
