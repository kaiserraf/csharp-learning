// Exemplo 01:
Pessoa obj1 = new Pessoa(); // instanciando objeto
obj1.Nome = "Rafael"; // passando valor para atributo nome
obj1.Apresentacao();

// Exemplo 02:
Pessoa obj2 = new();
obj2.Nome = "Maria Julia";
obj2.Apresentacao();

// Exemplo 03:
Pessoa obj3 = new()
{
    Nome = "Daniele",
    Idade = 45
};

string retorno = obj3.VerificaIdade();
Console.WriteLine(retorno);