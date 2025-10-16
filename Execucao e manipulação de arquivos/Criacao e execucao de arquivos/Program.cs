using System;
namespace execarquivos
{
    class Program
    {

        static void Executar()
        {

            var arquivoEntrada = @"C:\Users\Rafae\Downloads\teste.txt";
            var arquivoSaida = @"C:\Users\Rafae\Downloads\teste_2.txt";

            var linhas = LerArquivo(arquivoEntrada);

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

            EscreverArquivos(arquivoSaida, linhaFiltrada);
            AdicionarTexto(arquivoSaida, linhaFiltrada);
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
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static void Main(string[] args)
        {
            Executar();
        }
    }
}

// sempre preferir arquivos json para salvar dados