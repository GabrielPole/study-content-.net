// using _05_ByteBank;

namespace _06_ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        
        private double _saldo = 100; // Mudando o atributo para private para ser visivel somente dentro da classe 

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
                    return; // para parar o processor
                }
                else
                {
                    _saldo = value;
                }
            }
        }


        // Uma maneira de usar o get set 


        //public void SetSaldo(double saldo)
        //{
        //    if (saldo < 0)
        //    {
        //        return; // para parar o processor
        //    }
        //    else
        //    {
        //        this.Saldo = saldo;
        //    }
        //}

        //public double GetSaldo()
        //{
        //    return Saldo;
        //}



        // Antes do get e set 

        //public void DefinirSaldo(double saldo)
        //{
        //    if (saldo < 0)
        //    {
        //        return; // para parar o processor
        //    } else
        //    {
        //        this.Saldo = saldo;
        //    }
        //}

        //public double ObterSaldo()
        //{
        //    return Saldo;
        //}

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
