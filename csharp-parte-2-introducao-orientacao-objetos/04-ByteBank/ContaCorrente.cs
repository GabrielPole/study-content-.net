public class ContaCorrente
{
    public string titular;
    public int agencia;
    public int numero;
    public double saldo = 100;

                  
    public bool Sacar(double valor) //  "bool" => tipo de valor que espera ser retornado "Sacar" => Nome da função  "(double valor)" => local onde os paramentros é passado;
    {
        if(this.saldo < valor) // "this" pegando o saldo do objeto/instância que está chamando a função. "valor" é o que recebemos como paramentro na função.
        {
            return false; //devolvendo um valor para quem chamou a função;
        }
        
        this.saldo -= valor;
        return true;
    }

    // Sempre a primeira letra em maiúsculo do nome da função/metodo 
    public void Depositar(double valor) // "void" => Quando não tem um retorno ou retorna fazio
    {
        this.saldo += valor;
    }

    //Preparando a função para receber argumento/paramentro de referencia 
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


    //    Métodos, definir o que um objeto saber fazer.
    //    O comportamento é implementado dentro do método.

    //    Função e método são termos sinônimos, mas,
    //    é comum encontrarmos o termo função
    //    quando há retorno e método quando não há.

    //    Um método pode ter nenhum, um ou mais parâmetros.

    //    Usamos o this dentro de um método para acessar um atributo:

}

