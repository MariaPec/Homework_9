// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int Prompt(string message){
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}


int M = Prompt ("Введите число M => ");
int N = Prompt ("Введите число N => ");

void PrintEvenNumbers(int numberFirst, int numberSecond)
{

    if (numberFirst >= numberSecond)
    {
        return;
    }
    if (numberFirst % 2 != 0)
    {
        numberFirst = numberFirst +1;
    }
    Console.WriteLine(numberFirst);
    PrintEvenNumbers(numberFirst+1, numberSecond);
}

PrintEvenNumbers(M, N);

