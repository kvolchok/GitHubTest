namespace GitHubTest;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Введите первое число:");
        double firstNumber = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Введите второе число:");
        double secondNumber = Convert.ToDouble(Console.ReadLine());
        
        double sun = firstNumber + secondNumber;
        Console.WriteLine("Результат сложения " + sun);
    }
}