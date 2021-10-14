using System;

namespace first_console_app
{
    class Program
    {
        static void Main(string[] args)
        {

            string nome;
            int idade;

            Console.WriteLine("Digite seu nome?");
            nome = Console.ReadLine();
            Console.WriteLine("Qual a sua idade?");
            idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Eu sou o " + nome);
            Console.WriteLine("Eu tenho " + idade + " anos");

            if(idade > 18){
                Console.WriteLine("Pessoa é maior legal");
            }else{
                Console.WriteLine("Você precisa estar commpanhado de um maior legal")
            }
        }
    }
}
