/// <summary>
/// простая программа-поиск слова с наибольшей длиной в массиве строк
/// </summary>

namespace first_task;

class MaxLengthWord
{
    
    /// <summary>
    /// метод задает размер массива через консоль
    /// заполняет его также через консоль
    /// и выводит самое длинное слово в этом массиве
    /// </summary>
    public static void Do(){
        Console.WriteLine("Введите размер массива:");
        var size = Int32.Parse(Console.ReadLine());
    
        var words = new string[size];
    
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"Введите слово {i + 1}: ");
            words[i] = Console.ReadLine();
        }

        Console.WriteLine($"Самое длинное слово: {GetMaxLengthWord(words)}");
        
    }
    
    /// <summary>
    /// метод принимает строковый массив
    /// возвращает слово с наибольшей длиной
    /// </summary>
    static string GetMaxLengthWord(string[] words)
    {
        string maxLengthWord = "";
        int maxLength = 0;

        foreach (string word in words)
        {
            if (word.Length > maxLength)
            {
                maxLength = word.Length;
                maxLengthWord = word;
            }
        }

        return maxLengthWord;
    }

}