namespace GitHubTest;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Введите первое число:");
        var firstNumber = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Введите второе число:");
        var secondNumber = Convert.ToDouble(Console.ReadLine());
        
        var sun = firstNumber + secondNumber;
        Console.WriteLine("Результат сложения " + sun);
    }
}