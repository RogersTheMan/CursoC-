using System;

class Calculo : IPadrao
{
    public void somar(double n1, double n2)
    {
        Console.WriteLine("A soma entre "+n1+" e "+n2+" é = "+(n1+n2));
    }

    public void sub(double n1,double n2)
    {
        Console.WriteLine("A sub entre "+n1+" e "+n2+" é = " +(n1-n2));

    }

    public void mult(double n1, double n2)
    {
        Console.WriteLine("A mult entre "+n1+" e "+n2+" é = "+(n1*n2));
    }

    public void div(double n1, double n2)
    {
        Console.WriteLine("A div entre "+n1+" e "+n2+" é = "+(n1/n2));
    }
}