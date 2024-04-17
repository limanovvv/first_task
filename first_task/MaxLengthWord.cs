namespace first_task;

class MaxLengthWord
{
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