using System;
class Programa
{
    static void Main(string[] args)
    {
        double salario = 3500.15;
        Console.WriteLine(salario);

        int salarioInteiro = (int)salario;
        Console.WriteLine(salarioInteiro);

        //O long tem 64 bits
        long x = 200000000000000;
        Console.WriteLine(x);

        short y = 15350;
        Console.WriteLine(y);

        float altura = 1.72f;
        Console.WriteLine(altura);

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}