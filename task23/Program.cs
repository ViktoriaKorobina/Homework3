// Задача 23: Напишите программу, которая принимает на
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int num = WorkWithUser("Введите число: ");
Cube(num);

void Cube(int number)
{
    int i = 1;
    while(i <= number)
    {
        if(i == number)
        {
        Console.Write(i * i * i);
        }
        else Console.Write(i * i * i + ", ");
        i++;
    }
}
int WorkWithUser(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}