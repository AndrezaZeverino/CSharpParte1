using System;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salario = 1200.50;
            Console.WriteLine("O salário é " + salario);

            // Utilizo o long pois o int só aceita na memória um número com até 32bits, já o long aceita mais que isso//
            long idade = 130000000000;

            Console.WriteLine("A idade do mundo é " + idade);

            // short menor que int - ocupa 16bits na memória//

            short quantidadeProdutos = 150;

            Console.WriteLine("Quantidade de produtos: " + quantidadeProdutos);

            //coloco o f atrás para o compilador entender que não foi um erro de digitação//
            float altura = 1.80f;
            Console.WriteLine("Altura: " + altura);


            Console.ReadLine();
        }
    }
}
