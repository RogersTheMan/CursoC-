using System;

class Pessoa
{
    public string nome = "";

    public double peso, altura;

    public double IMC()
    {
        return peso/(altura * altura);
    }

    public string situacao(double imc)
    {
        if(imc < 18.5)
        {
            return "abaixo";
        } else if(imc < 25)
        {
            return "normal";
        } else if(imc < 30)
        {
            return "acima";
        }else if(imc < 35)
        {
            return "Obeso de nível I";
        }else if(imc < 40)
        {
            return "Obeso de nível II";
        } else{
            return "Obeso de nível III";
        }
    }

    public void mensagem()
    {
        double obterIMC = IMC();

        string obterSituacao = situacao(obterIMC);

        Console.WriteLine(nome+" está "+obterSituacao+" com "+obterIMC+" de IMC!");
    }
}