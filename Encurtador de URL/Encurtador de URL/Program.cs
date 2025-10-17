using System;
namespace encurtaurl
{
    class Program
    {

        // https://learn.microsoft.com/en-us/dotnet/csharp/ -> link para testes

        private static Dictionary<String, String> caminhos = new Dictionary<string, string>(); // declaração de dictionary para caminhos <key, value>
        static String hostEncurtado = "RafaelMachado.com"; // declaração para host do site

        public static void SepararUrl(String urlInicial)
        {
            Uri link = new Uri(urlInicial); // inciando URI -> usada especificamente para links
            String caminhoUrl = link.AbsolutePath + link.Query + link.Fragment; // juntando caminho da url
            String hostUrl = link.Host; // host da url
            atribuiValor(hostUrl, caminhoUrl, urlInicial); // chama metodo de atribuição de valor
        }

        public static void atribuiValor(String hostUrl, String caminhoUrl, String urlInicial)
        {
            Guid g = Guid.NewGuid(); // guid (bom para criação de senhas)
            String caminhoEncurtado = g.ToString().Substring(0, 8); // .Substring (0, 8) -> limitou a string para 8 caracteres
            caminhos.Add(caminhoEncurtado, urlInicial); // adiciona valor na url

            Console.WriteLine($"URL encurtada: https://{hostEncurtado}/{caminhoEncurtado}"); //mostra a url curta
        }
        static void Main(String[] args)
        {

            Console.Write("Digite uma url: "); // solicita url longa
            String urlInicial = Console.ReadLine();

            SepararUrl(urlInicial); // chama função que separa url
            
        }
    }
}

/*
 estrutura de uma url -> Host.com/CaminhoDeUrl -> Rafaelmachado.com/1234
=========================================================================
 - URI
    usado pra separar uma url
 - Dictionary<>
    armazenar chave - valor
    static -> poder usar dentro da classe
 - Random()
    UUID -> não sei usar
 - String Host -> static (rafaelmachado.com)
=========================================================================

- relacionar a url com string
- separar essa string em duas
- host -> estatico (sempre vai ser a mesma coisa)
- caminho -> variavel
- salvar em .txt

*/