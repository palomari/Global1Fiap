using System;

namespace GlobalS
{
    class Program
    {
        static void Main(string[] args)
        {
            Login login = new Login();
            if (login.Autenticar())
            {
                SistemaCentral sistema = new SistemaCentral();
                sistema.MenuPrincipal();
            }
            else
            {
                Console.WriteLine("Encerrando o sistema por falha de autenticação.");
            }
        }
    }
}
