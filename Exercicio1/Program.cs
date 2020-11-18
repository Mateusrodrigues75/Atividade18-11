using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num;
            Console.WriteLine("Digite uma note entre 0 e 10: ");
            num = decimal.Parse(Console.ReadLine());

            while(num<0 || num>10){
                
                Console.WriteLine("Nota Inválida");
                Console.WriteLine("Digite uma note entre 0 e 10: ");
                num = decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine($"A nota digitada foi {num}");
            Console.WriteLine("FIM");

        }
    }
}
