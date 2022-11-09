using System;

class Program
{
    static void Main(string[] args)
    {
        int a, b, prodm;

        Console.WriteLine("Digite o primeiro número!");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número!");
        b = int.Parse(Console.ReadLine());
        prodm = Convert.ToInt32(a * b);
        Console.WriteLine("O Produto da multiplicacao é igual a : " + prodm);
     
  ;
    }
}
