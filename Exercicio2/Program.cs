using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            string username, password;
            Console.WriteLine("Digite um nome de usuário: ");
            username = Console.ReadLine();
            Console.WriteLine("Digite uma senha: ");
            password = Console.ReadLine();

            while(password == username){
                Console.WriteLine(" ----------------ERRO------------------ \nSenha igual ao nome de usuário. \nDigite outra senha : ");
                password = Console.ReadLine();
            }
            Console.WriteLine("Senha válida!");
            Console.WriteLine("FIM");

        }
    }
}
