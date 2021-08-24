using System;

namespace _8___Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("8 - testando condicionais 2");

            int idade = 19;
            int quantidadePessoas = 2;

            bool acompanhado = quantidadePessoas >= 2;

            if (idade >= 18 && acompanhado == true)
            {
                Console.WriteLine("Pode entrar");

            }

            else
            {
                Console.WriteLine("Não pode entrar");
            }
        }
    }
}
