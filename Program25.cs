// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Clear();

int enterNumberA = GetNumberFromUser("Введите первое целое число: ","Ошибка ввода!");
int enterNumberB = GetNumberFromUser("Введите второе целое число: ","Ошибка ввода!");
int result = enterNumberA;

int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
      {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    } 
}

for (int i = 2; i <= enterNumberB; i++)
    {
     result *= enterNumberA;
     }

Console.WriteLine($"{enterNumberA}, {enterNumberB} -> {result}");          