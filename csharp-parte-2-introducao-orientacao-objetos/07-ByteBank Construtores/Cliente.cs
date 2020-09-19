using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    public class Cliente
    {
        private string _cpf; // criando um campo privado para não sobrer alteração, lembrando sempre de usar o "_"

        public string Nome { get; set; }
        public string CPF // fazer a logica aqui com get e set 
        {
            get
            {
                return _cpf;
            }
            set
            {
                // Escrevo minha lógica de validação de CPF
                _cpf = value;
            }
        }
        public string Profissao { get; set; }
    }


    //      Por trás do código public int Idade { get; set; }
    //  o compilador cria um campo privado para a idade e 2 
    //  métodos para o Get_Idade e Set_Idade
    //    Desta forma economizamos muitas linhas de código repetitivas
    //  e no futuro poderemos expandir o get e o set sem alterar 
    //  outras partes do código que dependem da classe com esta propriedade.

    //  Podemos usar o código public bool EhMaiorDeIdade { get { return Idade >= 18; } set { } }     para criar uma propriedade.
    //  O get é um método que retorna valor enquanto que, o set é um método sem retorno.Neste caso, onde não há implementação do set, você pode, inclusive, o omitir como em public bool EhMaiorDeIdade { get { return Idade >= 18; } }

}
