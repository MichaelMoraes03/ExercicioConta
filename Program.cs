using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace uou
{
    public class Program
    {
        public static List<Pessoa> pessoas = new List<Pessoa>();
        public static void Main()
        {


            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("===== MENU =====");
                Console.WriteLine("1 - Cadastrar item");
                Console.WriteLine("2 - Listar itens");
                Console.WriteLine("3 - Alterar item");
                Console.WriteLine("4 - Remover item");
                Console.WriteLine("5 - Sair");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        CadastrarUsuario();

                        break;
                    case "2":
                        Listar();

                        break;
                    case "3":
                        // AlterarItem();

                        break;
                    case "4":
                        ApagarUsuario();
                        break;
                    case "5":
                        continuar = false;
                        Console.WriteLine("Até mais!");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                if (continuar)
                {
                    Console.WriteLine("\nPressione qualquer tecla pra continuar...");
                    Console.ReadKey();
                }
            }




        }
        public static void CadastrarUsuario()
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            Pessoa pessoaCriada = new Pessoa(nome, idade);
            pessoas.Add(pessoaCriada);
        }
        public static void Listar()
        {
            foreach (var p in pessoas)
            {
                Console.WriteLine(p);
            }
        }

        public static void ApagarUsuario()
        {
            Console.Write("Digite o nome da pessoa pra remover: ");
            string nomeDigitado = Console.ReadLine();

            var pessoaEscolhida = pessoas.Find((p) => p.Nome == nomeDigitado);
            Console.WriteLine(pessoaEscolhida);
            pessoas.Remove(pessoaEscolhida);
        }
    }
}
