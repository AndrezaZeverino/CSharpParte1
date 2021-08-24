using System;

namespace _03_PraticandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3. Criando variáveis ponto flutuante");

            int idade= 28;
            Console.WriteLine("A idade informada é " + idade + ", parabéns!");

            double idadedouble = 27.0/2;
            Console.WriteLine("A idade teste de double é: " + idadedouble);

            double salario = 1200.70;
            Console.WriteLine("O salário informado é de " + salario);
            
            Console.WriteLine("A execução acabou. Tecle enter para sair...");
            Console.ReadLine(); 

        }
    }
}
