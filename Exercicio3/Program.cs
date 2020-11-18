using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome, ecivil;
            int idade;
            float salario;
            Console.Write("Digite seu Nome: ");
            nome = Console.ReadLine();
            while(nome == ""){
                Console.WriteLine("Espaço do Nome está vazio.");
                Console.Write("Digite seu Nome novamente: ");
                nome = Console.ReadLine();
            }

            Console.Write("Digite sua Idade: ");
            idade = int.Parse(Console.ReadLine());
            while(idade<0 || idade>150){
                Console.Write("Digite sua Idade novamente: ");
                idade = int.Parse(Console.ReadLine());
            }
           
            Console.Write("Digite seu Salário: ");
            salario = float.Parse(Console.ReadLine());
            while(salario<0){
                Console.WriteLine("--------------ERRO --------------\n Salario digitado tem valor menor que zero. ");
                Console.WriteLine("Digite seu Salário novamente: ");
                salario = float.Parse(Console.ReadLine());
            }
            
            Console.Write("Digite a letra correspondente a seu estado civil-\n Solteiro(a) - (S)\n Casado(a) - (C)\n Viúvo(a) - (V)\n Divorciado(a) - (D) : ");
            ecivil = Console.ReadLine();
            switch(ecivil){
                case "S":
                Console.WriteLine("Seu Estado Civil é de Solteiro(a).");
                break;
                
                case "C":
                Console.WriteLine("Seu Estado Civil é de Casado(a).");
                break;
                
                case "V":
                Console.WriteLine("Seu Estado Civil é de Viúvo(a).");
                break;
                
                case "D":
                Console.WriteLine("Seu Estado Civil é de Divorciado(a).");
                break;

                default:
                Console.WriteLine("--------------ERRO --------------");
                Console.Write("Digite a letra correspondente a seu estado civil : ");
                ecivil = Console.ReadLine();
                break;
            }
            Console.WriteLine("FIM");




        }
    }
}
