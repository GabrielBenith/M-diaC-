using System;

public partial class Program
{
    static void Main(string[] avgs)
    {
        double n1, n2, n3, n4, n5;

        Console.Write("Digite o Primeiro Número:");
        n1 = double.Parse(Console.ReadLine());
        Console.Write("Digite o Segundo Número:");
        n2 = double.Parse(Console.ReadLine());
        Console.Write("Digite o Terceiro Número:");
        n3 = double.Parse(Console.ReadLine);
        Console.Write("Digite O Quarto Número");
        n4 = double.Parse(Console.ReadLine);
        n5 = (n1 + n2 + n3 + n4) / 4;
        Console.Write("A média é?" + n5.ToString);
        Console.ReadKey();
    }

}
