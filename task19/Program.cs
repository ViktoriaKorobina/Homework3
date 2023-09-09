// Задача 19: Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.

int num = WorkWithUser("Введите пятизначное число: ");
if(IsNumberFiveDigit(num))
{
    Palindrome(num);
}
else Console.WriteLine("Введено не пятизначное число!");

int WorkWithUser(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

bool IsNumberFiveDigit(int number) // В этом методе делается проверка на пятизначность
{
    if(number > 9999 && number < 100000) return true;
    else return false;
}

int Digit(int number, int discharge) // В этом методе извлекается цифра в зависимости от разряда (второй аргумент метода)
{
    int digit = 0;
    int temp = 0;
    for (int i = 0; i < discharge; i++)
    {
        temp = temp * 10 + 9;
    }
    while (number > temp)
    {
        number /= 10;
    }
    digit = number % 10;
    return digit;
}

void Palindrome(int number)
{
    int firstDigit = Digit(num, 1);
    int secondDigit = Digit(num, 2);
    int fourthDigit = Digit(num, 4);
    int fifthDigit = Digit(num, 5);
    if(firstDigit == fifthDigit && secondDigit == fourthDigit)
    {
        Console.WriteLine("Да");
    }
    else Console.WriteLine("Нет");
}

