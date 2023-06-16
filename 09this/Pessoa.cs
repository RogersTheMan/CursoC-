using System;

class Pessoa
{
    private string nome = "Claudin";

    public Pessoa(string nome)
    {
        Console.WriteLine(nome);
        Console.WriteLine(this.nome);
    }
}