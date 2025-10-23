using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
namespace arquivocsv
{
    class Program
    {

        static void Executar()
        {

            var arquivoEntrada = @"C:\Users\Rafae\OneDrive\Área de Trabalho\C#\Arquivos CSV\alunos.csv";
            var arquivoSaida = @"C:\Users\Rafae\OneDrive\Área de Trabalho\C#\Arquivos CSV\alunos_2.csv";

            var linhas = LerArquivo(arquivoEntrada);
            /*
            var linhaFiltrada = new List<string>();
            int i = 0;
            foreach (var linha in linhas)
            {
                if (i < 5)
                {
                    linhaFiltrada.Add(linha);
                }
                i++;
            }

            foreach (var linha in linhaFiltrada)
            {
                Console.WriteLine(linha);
            }
            */

            //EscreverArquivos(arquivoSaida, linhaFiltrada);
            //AdicionarTexto(arquivoSaida, linhaFiltrada);
            AtividaDeAula(arquivoEntrada);
        }

        static string[] LerArquivo(string arquivoEntrada)
        {
            try
            {
                var linhas = File.ReadAllLines(arquivoEntrada);
                return linhas;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return new string[] { };
            }
        }

        static void EscreverArquivos(string arquivoSaida, List<string> linhas)
        {
            try
            {
                File.WriteAllLines(arquivoSaida, linhas);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        static void AdicionarTexto(string arquivoSaida, List<string> linhas)
        {
            try
            {
                File.AppendAllLines(arquivoSaida, linhas);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        
        static void AtividaDeAula(string arquivoEntrada)
        {
            try
            {
                String[] linhas = File.ReadAllLines(arquivoEntrada);
                foreach (var linha in linhas.Skip(1))
                {
                    String[] colunas = linha.Split(";"); // quebra a linha
                    foreach (var coluna in colunas)
                    {
                        Console.Write($"{coluna} |");
                    }
                    
                    Console.WriteLine("");

                    //atividade de sala - média

                    float.TryParse(colunas[2], out float nota1);
                    float.TryParse(colunas[3], out float nota2);
                    float media = (nota1 + nota2) / 2;

                    Console.WriteLine($"{colunas[1]} | {colunas[2]} | {colunas[3]} | {media}");


                }
                
            }
            catch (FileNotFoundException FNFE)
            {
                Console.WriteLine(FNFE);
            }
        }

        public static void Main(string[] args)
        {
            Executar();
        }
    }
}

// sempre preferir arquivos json para salvar dados

// arquivo delimitado
/*
    ID  | NOME   | ENDEREÇO      |
    123 | RAFAEL | RUA TESTE, 123| 
    456 | FULANO | RUA TEST1, 456|

pode ser qualquer caractere separando as informações (dar preferencia aos que raramente são usados)
*/
