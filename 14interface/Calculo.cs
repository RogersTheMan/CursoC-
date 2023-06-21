using System;

class Calculo : IPadrao
{
    public void somar(double n1, double n2)
    {
        Console.WriteLine("A soma é "+(n1+n2));
    }

    public void sub(double n1,double n2)
    {
        Console.WriteLine("A sub é "+(n1-n2));

    }
}