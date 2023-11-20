using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

int number;
bool check;
Console.WriteLine("Введіть ціле число у діапазоні [0,9]");
do
{
    check = int.TryParse(Console.ReadLine(), out number);
    if (!check) Console.WriteLine("Введіть будь ласка число !!!");
} while (!check);
switch (number)
{   
    case 0: Console.Write("нуль"); break;
    case 1: Console.Write("один"); break;
    case 2: Console.Write("два"); break;
    case 3: Console.Write("три"); break;
    case 4: Console.Write("чотири"); break;
    case 5: Console.Write("п'ять"); break;
    case 6: Console.Write("шість"); break;
    case 7: Console.Write("сім"); break;
    case 8: Console.Write("вісім"); break;
    case 9: Console.Write("дев'ять"); break;
    default: Console.Write("Ви ввели число поза діапазоном"); break;
}