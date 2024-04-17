

namespace first_task;
class Calculator
{
    public static void Do()
    {
        Console.WriteLine("Введите первое число:");
        var number1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите операцию (+, -, *, /):");
        var operation = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        var number2 = Convert.ToDouble(Console.ReadLine());

        double result = 0;
        switch (operation)
        {
            case '+':
                result = number1 + number2;
                break;
            case '-':
                result = number1 - number2;
                break;
            case '*':
                result = number1 * number2;
                break;
            case '/':
                if (number2 != 0)
                {
                    result = number1 / number2;
                }
                else
                {
                    Console.WriteLine("Делить на ноль нельзя");
                    return;
                }
                break;
            default:
                Console.WriteLine("Операция не распознана");
                return;
        }

        Console.WriteLine($"Ответ: {Math.Round(result, 4)}");
    }
}

