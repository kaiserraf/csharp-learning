class Aluno
{
    // 1º maneira
    private string? _nome; // _ é uma ideia de padronização para atributos privados (boa pratica)
    public string? Nome
    {
        get { return _nome; }
        set { _nome = value; }
    }

    // 2º maneira
    public double media { get; set; }
}