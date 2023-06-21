using System;

class PessoaFisica : Padrao
{

    public override void taxaEmprestimo(double valor)
    {
        Console.WriteLine("Taxa de Empréstimo para uma Pessoa Fisica R$"+(valor * 0.1));
    }
}