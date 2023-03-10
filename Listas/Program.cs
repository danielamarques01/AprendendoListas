using System;
using System.Collections.Generic; //listas, dicionarios, sets, hashtables
using System.Globalization;
using System.Linq; //filtragem, remoção, busca et
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array: usamos arrays quando sabemos exatamente o numero de dados que precisa.
            //Listas: usamos listas quando não sabemos exatamente o numero de dados que precisa. Na duvida, é importante usar listas

            List<string> clientes = new List<string>();
            clientes.Add("Victor");
            clientes.Add("Lima");
            string pessoa = "José";
            clientes.Add(pessoa);

            foreach (string cliente in clientes)// pra cada cliente dentro da lista de cliente faça essa lista de bloco:
            {
                Console.WriteLine(cliente);
            }



            //FindAll para achar mais de um dado / Find para achar um dado - tambem trabalha com predicados 

            /*string busca = clientes.Find( cliente => cliente.Length > 4 );

            if (busca == null)
            {
                Console.WriteLine("Não achou");
            }

            Console.WriteLine(busca);*/

            List<string> filtrada = clientes.FindAll(cliente => cliente.Length < 5);

           Console.WriteLine("--------------------------");

            foreach (string cliente in filtrada) 
            { 
                Console.WriteLine(cliente);
            }








            /*clientes.RemoveAll(cliente => cliente == "José");
            Console.WriteLine("-----------------------");

            foreach (string cliente in clientes) // pra cada cliente dentro da lista de cliente faça essa lista de bloco:
            {
                Console.WriteLine(cliente);
            }

                (clientes.RemoveAt(1); ("RemoveAt" serve para remover algum elemento da lista)


                (clientes.Count(); (Retorna o numero de elementos da lista)*/


            }
        }
    }
