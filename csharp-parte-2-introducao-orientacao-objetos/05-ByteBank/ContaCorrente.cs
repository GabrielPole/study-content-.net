using _05_ByteBank; // não é necessario colocar o "using", porque a classe "cliente" já está sendo usada no mesmo "namespace"

namespace _05_ByteBank
{
    public class ContaCorrente
    {
        public Cliente titular; // usando como atributo outra classe, "titular" está sendo usado como parametro para acessa o objeto cliente 
        public int agencia;
        public int numero;
        public double saldo = 100;

        public bool Sacar(double valor)
        {
            if (this.saldo < valor)
            {
                return false;
            }

            this.saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }


        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.saldo < valor)
            {
                return false;
            }

            this.saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }

    //  Os nomes de namespace não devem conter traços(-) ou iniciar com números.

    //  O namespace faz parte do nome completo de uma classe.
    //  O nome completo de uma classe segue o formato " namespace.nome da classe. "
}
