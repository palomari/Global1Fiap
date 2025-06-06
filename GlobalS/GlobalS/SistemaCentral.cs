using GlobalS;
using System;
using System.Collections.Generic;

namespace GlobalS
{
    public class SistemaCentral
    {
        private List<PessoaVulneravel> moradores = new List<PessoaVulneravel>();
        private List<Alerta> alertas = new List<Alerta>();

        public void MenuPrincipal()
        {
            int opcao;
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("\n╔════════════════════════════════════════╗");
                Console.WriteLine("║        SISTEMA GLOBAL - MENU           ║");
                Console.WriteLine("╚════════════════════════════════════════╝");
                Console.ResetColor();

                Console.WriteLine("1) Cadastrar Pessoa Vulnerável");
                Console.WriteLine("2) Registrar Alerta");
                Console.WriteLine("3) Exibir Moradores Vulneráveis");
                Console.WriteLine("4) Exibir Alertas Registrados");
                Console.WriteLine("0) Sair do Sistema");

                Console.Write("\nDigite sua opção: ");
                try
                {
                    opcao = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (opcao)
                    {
                        case 1: CadastrarPessoa(); break;
                        case 2: RegistrarAlerta(); break;
                        case 3: ListarMoradores(); break;
                        case 4: ListarAlertas(); break;
                        case 0:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Encerrando o sistema. Até logo!");
                            Console.ResetColor();
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Opção inválida. Tente novamente.");
                            Console.ResetColor();
                            break;
                    }
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Erro: entrada inválida. Digite apenas números.");
                    Console.ResetColor();
                    opcao = -1;
                }

            } while (opcao != 0);
        }

        private void CadastrarPessoa()
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Endereço: ");
            string endereco = Console.ReadLine();
            Console.Write("Tipo de Deficiência: ");
            string tipo = Console.ReadLine();

            var pessoa = new PessoaVulneravel(nome, endereco, tipo);
            moradores.Add(pessoa);
            Console.WriteLine("Pessoa cadastrada com sucesso.");
        }

        private void RegistrarAlerta()
        {
            Console.Write("Local: ");
            string local = Console.ReadLine();
            Console.Write("Tipo de Alerta (Queda, Gesto, Outro): ");
            string tipo = Console.ReadLine();

            var alerta = new Alerta(local, tipo);
            alertas.Add(alerta);
            Console.WriteLine("Alerta registrado.");
        }

        private void ListarMoradores()
        {
            Console.WriteLine("\n--- Moradores Vulneráveis ---");
            moradores.ForEach(p => Console.WriteLine(p));
        }

        private void ListarAlertas()
        {
            Console.WriteLine("\n--- Alertas Registrados ---");
            alertas.ForEach(a => Console.WriteLine(a));
        }
    }
}