// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int Prompt(string message){
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int M = Prompt ("Введите число M => ");
int N = Prompt ("Введите число N => ");

int FindSum(int numberFirst, int numberSecond)
{
    if (numberFirst > numberSecond)
    {
        return 0;
    }
    return numberFirst + FindSum(numberFirst+1, numberSecond);
}
int result = FindSum(M, N);

Console.WriteLine($"Сумма натуральных элементов в промежутке от {M} до {N} равна {result}");

