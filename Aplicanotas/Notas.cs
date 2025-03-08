using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Aplicanotas
{
    class Nota
    {
        private string titulo { get; set; }
        private string conteudo { get; set; }

        List<Nota> notas = new List<Nota>();
        public void criarNotas()
        {
            

            Console.WriteLine("Digite o título de sua nota:");
            titulo = Console.ReadLine();

           if (string.IsNullOrEmpty(titulo)) {
                Console.WriteLine("Por favor, digite alguma coisa.");
            }   

            Console.WriteLine("Digite o conteúdo de sua nota:");
            conteudo = Console.ReadLine();
            if (string.IsNullOrEmpty(conteudo)) {
                Console.WriteLine("Por favor, digite alguma coisa.");
            }   
            notas.Add(new Nota { titulo = titulo, conteudo = conteudo });
            foreach (var nota in notas)
            {
                Console.WriteLine("");
                Console.WriteLine("Título: " + nota.titulo);
                Console.WriteLine("Conteúdo: " + nota.conteudo);
            }       

        }

        public void editarNotas()
        {
            Console.WriteLine("Digite o título da nota que deseja editar:");
            titulo = Console.ReadLine();
            Console.WriteLine("Digite o novo conteúdo da nota:");
            string novoConteudo = Console.ReadLine();
            notas.Add(new Nota { titulo = titulo, conteudo = novoConteudo });
            foreach (var nota in notas)
            {
                Console.WriteLine("");
                Console.WriteLine("Título: " + nota.titulo);
                Console.WriteLine("Conteúdo: " + nota.conteudo);
            }   
        }

        public void excluirNotas()
        {
            Console.WriteLine("Digite o título da nota que deseja excluir:");
            titulo = Console.ReadLine();
            notas.RemoveAll(nota => nota.conteudo == titulo);
            foreach (var nota in notas)
            {
                Console.WriteLine("");
                Console.WriteLine("Título: " + nota.titulo);
                Console.WriteLine("Conteúdo: " + nota.conteudo);
            }
        }       

        public void listarNotas()
        {
            foreach (var nota in notas)
            {
                Console.WriteLine("");
                Console.WriteLine("Título: " + nota.titulo);
                Console.WriteLine("Conteúdo: " + nota.conteudo);
                Console.WriteLine("");
                Console.WriteLine("");
            }
        }   
    }
}
