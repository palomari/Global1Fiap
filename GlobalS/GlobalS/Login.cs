using System;
using System.Collections.Generic;

namespace GlobalS
{
    public class Login
    {
        private readonly Dictionary<string, string> usuarios = new Dictionary<string, string>
        {
            { "admin", "1234" },
            { "cuidador", "senha" }
        };

        public bool Autenticar()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔══════════════════════════════════╗");
            Console.WriteLine("║     BEM-VINDO AO SISTEMA GLOBAL  ║");
            Console.WriteLine("╚══════════════════════════════════╝");
            Console.ResetColor();

            Console.WriteLine("\nPor favor, faça login para continuar.\n");

            Console.Write("Usuário: ");
            string usuario = Console.ReadLine();
            Console.Write("Senha: ");
            string senha = Console.ReadLine();

            if (usuarios.ContainsKey(usuario) && usuarios[usuario] == senha)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nLogin bem-sucedido. Bem-vindo!");
                Console.ResetColor();
                return true;
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nUsuário ou senha inválidos.");
            Console.ResetColor();
            return false;
        }
    }
}