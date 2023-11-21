using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;

        int n;
        bool checkNumber;
        double a, b, c;
        Console.WriteLine("Введіть довільне натуральне число(n)");
        do
        {
            checkNumber = int.TryParse(Console.ReadLine(), out n);
            if (!checkNumber) Console.WriteLine("Введіть число"); } while (!checkNumber);
        a = calculation_value_a(n);
        b = calculation_value_b(n);
        c = calculation_value_c(n);
        Console.WriteLine($"Значення виразу\na = {a}\nb = {b}\nc = {c} ");
    }
    static double calculation_value_a(int number)
    {
        double a = 0;
        for (int n = 1; n <= number; n++)
        {
            a += Math.Pow(-1, n) / (2 * n + 1);
        }
        return a;
    }
    static double calculation_value_b(int number)
    {
        double b = 0;
        for (int n = 1; n <= number; n++)
        {
            b += 1 + 1 / Math.Pow(n, 2);
        }
        return b;
    }
    static double calculation_value_c(int number)
    {
        double c = 1;
        for (int n = 1; n <= number; n++)
        {
            c *= n;
        }
        return c;
    }
}