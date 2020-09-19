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
            //Criando uma instancia "contaDaGabriela" da class "ContaCorrente"
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;

            //Criando outra instancia "contaDaGabrielaCosta" da class "ContaCorrente"
            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
            contaDaGabrielaCosta.titular = "Gabriela";
            contaDaGabrielaCosta.agencia = 863;
            contaDaGabrielaCosta.numero = 863452;

            // Retorna false pois estamos comparando referencias de instacias diferentes
            Console.WriteLine("Igualdade de tipo de referência:" + (contaDaGabriela == contaDaGabrielaCosta));

            int idade = 27;
            int idadeMaisUmaVez = 27;

            // retorna true 
            Console.WriteLine("Igualdade de tipo de valor: " + (idade == idadeMaisUmaVez));

            // Em C# temos dois tipos de "tipos" tipo de valor e tipo de referencia;

            //Agora temos duas variaveis que apontam para o mesmo objeto na memoria 
            contaDaGabriela = contaDaGabrielaCosta;

            // Vai Retorna true, temos duas variavei de refencia apontam para o mesma objeto;
            Console.WriteLine(contaDaGabriela == contaDaGabrielaCosta);

            // Mudando o valor do objeto com variaveis diferentes 
            contaDaGabriela.saldo = 300;
            Console.WriteLine(contaDaGabriela.saldo);
            Console.WriteLine(contaDaGabrielaCosta.saldo);

            Console.ReadLine();
        }
    }
}
