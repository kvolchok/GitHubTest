namespace GitHubTest;

public class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Введите первое число:");
            var firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Выберите команду: \n" +
                              "1. + \n" +
                              "2. - \n" + 
                              "3. * \n" +
                              "4. / \n");

            var choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            var secondNumber = Convert.ToDouble(Console.ReadLine());

            CalculateOperation(choice, firstNumber, secondNumber);
        }
    }

    private static void CalculateOperation(int choice, double firstNumber, double secondNumber)
    {
        switch (choice)
        {
            case 1:
                var sun = firstNumber + secondNumber;
                Console.WriteLine("Результат сложения " + sun);
                break;
            case 2:
                var difference = firstNumber - secondNumber;
                Console.WriteLine("Результат вычитания " + difference);
                break;
            case 3:
                var product = firstNumber + secondNumber;
                Console.WriteLine("Результат умножения " + product);
                break;
            case 4:
                var quotient = firstNumber - secondNumber;
                Console.WriteLine("Результат деления " + quotient);
                break;
        }
    }
}