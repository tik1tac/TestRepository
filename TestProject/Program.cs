class Program
{
    static void Main(string[] args)
    {
        var calc = new Calculator();

        Console.WriteLine($"Сумма: {calc.Add(3, 4)}");
        Console.WriteLine($"Произведение: {calc.Multiply(5, 6)}");
    }
}
public class Calculator
{
    public int Add(int a, int b) => a + b;

    public int Multiply(int a, int b) => a * b;
    public int Multiply2(int a, int b) => a * b;
}