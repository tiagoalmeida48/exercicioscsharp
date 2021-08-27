using System;

namespace ExercicioSenha
{
    class Program
    {
        static void Main(string[] args)
        {
            string senha = "123456";
            string validaSenha;

            Console.Write("Digite sua senha: ");
            validaSenha = Console.ReadLine();

            while (senha != validaSenha)
            {
                Console.WriteLine("Senha invalida!\n");
                Console.Write("Digite sua senha: ");
                validaSenha = Console.ReadLine();
            }

            Console.WriteLine("Acesso permitido!");
        }
    }
}
