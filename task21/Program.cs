// Задача 21: Напишите программу, которая принимает на
// вход координаты двух точек и находит расстояние
// между ними в 3D пространстве.

double xa = WorkWithUser("Введите координату Xa: ");
double ya = WorkWithUser("Введите координату Ya: ");
double za = WorkWithUser("Введите координату Za: ");
double xb = WorkWithUser("Введите координату Xb: ");
double yb = WorkWithUser("Введите координату Yb: ");
double zb = WorkWithUser("Введите координату Zb: ");
double distance = Distance(xa, ya, za, xb, yb, zb);
Console.WriteLine(distance);

double WorkWithUser(string message)
{
    Console.Write(message);
    double number = double.Parse(Console.ReadLine());
    return number;
}
double Distance(double Xa, double Ya, double Za, double Xb, double Yb, double Zb)
{
    double a = Xa - Xb;
    double b = Ya - Yb;
    double c = Za - Zb; 
    return Math.Sqrt(a * a + b * b + c * c);
}