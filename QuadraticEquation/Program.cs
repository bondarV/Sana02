using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;

        double a, b, c, x1, x2;
        bool isASuccess,isBSuccess,isCSuccess;
        Console.WriteLine("Введіть а:");
        do
        {
            isASuccess = double.TryParse(Console.ReadLine(), out a);
            if (!isASuccess) Console.WriteLine("Значення а введено невірно....Будь ласка введіть змінну a ще раз");
        } while (!isASuccess);
        Console.WriteLine("Введіть b:");
        do
        {
            isBSuccess = double.TryParse(Console.ReadLine(), out b);
            if (!isASuccess) Console.WriteLine("Значення b введено невірно....Будь ласка введіть змінну b ще раз");
        } while (!isBSuccess);
        Console.WriteLine("Введіть c:");
        do
        {
            isCSuccess = double.TryParse(Console.ReadLine(), out c);
            if (!isCSuccess) Console.WriteLine("Значення c введено невірно....Будь ласка введіть змінну c ще раз");
        } while (!isCSuccess);

        double D = b * b - 4 * a * c;
        if (D > 0)
        {
            x1 = first_x(a, b, c);
            x2 = second_x(a, b, c);
            Console.WriteLine($"x1 = {x1}\nx2={x2}");
        }
        else if (D == 0)
        {
            x1 = first_x(a, b, c);
            Console.WriteLine($"Два однакових коренів (x1 = x2) = {x1}");
        }
        else Console.WriteLine("Функція не містить коренів");
    }
    static double first_x(double a,double b,double c)
    {
        double D = b * b - 4 * a * c;
        double x1 = ((-b + System.Math.Sqrt(D)) / (2 * a));
        return x1;
    }
    static double second_x(double a, double b, double c)
    {
        double D = b * b - 4 * a * c;
        double x2 = ((-b - System.Math.Sqrt(D) )/ (2 * a));
        return x2;
    }
}