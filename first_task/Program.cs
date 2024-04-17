/// <summary>
// /// позволяет пользователю выбрать функционал
// /// 1 - калькулятор, 2 - поиск максимального слова в массиве
// /// </summary>
namespace first_task;

class Program
{
    enum Choise
    {
        First,
        Second
    }
    public static void Main()
    {
        bool run = true;
        
        /// <summary>
        /// цикл для повторной работы программы
        /// </summary>
        while (run)
        {
            Console.WriteLine("Выберите задание (1 - калькулятор, 2 - поиск максимального слова в массиве):");
            Choise choise = (Choise) Int32.Parse(Console.ReadLine());

            /// <summary>
            /// управляющая конструкция
            /// внутри enum
            /// </summary>
            switch (choise)
            {
                case Choise.First:
                    Calculator.Do();
                    break;
                case Choise.Second:
                    MaxLengthWord.Do();
                    break;
                default:
                    Console.WriteLine("Введите корректное значение! 1 - калькулятор, 2 - поиск максимального слова в массиве");
                    break;    
            }
            
            /// <summary>
            /// условие выхода из цикла 
            /// </summary>
            Console.WriteLine("Хотите выполнить еще одну операцию? (y/n)");
            string ch = Console.ReadLine();
            if (ch == "n")
            {
                run = false;
            }

        }

        
        
    }
}