using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("projeto 6 - Atribuições");

        int idade = 30;
        int idadeJoao = idade;

        Console.WriteLine(idadeJoao);

        idade = 24;

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}