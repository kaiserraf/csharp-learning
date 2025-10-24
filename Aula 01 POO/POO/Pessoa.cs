class Pessoa // classe sempre com primeira letra maiuscula
{
    // Atributos
    public string? Nome;
    public int Idade;

    // metodos de apresentação
    public void Apresentacao()
    {
        Console.WriteLine($"Olá, meu nome é {Nome}!");
    }

    public string VerificaIdade()
    {
        return Idade >= 18 ? "Maior de idade" : "Menor de idade";
    }
    
}