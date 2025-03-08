using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicanotas
{
    class Program
    {


        static void Main(string[] args)
        {
            Nota nota = new Nota();

            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Criar nota\n2 - Editar nota\n3 - Excluir nota\n4 - Listar notas\n5 - Sair");
            int Opcao = int.Parse(Console.ReadLine());
            while (Opcao != 5)
            {
                switch (Opcao)
                {
                    case 1:
                        nota.criarNotas();
                        Console.WriteLine("Escolha uma opção:");
                        Console.WriteLine("1 - Criar nota\n2 - Editar nota\n3 - Excluir nota\n4 - Listar notas\n5 - Sair");
                        Opcao = int.Parse(Console.ReadLine());
                        break;
                    case 2:
                        nota.editarNotas();
                        Console.WriteLine("Escolha uma opção:");
                        Console.WriteLine("1 - Criar nota\n2 - Editar nota\n3 - Excluir nota\n4 - Listar notas\n5 - Sair");
                        Opcao = int.Parse(Console.ReadLine());
                        break;
                    case 3:
                        nota.excluirNotas();
                        Console.WriteLine("Escolha uma opção:");
                        Console.WriteLine("1 - Criar nota\n2 - Editar nota\n3 - Excluir nota\n4 - Listar notas\n5 - Sair");
                        Opcao = int.Parse(Console.ReadLine());
                        break;
                    case 4:
                        nota.listarNotas();
                        Console.WriteLine("Escolha uma opção:");
                        Console.WriteLine("1 - Criar nota\n2 - Editar nota\n3 - Excluir nota\n4 - Listar notas\n5 - Sair");
                        Opcao = int.Parse(Console.ReadLine());
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        Console.WriteLine("Escolha uma opção:");
                        Console.WriteLine("1 - Criar nota\n2 - Editar nota\n3 - Excluir nota\n4 - Listar notas\n5 - Sair");
                        Opcao = int.Parse(Console.ReadLine());
                        break;
                }
            }
        }
    }
}