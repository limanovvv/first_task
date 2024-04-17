
/// <summary>
/// простая программа-калькулятор
/// позволяет пользователю вводить числа
/// и выполнять математические операции + - * /
/// </summary>
namespace first_task;
class Calculator
{
    
    enum Operation
    {
        Add,
        Subtract,
        Multiply,
        Divide
    }

   
    /// <summary>
    /// метод, который
    /// позволяет пользователю вводить числа
    /// и выполнять математические операции + - * /
    /// </summary>
    public static void Do()
    {
        Console.WriteLine("Введите первое число:");
        var number1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Выберите операцию (0 - сложение, 1 - вычитание, 2 - умножение, 3 - деление):");
        var operation = (Operation) Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        var number2 = Convert.ToDouble(Console.ReadLine());

        double result = 0;

        
        /// <summary>
        /// управляющая конструкция
        /// внутри enum
        /// </summary>
        switch (operation)
        {
            case Operation.Add:
                result = number1 + number2;
                break;
            case Operation.Subtract:
                result = number1 - number2;
                break;
            case Operation.Multiply:
                result = number1 * number2;
                break;
            case Operation.Divide:
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

