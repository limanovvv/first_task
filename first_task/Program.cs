// See https://aka.ms/new-console-template for more information
namespace first_task;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Выберите задание (1 - калькулятор, 2 - поиск максимального слова в массиве):");
        int choise = Int32.Parse(Console.ReadLine());
     
        if(choise == 1){
            
            Calculator.Do();
    
        }
        else if(choise == 2){
    
            MaxLengthWord.Do();
    
        }
        else{
        
            Console.WriteLine("Ошибка! Выберите корректное число");
    
        }
    }
}