using System;

class PessoaJuridica : Padrao
{

    public override void taxaEmprestimo(double valor)
    {
        Console.WriteLine("Taxa de Empréstimo para uma Pessoa Juridica R$"+(valor * 0.2));
    }
}