using System;
using System.Reflection;
using System.Collections.Generic;
using System.Data.Common;

namespace listasdicionario
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            // array 
            int[] numeros = new int[3];
            int[] nums = new int[] { 1, 2, 3 };

            // listas e dicionarios
            List<int> aids = new List<int>(); // array mais complexo -> possui funcionalidades que o array não tem
            var ids = new List<int>(); // forma de declarar para economizar código

            int item1 = numeros.Length;
            int item2 = nums.Length;
            int item3 = aids.Count; // lista não possui .Lenght pois não tem tamanho -> se conta

            Console.WriteLine(item1);  // 3
            Console.WriteLine(item2); // 3
            Console.WriteLine(item3); // 0

            aids.Add(10);// adiciona item na lista
            aids.Add(11);
            aids.Add(12);

            foreach (var id in aids)
            {
                Console.WriteLine(id);
            }

            Console.WriteLine(aids.Count);

            // codigo para solicitar valores

            Console.WriteLine("Digite um valor para a lista e ao terminar digite -1: ");

            while (true)
            {
                Console.WriteLine("Digite um valor: ");
                int num = int.Parse(Console.ReadLine());

                ids.Add(num);

                if (num == -1)
                {
                    break;
                }
            }

            Console.WriteLine(string.Join(',', ids));
            ids.Sort(); // ordena a lista
            // até digitar -1

            // DICIONARIO
            var alunos = new Dictionary<int, string>();
            alunos.Add(2025105563, "Rafael Machado");
            alunos.Add(2025105454, "Rafael Sales");
            alunos.Add(20256708, "Maria Julia");

            Console.WriteLine("RA: ");
            var raTexto = Console.ReadLine();
            int.TryParse(raTexto, out int ra);

            string nomeAluno = alunos[ra];

            Console.WriteLine(nomeAluno);


            /*
                TAREFA DE SALA

             criar dois dicionarios
             int:string -> idProduto:nome
             int:double -> idProduto:preço

             Enquanto não digitar -1;
             Solicitar ID, nome, valor;
             Adicionar nos dois dicionarios;
             Mostrar id | nome | valor;
            */

            // TAREFA DE SALA

            var produtos = new Dictionary<int, string>();
            var produtos2 = new Dictionary<int, double>();

            while (true)
            {
                Console.WriteLine("Digite a ID de um produto: ");
                int idProduto = int.Parse(Console.ReadLine());


                Console.WriteLine("Digite o nome do produto: ");
                string nomeProduto = Console.ReadLine();
                Console.WriteLine("Digite o valor do produto: ");
                double valorProduto = double.Parse(Console.ReadLine());

                produtos.Add(idProduto, nomeProduto);
                produtos2.Add(idProduto, valorProduto);

                Console.WriteLine("Quer continuar? (1 = sim | 0 = não)");
                int confirmacao = int.Parse(Console.ReadLine());

                if (confirmacao == 0)
                {
                    break;
                }
            }

            Console.WriteLine("ID | PRODUTO | VALOR");
            foreach (KeyValuePair<int, string> parProduto in produtos)
            {
                int id = parProduto.Key;
                string nome = parProduto.Value;
                double valor = produtos2[id];

                Console.WriteLine($"{id} | {nome} | R$ {valor:F2}");
            }


        }
    }
}

/*
 lista não é lida se não tiver nada dentro dela
 */