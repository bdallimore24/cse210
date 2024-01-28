using System;

class Program
{
    static void Main(string[] args)
    {
        
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFraction());
        Console.WriteLine(f1.GetValue());

        Fraction f2 = new Fraction(8);
        Console.WriteLine(f2.GetFraction());
        Console.WriteLine(f2.GetValue());

        Fraction f3 = new Fraction(4, 2);
        Console.WriteLine(f3.GetFraction());
        Console.WriteLine(f3.GetValue());

        Fraction f4 = new Fraction(9, 2);
        Console.WriteLine(f4.GetFraction());
        Console.WriteLine(f4.GetValue());

    }
}