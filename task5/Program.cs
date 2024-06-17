namespace task5;
/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
 * Створіть клас Calculator, методи якого приймають аргументи та повертають
 * значення типу dynamic
 */
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть числ а");
        Int32.TryParse(Console.ReadLine(), out int a);
        Console.WriteLine("Введіть числ b");
        Int32.TryParse(Console.ReadLine(), out int b);
        
        Console.WriteLine($"a+b= { new Calculator().Plass(a,b)}");
        Console.WriteLine($"a-b={new Calculator().Minus(a,b)}");
        Console.WriteLine($"a*b={new Calculator().Mult(a,b)}");
    }
}