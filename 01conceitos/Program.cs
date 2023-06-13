// See https://aka.ms/new-console-template for more information
using System;

namespace _01conceitos
{

    class Program 
    {
        static void Main(string[] args)
        {
            Pessoa obj = new Pessoa();

            obj.nome = "Rodrigo";
            obj.idade = 30;
            obj.mensagem();
        }
    }    

}
