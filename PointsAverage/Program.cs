using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;
        int firstMark, secondMark, thirdMark, fourthMark, fifthMark;
        bool checkingFirstMark, checkingSecondMark, checkingThirdMark, checkingFourthMark, checkingFifthMark;
        Console.WriteLine("Введіть 5 оцінок,які має студент");
        do
        {
            checkingFirstMark = int.TryParse(Console.ReadLine(), out firstMark);
            if (firstMark < 0 || firstMark > 100 || !checkingFirstMark)  Console.WriteLine("Оцінка не може бути поза вказаним діапазоном або бути не цифрою.....Введіть інше значення:");
        } while (firstMark < 0 || firstMark > 100 || !checkingFirstMark);
        do
        {
            checkingSecondMark = int.TryParse(Console.ReadLine(), out secondMark);
            if (secondMark < 0 || secondMark > 100 || !checkingSecondMark) Console.WriteLine("Оцінка не може бути поза вказаним діапазоном або бути не цифрою.....Введіть інше значення:");
        } while (secondMark < 0 || secondMark > 100 || !checkingSecondMark);
        do
        {
            checkingThirdMark = int.TryParse(Console.ReadLine(), out thirdMark);
            if (thirdMark < 0 || thirdMark > 100 || !checkingThirdMark) Console.WriteLine("Оцінка не може бути поза вказаним діапазоном або бути не цифрою.....Введіть інше значення:");
        } while (thirdMark < 0 || thirdMark > 100 || !checkingThirdMark);
        do
        {
            checkingFourthMark = int.TryParse(Console.ReadLine(), out fourthMark);
            if (fourthMark < 0 || fourthMark > 100 || !checkingFourthMark) Console.WriteLine("Оцінка не може бути поза вказаним діапазоном або бути не цифрою.....Введіть інше значення:");
        } while (fourthMark < 0 || fourthMark > 100 || !checkingFourthMark);
        do
        {
            checkingFifthMark = int.TryParse(Console.ReadLine(), out fifthMark);
            if (fifthMark < 0 || fifthMark > 100 || !checkingFifthMark) Console.WriteLine("Оцінка не може бути поза вказаним діапазоном або бути не цифрою.....Введіть інше значення:");
        } while (fifthMark < 0 || fifthMark > 100 || !checkingFifthMark);
        averagePoint(firstMark, secondMark, thirdMark, fourthMark, fifthMark);
    }
    static void averagePoint (int firstMark, int secondMark, int thirdMark, int fourthMark, int fifthMark){
        double average = (firstMark + secondMark + thirdMark + fourthMark + fifthMark) / 5.0;
        if (average >= 50) Console.WriteLine($"Студент допущений до іспиту,тому що його середній бал становить {average} !!!!");
        else Console.WriteLine($"Сумно,але студент не допущений до екзамену.....середній бал становить {average}");
}
    

}