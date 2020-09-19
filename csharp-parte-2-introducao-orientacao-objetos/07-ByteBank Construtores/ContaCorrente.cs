

namespace _07_ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }

        //Propriedade dos objetos compartinhados com todos
        public static int TotalDeContasCriadas { get; private set; } // "static"  => isso aqui é uma propriedade que pertence a classe
                                                    // deixando o "private set" sendo assim só pode mostrar e não alterar


        // metodo estatico abaixo

        //public static int ObterTotalDeContasCriadas()
        //{
        //    return TotalDeContasCriadas;
        //}

        private int _agencia;
        public int Agencia {
            get 
            {
                return _agencia; // retorno em get "Conta.Angencia"
            }
            set
            { 
                if(value <= 0) 
                {
                    return; // validando se agencia é menor 
                }
                _agencia = value;
            } 
        }
        public int Numero { get; set; }
        
        private double _saldo = 100; 

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                
                if (value < 0)
                {
                    return; 
                }
                else
                {
                    _saldo = value;
                }
            }
        }

        // Criando um construtor, para quando for criado o objeto sejá necessario declarar o paramentros antes.
        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
            // o compilador já inferi para nóis a referencia do menbro estatico desde que seja dentro da mesma classe 
            // evitando que seja necessario ficar assim "ContaCorrente.TotalDeContaCriadas++;
        }


        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }


        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
