using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroAnt, numeroAtual, fibonacci;
            numeroAnt = 0;
            numeroAtual = 1;

            for(int i = 0; i < 14; i++){
                fibonacci = numeroAnt + numeroAtual;
                Console.WriteLine (fibonacci);
                numeroAnt = numeroAtual;
                numeroAtual = fibonacci;
            }
            
        }
    }
}
