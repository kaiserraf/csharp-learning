class Pessoa
{
    // 1º Construtor: sem parametros
    public Pessoa()
    {
        Console.WriteLine("Hello World");
    }

    // 2º Construtor: parametros nome
    public Pessoa(string nome)
    {
        Console.WriteLine($"Olá {nome}");
    }

    // 3º Construtor: parametros nome e idade
    public Pessoa(string nome, int idade)
    {
        Console.WriteLine($"Olá {nome}, você tem {idade} anos");
    }

}


